using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        /// <summary>
        /// Gets a scheduler by ID
        /// </summary>
        /// <param name="schedulerID">The ID of the scheduler</param>
        /// <returns>Returns the scheduler</returns>
        public Scheduler getSchedulerByID(int schedulerID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(x => x.SchID == schedulerID);

            return scheduler;
        }

        /// <summary>
        /// Find a scheduler by movie
        /// </summary>
        /// <param name="movieID">The ID of the movie</param>
        /// <returns>Returns the scheduler as a scheduler object</returns>
        public Scheduler getSchedulerByMovieID(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(dbScheduler => dbScheduler.MovieID == movieID);

            return scheduler;

        }

        /// <summary>
        /// Inserts a scheduler into the database
        /// </summary>
        /// <param name="sch">The object to insert</param>
        public void InsertScheduler(Scheduler sch)
        {
            var db = new ConnectToDatabaseDataContext();
            db.Schedulers.InsertOnSubmit(sch);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Gets all schedulers
        /// </summary>
        /// <returns>A list of schedulers</returns>
        public List<Scheduler> GetAllSchedulers()
        {
            var db = new ConnectToDatabaseDataContext();

            var Schedulerlist = db.Schedulers.Select(x => x).AsEnumerable();
            List<Scheduler> Sch = new List<Scheduler>();
            Sch = Schedulerlist.ToList();

            return Sch;
        }

        /// <summary>
        /// Gets a scheduler by date and time
        /// </summary>
        /// <param name="date">Date and time writen as yyyyMMdd hhMMss</param>
        /// <returns>A list of schedulers</returns>
        public List<Scheduler> GetByDate(DateTime date)
        {
            var db = new ConnectToDatabaseDataContext();
            var Schedulerlist = db.Schedulers.Select(x => x).Where(x => x.Datetime == date);
            List<Scheduler> Sch = new List<Scheduler>();
            Sch = Schedulerlist.ToList();

            return Sch;
        }


    }
}