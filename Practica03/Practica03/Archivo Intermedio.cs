using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica03
{
    public partial class Archivo_Intermedio : Form
    {
        public Archivo_Intermedio()
        {
            InitializeComponent();
        }

        private void Archivo_Intermedio_Load(object sender, EventArgs e)
        {

        }

        public void cambiarText(int fila, int columna, string nuevoText)
        {
            if(dataGridView1.Rows.Count<fila+1)
            {
                dataGridView1.Rows.Add();
            }
            if(nuevoText=="u")
            {
                dataGridView1.Rows[fila].Cells[columna].Value = " ";
            }
            else
            {
                dataGridView1.Rows[fila].Cells[columna].Value = nuevoText;
            }
        }

        public int tamanoArchivo()
        {
            return Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0].Value.ToString(), 16) - Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString(), 16);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void crearCodigoObj(string TabSim)
        {
            string CodOP = "";
            string dir = "0";
            for(int i = 1; i<dataGridView1.Rows.Count;i++)
            {
                CodOP = "";
                dir = "0";
                switch (dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    case "ADD":
                    case "ADD/t": CodOP = "18";
                        break;
                    case "AND":
                    case "AND/t":
                        CodOP = "40";
                        break;
                    case "COMP":
                    case "COMP/t":
                        CodOP = "28";
                        break;
                    case "DIV":
                    case "DIV/t":
                        CodOP = "24";
                        break;
                    case "J":
                    case "J/t":
                        CodOP = "3C";
                        break;
                    case "JEQ":
                    case "JEQ/t":
                        CodOP = "30";
                        break;
                    case "JGT":
                    case "JGT/t":
                        CodOP = "34";
                        break;
                    case "JLT":
                    case "JLT/t":
                        CodOP = "38";
                        break;
                    case "JSUB":
                    case "JSUB/t":
                        CodOP = "48";
                        break;
                    case "LDA":
                    case "LDA/t":
                        CodOP = "00";
                        break;
                    case "LDCH":
                    case "LDCH/t":
                        CodOP = "50";
                        break;
                    case "LDL":
                    case "LDL/t":
                        CodOP = "08";
                        break;
                    case "LDX":
                    case "LDX/t":
                        CodOP = "04";
                        break;
                    case "MUL":
                    case "MUL/t":
                        CodOP = "20";
                        break;
                    case "OR":
                    case "OR/t":
                        CodOP = "44";
                        break;
                    case "RD":
                    case "RD/t":
                        CodOP = "D8";
                        break;
                    case "RSUB":
                    case "RSUB/t":
                        dataGridView1.Rows[i].Cells[4].Value = "4C0000";
                        break;
                    case "STA":
                    case "STA/t":
                        CodOP = "0C";
                        break;
                    case "STCH":
                    case "STCH/t":
                        CodOP = "54";
                        break;
                    case "STL":
                    case "STL/t":
                        CodOP = "14";
                        break;
                    case "STSW":
                    case "STSW/t":
                        CodOP = "E8";
                        break;
                    case "STX":
                    case "STX/t":
                        CodOP = "10";
                        break;
                    case "SUB":
                    case "SUB/t":
                        CodOP = "1C";
                        break;
                    case "TD":
                    case "TD/t":
                        CodOP = "E0";
                        break;
                    case "TIX":
                    case "TIX/t":
                        CodOP = "2C";
                        break;
                    case "WD":
                    case "WD/t":
                        CodOP = "DC";
                        break;
                }
                string operando = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (operando[operando.Length - 1] == 'X')
                {
                    operando = operando.Substring(0, operando.Length - 2);
                    dir = "8000";
                }
                foreach (string line in TabSim.Split('\n'))
                {
                    string[] simbolos = line.Split(new char[] { ' ', '\t' });
                    if (simbolos[0] == operando)
                    {
                        dir = (Convert.ToInt32(dir, 16) + Convert.ToInt32(simbolos[1], 16)).ToString("X");
                    }
                }
                dataGridView1.Rows[i].Cells[4].Value = CodOP + dir;
            }
        }

    }
}
