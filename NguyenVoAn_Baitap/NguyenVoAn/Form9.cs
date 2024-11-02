using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVoAn
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.btThoat.Anchor = ((AnchorStyles)((AnchorStyles.Bottom |AnchorStyles.Right)));
            this.tbKetQua.Anchor = ((AnchorStyles)((((AnchorStyles.Top |AnchorStyles.Bottom) |AnchorStyles.Left) |AnchorStyles.Right)));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Caculator";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() +" = " + kq.ToString() + "\r\n";
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() +" = " + kq.ToString() + "\r\n";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }

        private void tbKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
