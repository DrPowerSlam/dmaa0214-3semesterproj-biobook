using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Model.Database
{
    class DBHall
    {
        string cnStr = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString; // Concencting string

        public Hall selectWhereID(string hallID)
        {
            Hall hall = new Hall();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open(); // Open a connection

                string strSQL = "Select * from Hall"; // define sql statement

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while(myDataReader.Read())
                        {
                            if(hallID.Equals(myDataReader["hallID"].ToString()))
                            {
                                hall.HallID = (int)myDataReader["hallID"];
                                hall.HallName = myDataReader["name"].ToString();
                                hall.MaxNumberOfSeats = (int)myDataReader["MaxNumberOfSeats"];
                            }
                        }
 
                    }
                }
            }

            return hall;
        }
    }


}
