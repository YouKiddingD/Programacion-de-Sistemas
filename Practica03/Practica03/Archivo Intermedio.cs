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
    }
}
