﻿using System;
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
    public partial class Errores : Form
    {
        public Errores()
        {
            InitializeComponent();
        }

        public void cambiarText(string nuevoText)
        {
            this.richTextBox1.Text += nuevoText;
        }
    }
}
