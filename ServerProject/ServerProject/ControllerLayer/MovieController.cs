using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class MovieController
    {
        DBMovie dbMovie = new DBMovie();

        public IEnumerable getAllMovies()
        {
            return dbMovie.getAllMovies();
        }

        public Movie findMovieByID(int ID)
        {
            return dbMovie.selectWhereID(ID);
        }

        public Movie findMovieByName(string name)
        {
            return dbMovie.selectWhereName(name);
        }

        public void insertMovie(string name, int playTime)
        {
            dbMovie.insertMovie(name, playTime);
        }

        public void deleteMovie(Movie movie)
        {
            dbMovie.deleteCustomer(movie);
        }
    }
}
