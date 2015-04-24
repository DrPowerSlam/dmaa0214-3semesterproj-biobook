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
            scheduler.Movie = movieCtr.findMovieByID(movieID);

            return scheduler;
        }
    }
}
