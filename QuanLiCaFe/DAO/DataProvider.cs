using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCaFe.DAO
{
    public class DataProvider
    {
        private string connectionstring = "Data Source=DESKTOP-I5D1GPP;Initial Catalog=Project_cafe;Integrated Security=True;Encrypt=False";
        
        public DataSet ExecuteQuery(string query)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
     
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                connection.Close();
            }
            return dt;
        }

    
    }
}
