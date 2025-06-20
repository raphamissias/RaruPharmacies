﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmMain : Form
    {
        Interface.frmClients clientForm;
        Interface.frmProducts productForm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            clientForm = new Interface.frmClients();
            clientForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productForm= new Interface.frmProducts();
            productForm.Show();
        }
    }
}
