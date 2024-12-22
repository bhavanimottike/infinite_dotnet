using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project
{
    class DatabaseHelper
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        
        public static SqlConnection GetConnection()
        {
           con= new SqlConnection("Server =ICS-LT-D244D6GS;Database=railway; integrated security = true;");
            con.Open();
            return con;
        }

        public static void ExecuteNonQuery(string query)
        {
            con = GetConnection();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }
        public static SqlDataReader ExecuteReader(string query)
        {
            con = GetConnection();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            return dr;


        }
    }
}
