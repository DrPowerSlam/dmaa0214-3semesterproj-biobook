using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        //although it should be possible to find a scheduler by using the movieID
        public Scheduler GetScheduler(int movieID)
        {
            //Find the schedulerID's by movieID
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = (Scheduler)db.Schedulers.Single(x => x.MovieID == movieID);

            return scheduler;
        }
    }
}
