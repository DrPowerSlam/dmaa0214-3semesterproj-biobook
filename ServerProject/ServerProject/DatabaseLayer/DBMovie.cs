using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ServerProject.DatabaseLayer
{
    public class DBMovie
    {
        public Movie selectWhereID(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();

            Movie movie = (Movie)db.Movies.Single(x => x.MovieID.Equals(movieID));
            
            Movie movieModel = new Movie();
            //movieModel.MovieID = movie.First().MovieID;
            //movieModel.Name = movie.First().name;
            //movieModel.PlayTime = (int)movie.First().Playtime;

            return movie;
        }

        public Movie selectWhereName(string name)
        {
            var db = new ConnectToDatabaseDataContext();

            Movie movie = db.Movies.Single(x => x.name.Equals(name));

            return movie;
        }

        public ArrayList getAllMovies()
        {
            ArrayList movieList = new ArrayList();

            var db = new ConnectToDatabaseDataContext();
            int movieID = 1;

            while (movieID <= db.Movies.AsEnumerable().Last().MovieID)
            {
                Movie movie = db.Movies.Single(x => x.MovieID == movieID && !x.name.Equals(null));
                movieList.Add(movie);
                movieID++;
            }

            return movieList;
        }
    }
}
