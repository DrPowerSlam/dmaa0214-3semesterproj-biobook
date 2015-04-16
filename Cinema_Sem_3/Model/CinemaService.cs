using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;

namespace Model
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CinemaService" in both code and config file together.
    public class CinemaService : ICinemaService
    {
        public void GetScheduler(int schedulerID)
        {
            //Get the scheduler from the SchedulerController.cs
            //Show that scheduler
            GetScheduler(schedulerID);

        }
    }
}
