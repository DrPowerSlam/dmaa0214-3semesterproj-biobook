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

        /// <summary>
        /// Gets all the movies from the database
        /// </summary>
        /// <returns>Returns an IEnumerable with all the movies</returns>
        public IEnumerable getAllMovies()
        {
            return dbMovie.getAllMovies();
        }

        /// <summary>
        /// Finds a movie with a given ID
        /// </summary>
        /// <param name="ID">The ID of the movie you want to find</param>
        /// <returns>Returns the movie as a movie object</returns>
        public Movie findMovieByID(int ID)
        {
            return dbMovie.selectWhereID(ID);
        }

        /// <summary>
        /// Find a movie by a given name
        /// </summary>
        /// <param name="name">The name of the movie you want to find</param>
        /// <returns>Returns the movie as a movie object</returns>
        public Movie findMovieByName(string name)
        {
            return dbMovie.selectWhereName(name);
        }

        /// <summary>
        /// Inserts a movie into the database
        /// </summary>
        /// <param name="name">The name of the movie</param>
        /// <param name="playTime">The playtime of the movie</param>
        public void insertMovie(string name, int playTime)
        {
            dbMovie.insertMovie(name, playTime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movie"></param>
        public void deleteMovie(Movie movie)
        {
            dbMovie.deleteCustomer(movie);
        }
    }
}
