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
    public partial class ArchivoFuente : Form
    {
        public ArchivoFuente()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void cambiarText(string nuevoText)
        {
            this.richTextBox1.Text += nuevoText;
        }

        public string regresarText()
        {
            return this.richTextBox1.Text;
        }
    }
}
