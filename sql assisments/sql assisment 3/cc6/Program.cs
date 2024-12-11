using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace cc6
{
    class Program
    {

        public static SqlConnection con;
        public static SqlCommand cmd;
        public static IDataReader dr;
        static void Main(string[] args)
        {
            sing(SqlConnection con = new SqlConnection("Server=ICS-LT-D244D6GS;initial catalog=employee_details; integrated security=true;"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getsalary", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input for procedure
                    cmd.Parameters.Add(new SqlParameter("@ename", SqlDbType.VarChar, 20)).Value = "powerbank";
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int)).Value = 2000;
                    //output for procedure
                    SqlParameter p1 = new SqlParameter("@pid", SqlDbType.Int);
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@discount", SqlDbType.Float);
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    cmd.ExecuteNonQuery();
                    int pid = Convert.ToInt32(cmd.Parameters["@pid"].Value);
                    int dis = Convert.ToInt32(cmd.Parameters["@discount"].Value);
                    Console.WriteLine($"Product ID : {pid}  ,  Discount Price : {dis}");

                }
            }
            Console.Read();


        }
    }
}
