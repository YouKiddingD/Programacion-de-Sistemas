﻿using Antlr4.Runtime;
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
    public partial class Ensamblador : Form
    {
        public string filePath = "";
        ArchivoFuente archfuente;
        Archivo_Intermedio archInt;
        CodigoObjeto codObj;
        Errores errores;
        TablaSimbolos tamSimb;
        MapaMemoria mapaMemoria;
        string nombreProg;
        string progObjeto = "";
        bool extendido = false;

        public Ensamblador()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            ArchivoFuente newMDIChild = new ArchivoFuente();
            newMDIChild.MdiParent = this;
            archfuente = newMDIChild;
            archfuente.Show();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWindowsEnsamblar();

            string line = "", prog;
            prog = "";
            line = filePath;
            //SE ALMACENA LA CADENA DE ENTRADA

            string linea, error;
            System.IO.StreamReader file = null;

            try
            {
                file = new System.IO.StreamReader(@line);
                while ((linea = file.ReadLine()) != null)
                {
                    prog += linea + '\n';
                }
                error = line.Substring(0, line.Length - 1);
                if (extendido)
                {
                    using (FileStream fs = File.Create(error + "tx"))
                    {
                    }
                }
                else
                {
                    using (FileStream fs = File.Create(error + "ts"))
                    {
                    }
                }
                using (FileStream fs = File.Create(error + 'i'))
                {
                }
                prog = prog.Substring(0, prog.Length - 1);
                file.Close();
                SICLexer lex = new SICLexer(new AntlrInputStream(prog + Environment.NewLine));
                //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                CommonTokenStream tokens = new CommonTokenStream(lex);
                //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                SICParser parser = new SICParser(tokens);
                //CREAMOS EL PARSER CON LOS TOKENS CREADOS

                if(extendido)
                {
                    parser.go(error + "tx", error + 'i');
                }
                else
                {
                    parser.go(error + "ts", error + 'i');
                }
                printErrors();
                mostrarIntermedio();
            }
            catch (RecognitionException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Archivo inexistente");
            }
        }

        private void guardarTabsim(string sim, string direc)
        {
            string direccion = sim + "\t" + direc.PadLeft(4, '0');
            tamSimb.cambiarText(direccion + '\n');
        }

        private void generarProgramObjeto()
        {
            nombreProg = archInt.dataGridView1.Rows[0].Cells[1].Value.ToString().PadRight(6).Substring(0, 6);
            string dirInicio = archInt.dataGridView1.Rows[0].Cells[0].Value.ToString().PadLeft(6, '0');
            string longi = archInt.tamanoArchivo().ToString("X").PadLeft(6, '0');
            progObjeto = "H" + nombreProg + dirInicio + longi + "\n";

            int coutbytes = 0;
            string obj = "";
            string regT = "";

            for (int i = 1; i < archInt.dataGridView1.RowCount; i++)
            {
                if (!(coutbytes == 0 && obj != ""))
                {
                    if (archInt.dataGridView1.Rows[i].Cells[2].Value.ToString() == "BYTE")
                        obj = archInt.dataGridView1.Rows[i].Cells[4].Value.ToString();
                    else if (archInt.dataGridView1.Rows[i].Cells[4].Value.ToString() != "")
                        obj = archInt.dataGridView1.Rows[i].Cells[4].Value.ToString().PadLeft(6, '0').Substring(0, 6);
                    else
                        obj = "";
                }
                else
                {
                    i--;
                }

                if (obj != "")
                {
                    if (obj != "ERROR:")
                    {
                        if (coutbytes == 0)
                        {
                            string dirInitT = archInt.dataGridView1.Rows[i].Cells[0].Value.ToString().PadLeft(6, '0');
                            regT = "T" + dirInitT;
                        }

                        coutbytes += obj.Length / 2;
                        if (coutbytes <= 30)
                        {
                            regT += obj;
                        }
                        else
                        {
                            coutbytes = 0;
                            string tam = (regT.Substring(7, regT.Length - 7).Length / 2).ToString("X");
                            progObjeto += regT.Substring(0, 7) + tam.PadLeft(2, '0') + regT.Substring(7, regT.Length - 7) + "\n";
                            regT = "";
                        }
                    }
                    else
                    {
                        obj = "";
                    }
                }
                else if (regT != "")
                {
                    coutbytes = 0;
                    string tam = (regT.Substring(7, regT.Length - 7).Length / 2).ToString("X");
                    progObjeto += regT.Substring(0, 7) + tam.PadLeft(2, '0') + regT.Substring(7, regT.Length - 7) + "\n";
                    regT = "";
                }
            }
            string dirEnd = "";
            if (archInt.dataGridView1.Rows[archInt.dataGridView1.RowCount - 1].Cells[3].Value.ToString() != "")
                dirEnd = tamSimb.regresaDir(archInt.dataGridView1.Rows[archInt.dataGridView1.RowCount - 1].Cells[3].Value.ToString());
            else
                dirEnd = dirInicio;
            progObjeto += "E" + dirEnd.PadLeft(6, '0');

            codObj.cambiarText(progObjeto, filePath);

        }

        private void mostrarIntermedio()
        {
            System.IO.StreamReader file = null;
            string linea = "";
            string[] lines;
            bool noPrimeraLinea = false;
            int fila = 0, columna;
            try
            {
                string fileError = filePath.Substring(0, filePath.Length - 1);
                file = new System.IO.StreamReader(fileError + "i");
                while ((linea = file.ReadLine()) != null)
                {
                    columna = 1;
                    lines = linea.Split(new char[] { ' ', '\t' });
                    string direc = Int32.Parse(lines[0]).ToString("X");
                    archInt.cambiarText(fila, 0, direc);
                    if (noPrimeraLinea)
                    {
                        if (lines[1][0] != '\t' && lines[1][0] != ' ' && lines[1][0] != 'u')
                        {
                            guardarTabsim(lines[1], direc);
                        }
                    }
                    else
                    {
                        noPrimeraLinea = true;
                    }
                    lines = lines.Skip(1).ToArray();
                    foreach (string l in lines)
                    {
                        archInt.cambiarText(fila, columna, l);
                        columna++;
                    }
                    fila++;
                }
                file.Close();
                toolStripTextBox1.Text = "Tamaño: " + archInt.tamanoArchivo().ToString("X");
                if (!extendido)
                {
                    archInt.crearCodigoObj(tamSimb.regresarText());
                    generarProgramObjeto();
                }
                else
                {
                    archInt.llenarDireccionamiento();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Archivo inexistente");
            }
        }

        private void openWindowsEnsamblar()
        {
            //Ventana Archivo Int
            Archivo_Intermedio newMDIChild = new Archivo_Intermedio();
            newMDIChild.MdiParent = this;
            archInt = newMDIChild;
            archInt.Show();

            //Ventana Codigo Objeto
            CodigoObjeto newCodObj = new CodigoObjeto();
            newCodObj.MdiParent = this;
            codObj = newCodObj;
            codObj.Show();

            //Ventana Errores
            Errores newErrores = new Errores();
            newErrores.MdiParent = this;
            errores = newErrores;
            errores.Show();

            //Ventana Errores
            TablaSimbolos newTabSim = new TablaSimbolos();
            newTabSim.MdiParent = this;
            tamSimb = newTabSim;
            tamSimb.Show();

        }

        private void printErrors()
        {
            System.IO.StreamReader file = null;
            string linea = "";
            try
            {
                string fileError = filePath.Substring(0, filePath.Length - 1);
                if (extendido)
                    file = new System.IO.StreamReader(fileError + "tx");
                else
                    file = new System.IO.StreamReader(fileError + "ts");

                while ((linea = file.ReadLine()) != null)
                {
                    errores.cambiarText(linea + '\n');
                }
                file.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Archivo inexistente");
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivoFuente newMDIChild = new ArchivoFuente();
            newMDIChild.MdiParent = this;
            archfuente = newMDIChild;
            archfuente.Show();
            System.IO.StreamReader file = null;
            filePath = "";
            string linea = "";
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "SIC estandar (*.s)|*.s|SICXE (*.x)|*.x";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                    }
                }
                if(filePath[filePath.Length-1]=='x')
                {
                    extendido = true;
                }
                else
                {
                    extendido = false;
                }
                file = new System.IO.StreamReader(filePath);
                while ((linea = file.ReadLine()) != null)
                {
                    newMDIChild.cambiarText(linea + '\n');
                }
                file.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Archivo inexistente");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "SIC estandar (*.s)|*.s|SICXE (*.x)|*.x";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    string createText = archfuente.regresarText();
                    File.WriteAllText(saveFileDialog.FileName, createText);
                    filePath = saveFileDialog.FileName;
                    if (filePath[filePath.Length - 1] == 'x')
                    {
                        extendido = true;
                    }
                    else
                    {
                        extendido = false;
                    }
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string createText = archfuente.regresarText();
                File.WriteAllText(filePath, createText);
            }
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapaMemoria newMDIChild = new MapaMemoria();
            mapaMemoria = newMDIChild;
            if (progObjeto != "")
                mapaMemoria.cargar(progObjeto, archInt.tamanoArchivo());
            mapaMemoria.Show();
        }
    }
}
