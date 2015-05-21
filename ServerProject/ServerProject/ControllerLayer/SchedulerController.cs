using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class SchedulerController
    {
       

        DBScheduler dbSch = new DBScheduler();

        public Scheduler[] GetAllSchedulers()
        {
            return dbSch.GetAllSchedulers().ToArray();

        }


        // Ikke færdig
        public IEnumerable getMovieByMovieID(int movieID)
        {
            List<Scheduler> listToReturn = new List<Scheduler>();
            foreach (Scheduler s in dbSch.getScheduler().Cast<Scheduler>())
            {
                if (s.Movie.MovieID == movieID)
                {
                    listToReturn.Add(s);
                }

            }

            return listToReturn;
        }

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

        public void CreateScheduler(DateTime date, TimeSpan time, int movieID, int hallID)
        {
            dbSch.InsertScheduler(date, time, movieID, hallID);
        }
    }
}
