using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class SchedulerController
    {

        public Scheduler getSchedulerByID(int schedulerID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            Scheduler scheduler = schedulerDatabase.getSchedulerByID(schedulerID);
            return scheduler;
        }

        public Scheduler getSchedulerByMovie(int movieID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            MovieController movieCtr = new MovieController();
            Scheduler scheduler = schedulerDatabase.getSchedulerByMovieID(movieID);
            scheduler.Movie = movieCtr.FindMovieByID(movieID);

            return scheduler;
        }
    }
}
