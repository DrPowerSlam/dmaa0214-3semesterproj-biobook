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

            
            Scheduler test = new Scheduler();
            
            var db = new ConnectToDBDataContext();

            var query2 = db.Schedulers.Select(x => x).AsEnumerable().Where(x => x.SchID == schedulerID);

            var scheduler =     (from schDB in db.Schedulers
                                where schDB.SchID == schedulerID 
                                select new Scheduler
                                    {
                                        SchID = schDB.SchID,
                                        Datetime = schDB.Datetime
                                    }).ToList<Scheduler>();


            


            return scheduler.First<Scheduler>();



        }
    }
}
