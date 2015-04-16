using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/MovieController.cs
=======
using System.Collections;
using ServerProject.DatabaseLayer;
using ServerProject.ModelLayer;
>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/MovieController.cs

namespace ServerProject.ControllerLayer
{
    class MovieController
    {
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/MovieController.cs
=======
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
>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/MovieController.cs
    }
}
