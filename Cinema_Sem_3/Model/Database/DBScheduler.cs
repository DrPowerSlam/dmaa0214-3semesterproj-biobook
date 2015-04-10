using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Database
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        public Scheduler GetScheduler(int schedulerID)
        {
            
            var db = new ConnectToDBDataContext();

            var scheduler = db.Schedulers.Select(x => x).AsEnumerable().Where(x => x.SchID == schedulerID);

            return scheduler.First<Scheduler>();
        }
    }
}
