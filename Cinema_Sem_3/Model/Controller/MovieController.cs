using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Model.Database;

namespace Model.Controller
{
    public class MovieController
    {
        DBMovie dbMovie = new DBMovie();

        public ArrayList getAllMovies()
        {
            return dbMovie.getAllMovies();
        }

        public Movie findMovieByID(string ID)
        {
            return dbMovie.selectWhereID(ID);
        }

        public Movie findMovieByName(string name)
        {
            return dbMovie.selectWhereName(name);
        }
    }
}
