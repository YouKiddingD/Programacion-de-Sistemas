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
    public partial class CodigoObjeto : Form
    {
        public CodigoObjeto()
        {
            InitializeComponent();
        }

        public void cambiarText(string nuevoText, string path)
        {
            this.richTextBox1.Text += nuevoText;
            guardarArchivo(path);
        }

        public void guardarArchivo(string path)
        {
            string arch = path.Substring(0, path.Length - 1) + "obj";
            using (FileStream fs = File.Create(arch))
            {
            }
            string createText = richTextBox1.Text;
            File.WriteAllText(arch, createText);
        }
    }
}
