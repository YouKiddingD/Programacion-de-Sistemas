using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica03
{
    public partial class MapaMemoria : Form
    {
        int tam;
        string tamHex;
        string dirCargaHex;

        public MapaMemoria()
        {
            InitializeComponent();
        }

        public void cargar(string progObj, int tamArch)
        {
            string[] registros = progObj.Split('\n');
            string dirCarga = registros[0].Substring(7, 6);

            dirCargaHex = dirCarga;
            tam = tamArch;
            tamHex = tamArch.ToString("X");

            initDirecciones(dirCarga);

            for (int i = 1; i < registros.Length - 1; i++)
            {
                dirCarga = registros[i].Substring(1, 6);
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string dirT = dataGridView1.Rows[j].Cells[0].Value.ToString().Substring(0, 5);
                    if (dirT == dirCarga.Substring(0, 5))
                    {
                        int ultimo = Convert.ToInt32(dirCarga.Last().ToString(), 16);
                        for (int k = 9; k < registros[i].Length - 1; k += 2)
                        {
                            if (ultimo < 16)
                            {
                                dataGridView1.Rows[j].Cells[ultimo + 1].Value = registros[i].Substring(k, 2);
                                ultimo++;
                            }
                            else
                            {
                                ultimo = 0;
                                j++;
                                dataGridView1.Rows[j].Cells[ultimo + 1].Value = registros[i].Substring(k, 2);
                            }
                        }

                        break;
                    }
                }

            }

            initRegistros();
            initgeneral();
        }

        public void initDirecciones(string dirCarga)
        {
            int dir = Convert.ToInt32(dirCarga, 16);
            for (int i = dir; i < tam + dir; i += 16)
            {
                dataGridView1.Rows.Add(dirCarga.PadLeft(6, '0'), "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                dirCarga = (Convert.ToInt32(dirCarga, 16) + 16).ToString("X");
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            System.IO.StreamReader file = null;
            string filePath = "";
            string linea = "";
            string progObj = "";
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Programa Objeto (*.obj)|*.obj";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                    }
                }
                file = new System.IO.StreamReader(filePath);
                while ((linea = file.ReadLine()) != null)
                {
                    progObj += linea + '\n';
                }
                file.Close();

                cargar(progObj, Convert.ToInt32(progObj.Substring(13, 6).ToString(), 16));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Archivo inexistente");
            }
        }

        private void initRegistros()
        {
            dataGridView2.Rows.Add("CP", dirCargaHex);
            dataGridView2.Rows.Add("A", "FFFFFF");
            dataGridView2.Rows.Add("X", "FFFFFF");
            dataGridView2.Rows.Add("L", "FFFFFF");
            dataGridView2.Rows.Add("SW", "FFFFFF");
        }

        private void initgeneral()
        {
            txtDirCarga.Text = dirCargaHex.PadLeft(6, '0');
            txtLong.Text = tamHex.ToString().PadLeft(6, '0');
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Se conoce el valor del contador
            string CPHex = dataGridView2.Rows[0].Cells[1].Value.ToString();
            int CP = Convert.ToInt32(CPHex, 16);
            //3 primeros digitos del CP
            string dirCP1 = CPHex.Substring(0, 5);
            //Ultimo digito del CP
            string dirCP2 = CPHex.Substring(5, 1);
            int indexCell = Convert.ToInt32(dirCP2, 16) + 1;

            //Se leen 3 bytes
            string instruccion = getInstruccion(dirCP1, indexCell);

            //Se actualiza el valor del CP
            string CPHexAux = CPHex;
            CP += 3;
            CPHex = CP.ToString("X").PadLeft(6, '0');
            dataGridView2.Rows[0].Cells[1].Value = CPHex;

            //Se interpreta la instruccion
            string codOp = instruccion.Substring(0, 2);
            string nemonico = getNemonico(codOp);
            string efecto = getEfecto(codOp);
            string operando = instruccion.Substring(2, 4);

            dataGridView3.Rows.Add(CPHexAux, nemonico, codOp, "", operando, efecto);

            //Se aplica el efecto

        }

        private string getInstruccion(string dirCP1, int indexCell)
        {
            string instruccion = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string currentDir = dataGridView1.Rows[i].Cells[0].Value.ToString();

                if (currentDir.Substring(0, 5) == dirCP1)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        instruccion += dataGridView1.Rows[i].Cells[indexCell].Value.ToString();
                        indexCell++;
                        if (indexCell > 16)
                        {
                            i++;
                            indexCell = 1;
                        }
                    }
                    break;
                }
            }

            return instruccion;
        }

        private string getNemonico(string codOp)
        {
            string instruccion = "";

            switch (codOp)
            {
                case "18":
                    instruccion = "ADD"; break;
                case "40":
                    instruccion = "AND"; break;
                case "28":
                    instruccion = "COMP"; break;
                case "24":
                    instruccion = "DIV"; break;
                case "3C":
                    instruccion = "J"; break;
                case "30":
                    instruccion = "JEQ"; break;
                case "34":
                    instruccion = "JGT"; break;
                case "38":
                    instruccion = "JLT"; break;
                case "48":
                    instruccion = "JSUB"; break;
                case "00":
                    instruccion = "LDA"; break;
                case "50":
                    instruccion = "LDCH"; break;
                case "08":
                    instruccion = "LDL"; break;
                case "04":
                    instruccion = "LDX"; break;
                case "20":
                    instruccion = "MUL"; break;
                case "44":
                    instruccion = "OR"; break;
                case "D8":
                    instruccion = "RD"; break;
                case "4C":
                    instruccion = "RSUB"; break;
                case "0C":
                    instruccion = "STA"; break;
                case "54":
                    instruccion = "STCH"; break;
                case "14":
                    instruccion = "STL"; break;
                case "E8":
                    instruccion = "STSW"; break;
                case "10":
                    instruccion = "STX"; break;
                case "1C":
                    instruccion = "SUB"; break;
                case "E0":
                    instruccion = "TD"; break;
                case "2C":
                    instruccion = "TIX"; break;
                case "DC":
                    instruccion = "WD"; break;
            }

            return instruccion;
        }

        private string getEfecto(string codOp)
        {
            string efecto = "";

            switch (codOp)
            {
                case "18":
                    efecto = "A<-(A)+(m..m+2)"; break;
                case "40":
                    efecto = "A<-(A)&(m..m+2)"; break;
                case "28":
                    efecto = "A:(m..m+2)"; break;
                case "24":
                    efecto = "A<-(A)/(m..m+2)"; break;
                case "3C":
                    efecto = "CP<-m"; break;
                case "30":
                    efecto = "CP<-m si CC esta en ="; break;
                case "34":
                    efecto = "CP<-m si CC esta en >"; break;
                case "38":
                    efecto = "CP<-m si CC esta en <"; break;
                case "48":
                    efecto = "L<-(CP);  CP<-m"; break;
                case "00":
                    efecto = "A<-(m..m+2)"; break;
                case "50":
                    efecto = "A[el byte de mas a la derecha]<-(m)"; break;
                case "08":
                    efecto = "L<-(m..m+2)"; break;
                case "04":
                    efecto = "X<-(m..m+2)"; break;
                case "20":
                    efecto = "A<-(A)*(m..m+2)"; break;
                case "44":
                    efecto = "A<-(A)|(m..m+2)"; break;
                case "D8":
                    efecto = "A[el byte de mas a la derecha]<-datos del dispositivo especificado por (m)"; break;
                case "4C":
                    efecto = "CP<-(L)"; break;
                case "0C":
                    efecto = "m..m+2<-(A)"; break;
                case "54":
                    efecto = "m<-A[el byte de mas a la derecha]"; break;
                case "14":
                    efecto = "m..m+2<-(L)"; break;
                case "E8":
                    efecto = "m..m+2<-(SW)"; break;
                case "10":
                    efecto = "m..m+2<-(X)"; break;
                case "1C":
                    efecto = "A<-(A)-(m..m+2)"; break;
                case "E0":
                    efecto = "Prueba el dispositivo especificado por (m). Modifica el codigo de condicion para indicar el resultado de la prueba. < listo para enviar o recibir, = ocupado, > no esta operativo"; break;
                case "2C":
                    efecto = "X<-(X)+1; (X):(m..m+2)"; break;
                case "DC":
                    efecto = "Dispositivo especificado por (m)<-(A)[el byte de mas a la derecha]"; break;
            }

            return efecto;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
