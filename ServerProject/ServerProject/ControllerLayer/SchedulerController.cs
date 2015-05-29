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

        public List<Scheduler> GetAllSchedulers()
        {

            List<Scheduler> schedulerList = dbSch.GetAllSchedulers();
            
            return schedulerList;

        }


        // Ikke færdig
        public IEnumerable getMovieByMovieID(int movieID)
        {
            List<Scheduler> listToReturn = new List<Scheduler>();
            foreach (Scheduler s in dbSch.GetScheduler().Cast<Scheduler>())
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
            Scheduler scheduler = schedulerDatabase.GetSchedulerByID(schedulerID);
            return scheduler;
        }

        public Scheduler GetSchedulerByMovie(int movieID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            MovieController movieCtr = new MovieController();
            Scheduler scheduler = schedulerDatabase.GetSchedulerByMovieID(movieID);
            scheduler.Movie = movieCtr.FindMovieByID(movieID);

            return scheduler;
        }

        public void CreateScheduler(DateTime date, TimeSpan time, int movieID, int hallID)
        {
            dbSch.InsertScheduler(date, time, movieID, hallID);
        }

        public List<Scheduler> GetSchListByMovieID(int movieID)
        {
            List<Scheduler> list = dbSch.GetSchedulerListByMovieID(movieID);
            return list;
        }

        public List<Scheduler> GetByDate(DateTime date)
        {
           return dbSch.GetByDate(date);
        }

        public void UpdateSchedulers(int schID, DateTime date, TimeSpan time, int movieID, int hallID)
        {
            dbSch.UpdateSchedulers(schID, date, time, movieID, hallID);
        }
    }
}
