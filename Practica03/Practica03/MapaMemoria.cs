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
            txtDirCarga.Text = dirCargaHex;
            txtLong.Text = tamHex.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
