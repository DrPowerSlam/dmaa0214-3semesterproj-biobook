using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;

namespace ServerProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        public Scheduler GetScheduler(int movieID)
        {
           ServerProject.ControllerLayer.SchedulerController schedulerController = new SchedulerController();
           return schedulerController.GetScheduler(movieID);
        }
    }
}
