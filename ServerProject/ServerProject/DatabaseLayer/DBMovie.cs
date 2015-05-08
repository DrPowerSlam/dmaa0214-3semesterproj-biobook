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

            Movie movie = db.Movies.Single(x => x.MovieID == movieID);

            return movie;
        }

        public Movie selectWhereName(string name)
        {
            var db = new ConnectToDatabaseDataContext();

            Movie movie = db.Movies.Single(x => x.name.Equals(name));

            return movie;
        }

        public IEnumerable getAllMovies()
        {
            var db = new ConnectToDatabaseDataContext();

            var movies = db.Movies.Select(x => x).AsEnumerable();

            return movies;
        }

        public int insertMovie(string name, int playTime)
        {
            int controlInt = -1;
            var db = new ConnectToDatabaseDataContext();

            Movie movie = new Movie();
            movie.name = name;
            movie.Playtime = playTime;

            db.Movies.InsertOnSubmit(movie);

            try
            {
                db.SubmitChanges();
                controlInt = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return controlInt;
        }

        public int deleteCustomer(Movie movie)
        {
            int controlInt = -1;
            var db = new ConnectToDatabaseDataContext();

            Movie movieToDelete = new Movie();
            movieToDelete.name = movie.name;
            movieToDelete.MovieID = movie.MovieID;
            movieToDelete.Playtime = movie.Playtime;

            db.Movies.Attach(movieToDelete);
            db.Movies.DeleteOnSubmit(movieToDelete);

            try
            {
                db.SubmitChanges();
                controlInt = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return controlInt;
        }
    }
}
