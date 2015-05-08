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
        /// <summary>
        /// Gets a movie by the ID of a movie
        /// </summary>
        /// <param name="movieID">The ID of the movie</param>
        /// <returns>A movie of a movie object</returns>
        public Movie GetMovieByID(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();

            Movie movie = db.Movies.Single(x => x.MovieID == movieID);

            return movie;
        }

        /// <summary>
        /// Gets a movie by it's name
        /// </summary>
        /// <param name="name">Name of the movie</param>
        /// <returns>A movoe of a movie object</returns>
        public Movie GetByMovieName(string name)
        {
            var db = new ConnectToDatabaseDataContext();

            Movie movie = db.Movies.Single(x => x.name.Equals(name));

            return movie;
        }
        /// <summary>
        /// Gets all movies
        /// </summary>
        /// <returns>Returns an IEnumerable of all the movies</returns>
        public IEnumerable GetAllMovies()
        {
            var db = new ConnectToDatabaseDataContext();

            var movies = db.Movies.Select(x => x).AsEnumerable();

            return movies;
        }

        /// <summary>
        /// Inserts a movie to the database
        /// </summary>
        /// <param name="name">Name of the movie</param>
        /// <param name="playTime">Movie length in minutes</param>
        /// <returns>Returns a control int to check for success</returns>
        public int InsertMovie(string name, int playTime)
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

        /// <summary>
        /// Deletes a movie from the database
        /// </summary>
        /// <param name="movie">The movie to delete, of type movie object</param>
        /// <returns>A control int to check for success</returns>
        public int DeleteMovie(Movie movie)
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
