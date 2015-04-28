using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;

namespace WCFConnectionLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerService : ICustomerService
    {



        public Scheduler getSchedulerByMovie(int movieID)
        {
            SchedulerController schedulerController = new SchedulerController();

            return schedulerController.getSchedulerByMovie(movieID);
        }

        public Scheduler getSchedulerByID(int schedulerID)
        {
            SchedulerController schedulerController = new SchedulerController();

            return schedulerController.getSchedulerByID(schedulerID);
        }
        public void makeReservation(string row, string seat, int schedulerID)
        {
           ReserveController reserveController = new ReserveController();
           reserveController.makeReservation(row, seat, schedulerID);
        }
        

    }
}
