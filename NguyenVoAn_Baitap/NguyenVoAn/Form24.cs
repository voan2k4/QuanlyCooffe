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
    public partial class Form24 : Form
    {
        private int second;

        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;

            tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;

            lblDisplay.Text = second.ToString();
        }
    }
}
