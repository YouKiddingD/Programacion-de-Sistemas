using Antlr4.Runtime;
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
                using (FileStream fs = File.Create(error + 't'))
                {
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

                parser.go(error + 't', error + 'i');
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
            string direccion = sim + "\t" + direc;
            tamSimb.cambiarText(direccion + '\n');
        }

        private void mostrarIntermedio()
        {
            System.IO.StreamReader file = null;
            string linea = "";
            string[] lines;
            bool noPrimeraLinea = false;
            try
            {
                string fileError = filePath.Substring(0, filePath.Length - 1);
                file = new System.IO.StreamReader(fileError + "i");
                while ((linea = file.ReadLine()) != null)
                {
                    lines = linea.Split(' ');
                    string direc = Int32.Parse(lines[0]).ToString("X");
                    archInt.cambiarText(direc);
                    if (noPrimeraLinea)
                    {
                        if (lines[1][0] != '\t' && lines[1][0] != ' ')
                        {
                            guardarTabsim(lines[1], direc);
                        }
                    }
                    else
                    {
                        noPrimeraLinea = true;
                    }
                    lines = lines.Skip(1).ToArray();
                    foreach(string l in lines)
                    {
                        archInt.cambiarText(l);
                    }
                    archInt.cambiarText("\n");
                }
                file.Close();
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
                file = new System.IO.StreamReader(fileError + "t");

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
                    openFileDialog.Filter = "Codigo fuente (*.s)|*.s";
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

            saveFileDialog.Filter = "Codigo fuente (*.s)|*.s";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    string createText = archfuente.regresarText();
                    File.WriteAllText(saveFileDialog.FileName, createText);
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
    }
}
