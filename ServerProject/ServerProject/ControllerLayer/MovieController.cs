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
        public List<Movie> GetAllMovies()
        {
            return dbMovie.GetAllMovies();
        }

        /// <summary>
        /// Finds a movie with a given ID
        /// </summary>
        /// <param name="ID">The ID of the movie you want to find</param>
        /// <returns>Returns the movie as a movie object</returns>
        public Movie FindMovieByID(int ID)
        {
            return dbMovie.GetMovieByID(ID);
        }

        /// <summary>
        /// Find a movie by a given name
        /// </summary>
        /// <param name="name">The name of the movie you want to find</param>
        /// <returns>Returns the movie as a movie object</returns>
        public Movie FindMovieByName(string name)
        {
            return dbMovie.GetByMovieName(name);
        }

        /// <summary>
        /// Inserts a movie into the database
        /// </summary>
        /// <param name="name">The name of the movie</param>
        /// <param name="playTime">The playtime of the movie</param>
        public void InsertMovie(string name, int playTime)
        {
            dbMovie.InsertMovie(name, playTime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movie"></param>
        public void DeleteMovie(Movie movie)
        {
            dbMovie.DeleteMovie(movie);
        }
    }
}
