using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            using (SqlConnection cn = new SqlConnection())
             {
                 cn.ConnectionString = "Data Source=kraka.ucn.dk;Initial Catalog=dmaa0214_3Sem_2;Persist Security Info=True;User ID=dmaa0214_3sem_2;Password=IsAllowed";
                 cn.Open();
                 string strSQL = "Select * From Customer";
                 using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                 {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            Console.WriteLine("CustomerID:{0}, Name:{1}",
                            myDataReader["CusID"].ToString(),
                            myDataReader["name"].ToString());
                        }
                    }
                }
            }
 Console.ReadLine();




 // using (SqlConnection cn = new SqlConnection())
 //            {
 //                cn.ConnectionString = "Data Source=kraka.ucn.dk;Initial Catalog=dmaa0214_3Sem_2;Persist Security Info=True;User ID=dmaa0214_3sem_2;Password=IsAllowed";
 //                cn.Open();
 //             string strSQL = "Select * from Hall"; // define sql statement
 //                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
 //                {
 //                   using (SqlDataReader myDataReader = myCommand.ExecuteReader())
 //                   {
 //                       while (myDataReader.Read())
 //                       {
 //                           Console.WriteLine("HallID:{0}, Name:{1}",
 //                           myDataReader["MaxNumberOfSeats"].ToString(),
 //                           myDataReader["MaxNumberOfSeats"].ToString());
 //                       }
 //                   }
 //               }
 //           }
 //Console.ReadLine();

 //       }











        }
        }
}
