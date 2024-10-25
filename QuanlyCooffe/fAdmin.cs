using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCooffe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            //dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = N'' OR 1 = 1--");
        }

        private void dtgvCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
