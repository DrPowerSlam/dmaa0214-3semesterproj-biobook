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

        /// <summary>
        /// A method to get all schedulers
        /// </summary>
        /// <returns>Returns a list of all schedulers</returns>
        public List<Scheduler> GetAllSchedulers()
        {

            List<Scheduler> schedulerList = dbSch.GetAllSchedulers();
            
            return schedulerList;

        }


        // Ikke færdig
        public IEnumerable GetMovieByMovieID(int movieID)
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

        /// <summary>
        /// Gets a scheduler by ID
        /// </summary>
        /// <param name="schedulerID">The scheduler ID you want to get</param>
        /// <returns>Returns the single scheduler as an object</returns>
        public Scheduler GetSchedulerByID(int schedulerID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            Scheduler scheduler = schedulerDatabase.GetSchedulerByID(schedulerID);
            return scheduler;
        }

        /// <summary>
        /// Gets a scheduler by 
        /// </summary>
        /// <param name="movieID"></param>
        /// <returns></returns>
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

        public void DeleteSch(int schID)
        {
            dbSch.DeleteSch(schID);
        }
    }
}
