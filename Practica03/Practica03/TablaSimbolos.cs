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
    public partial class TablaSimbolos : Form
    {
        public TablaSimbolos()
        {
            InitializeComponent();
        }

        private void TablaSimbolos_Load(object sender, EventArgs e)
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

        public string regresaDir(string etiqueta)
        {
            int init = richTextBox1.Text.IndexOf(etiqueta) + etiqueta.Length + 1;
            return init == -1 ? "FFFFFF" : richTextBox1.Text.Substring(init, 4);
        }
            
    }
}
