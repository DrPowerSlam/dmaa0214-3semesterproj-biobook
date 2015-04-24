using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class SchedulerController
    {
        public Scheduler getSchedulerByMovie(int movieID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            MovieController movieCtr = new MovieController();
            Scheduler scheduler = schedulerDatabase.getSchedulerByMovie(movieID);
            Movie movie = movieCtr.findMovieByID(movieID);
            scheduler.Movie = new Movie();
            scheduler.Movie.MovieID = movie.MovieID;
            scheduler.Movie.name = movie.name;
            scheduler.Movie.Playtime = movie.Playtime;
            scheduler.Movie.Schedulers.Add(scheduler);
            return scheduler;
        }
    }
}
