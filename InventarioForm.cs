﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella_System
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }

        private void btnAnadirInventario_Click(object sender, EventArgs e)
        {
            AnadirArticuloForm anadirArticuloForm = new AnadirArticuloForm();
            anadirArticuloForm.Show();
        }
    }
}
