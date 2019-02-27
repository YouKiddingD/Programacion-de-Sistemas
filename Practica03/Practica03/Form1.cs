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
    public partial class Form1 : Form
    {
        public string filePath = "";
        ArchivoFuente archfuente;
        Archivo_Intermedio archInt;

        public Form1()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivoFuente newMDIChild = new ArchivoFuente();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            archfuente = newMDIChild;
            // Display the new form.  
            archfuente.Show();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo_Intermedio newMDIChild = new Archivo_Intermedio();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            archInt = newMDIChild;
            // Display the new form.  
            archInt.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivoFuente newMDIChild = new ArchivoFuente();
            newMDIChild.MdiParent = this;
            archfuente = newMDIChild;
            archfuente.Show();
            System.IO.StreamReader file = null;
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

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string createText = archfuente.regresarText();
            File.WriteAllText(filePath, createText);
        }
    }
}
