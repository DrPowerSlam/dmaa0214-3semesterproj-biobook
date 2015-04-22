using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class SchedulerController
    {
        public Scheduler GetScheduler(int movieID)
        {
            DBScheduler schedulerDatabase = new DBScheduler();
            return schedulerDatabase.GetScheduler(movieID);
        }
    }
}
