using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Model
{
    class DBHall
    {
        string cnStr = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString; // Concencting string

        // Select hall by  id
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



        // Select * halls

        public ArrayList selectWhereName(string name)
        {
            ArrayList hallList = new ArrayList();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();

                string strSql = "Select * from Hall";

                using (SqlCommand myCommand = new SqlCommand(strSql, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            if(name.Equals(myDataReader["name"].ToString()))
                            {
                                Hall hall = new Hall();
                                hall.HallID = (int)myDataReader["HallID"];
                                hall.HallName = myDataReader["name"].ToString();
                                hallList.Add(hall);
                            }
                        }
                    }
 
                }
                cn.Close();
            }

            return hallList;
        }

    }


}
