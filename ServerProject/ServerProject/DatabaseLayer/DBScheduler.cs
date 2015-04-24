using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        public Scheduler getScheduler(int schedulerID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(x => x.SchID == schedulerID);

            return scheduler;
        }

        public Scheduler getSchedulerByMovie(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(dbScheduler => dbScheduler.MovieID == movieID);

            return scheduler;

        }

        public void insertScheduler(Scheduler sch)
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
        public List<Scheduler> GetAllSchedulers()
        {
            var db = new ConnectToDatabaseDataContext();

            var Schedulerlist = db.Schedulers.Select(x => x).AsEnumerable();
            List<Scheduler> Sch = new List<Scheduler>();
            Sch = Schedulerlist.ToList();

            return Sch;
        }

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