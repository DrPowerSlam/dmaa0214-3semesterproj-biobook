using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ServerProject.DatabaseLayer;
using ServerProject.ModelLayer;

namespace ServerProject.ControllerLayer
{
    public class MovieController
    {
        DBMovie dbMovie = new DBMovie();

        public ArrayList getAllMovies()
        {
            return dbMovie.getAllMovies();
        }

        public ModelLayer.Movie findMovieByID(int ID)
        {
            return dbMovie.selectWhereID(ID);
        }

        public ModelLayer.Movie findMovieByName(string name)
        {
            return dbMovie.selectWhereName(name);
        }
    }
}
