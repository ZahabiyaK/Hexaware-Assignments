using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.BuisnessLayer
{
    public class DBUtil
    {
        public static SqlConnection getDbConnection()
        {
            SqlConnection conn;
            string connectionString = "Data Source=ZAHABIYAKAPADIA\\SQLEXPRESS;Initial Catalog=FMSDB;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            return conn;
        }
    }
}
