﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVoAn
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}
