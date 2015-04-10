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
    class DBMovie
    {
        string cnStr = "Data Source=kraka.ucn.dk;Initial Catalog=dmaa0214_3Sem_2;Persist Security Info=True;User ID=dmaa0214_3sem_2;Password=IsAllowed";

        public Movie selectWhereID(string movieID)
        {
            Movie movie = new Movie();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Movie";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            if (movieID.Equals(myDataReader["MovieID"].ToString()))
                            {
                                movie.MovieID = (int)myDataReader["MovieID"];
                                movie.Name = myDataReader["name"].ToString();
                                movie.PlayTime = (int)myDataReader["Playtime"];
                            }
                        }
                    }
                }
                cn.Close();
            }
            return movie;
        }

        public Movie selectWhereName(string name)
        {
            Movie movie = new Movie();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Movie";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            if (name.Equals(myDataReader["name"].ToString()))
                            {
                                movie.MovieID = (int)myDataReader["MovieID"];
                                movie.Name = myDataReader["name"].ToString();
                                movie.PlayTime = (int)myDataReader["Playtime"];
                            }
                        }
                    }
                }
                cn.Close();
            }
            return movie;
        }

        public ArrayList getAllMovies()
        {
            ArrayList movieList = new ArrayList();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Movie";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            Movie movie = new Movie((int)myDataReader["MovieID"], myDataReader["name"].ToString(), (int)myDataReader["Playtime"]);
                            movieList.Add(movie);
                        }
                    }
                }
                cn.Close();
            }
            return movieList;
        }
    }
}
