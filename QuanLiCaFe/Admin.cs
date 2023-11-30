using QuanLiCaFe.DAO;
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

namespace QuanLiCaFe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        void LoadAccountInfoList()
        {
            string query = "SELECT * FROM dbo.AccountInfo";
            DataProvider provider = new DataProvider();
            dtgvAccountInfo.DataSource = provider.ExecuteQuery(query);
        }


    }
}
