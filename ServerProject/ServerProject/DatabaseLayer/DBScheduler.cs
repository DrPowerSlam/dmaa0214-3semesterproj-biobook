using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        public Scheduler GetScheduler(int schedulerID)
        {

            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = (Scheduler)db.Schedulers.Single(x => x.SchID == schedulerID);

            return scheduler;
        }
    }
}
