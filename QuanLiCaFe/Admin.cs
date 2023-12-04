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

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        private object dtgvDrink;
        private object dtgvAccountInfo;
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }
        private void InitializeComponent( ) 
        {
            throw new NotFiniteNumberException();
        }

        void LoadFoodList()
        {
            string query = "select * from Drink";

            dtgvDrink.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {

            string query = "EXEC dbo.USP_GetAccountInfoByUserName @userName";
            NewMethod(query);
        }
        private void NewMethod(string query) => dtgvAccountInfo.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { staff });
    }
}
