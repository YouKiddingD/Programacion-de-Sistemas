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
        public MapaMemoria()
        {
            InitializeComponent();
        }

        public void cargar(string progObj, int tam)
        {
            string[] registros = progObj.Split('\n');
            string dirCarga = registros[0].Substring(7, 6);

            initDirecciones(dirCarga, tam);

            for (int i = 1; i < registros.Length - 1; i++)
            {
                dirCarga = registros[i].Substring(1, 6);
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string dirT = dataGridView1.Rows[j].Cells[0].Value.ToString().Substring(0, 5);
                    if (dirT == dirCarga.Substring(0, 5))
                    {
                        int ultimo = Convert.ToInt32(dirCarga.Last().ToString(), 16);
                        for (int k = 9; k < registros[i].Length-1; k += 2)
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
        }

        public void initDirecciones(string dirCarga, int tam)
        {
            int dir = Convert.ToInt32(dirCarga, 16);
            for (int i = dir; i < tam + dir; i += 16)
            {
                dataGridView1.Rows.Add(dirCarga.PadLeft(6, '0'), "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF");
                dirCarga = (Convert.ToInt32(dirCarga, 16) + 16).ToString("X");
            }
        }
    }
}
