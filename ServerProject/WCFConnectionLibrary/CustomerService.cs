using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;
using System.Collections;

namespace WCFConnectionLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        public Reservation[] GetReservationByCustomerID(int customerID)
        {
            ReserveController resCrt = new ReserveController();
            return resCrt.GetReservationsByCustomerID(customerID).ToArray();
        }

        public List<Movie> GetAllMovies()
        {
            MovieController movieCtr = new MovieController();

            List<Movie> movieList = movieCtr.GetAllMovies();

            Scheduler scheduler = movieCtr.GetAllMovies().First().Schedulers.First();

            return movieList;


            //SchedulerController schedulerController = new SchedulerController();

            //List<Scheduler> schedulerList = schedulerController.GetAllSchedulers();

            //Reservation reservation = schedulerList.First().Reservations.First();

            //return schedulerList;
        }

        public Scheduler GetSchedulerByMovie(int movieID)
        {
            SchedulerController schedulerController = new SchedulerController();

            return schedulerController.getSchedulerByMovie(movieID);
        }

        public Scheduler GetSchedulerByID(int schedulerID)
        {
            SchedulerController schedulerController = new SchedulerController();

            return schedulerController.getSchedulerByID(schedulerID);
        }
        public void MakeReservation(string row, string seat, int schedulerID, int customerID)
        {
           ReserveController reserveController = new ReserveController();
           reserveController.makeReservation(row, seat, schedulerID, customerID);
        }
        public List<Scheduler> GetAllSchedulers()
        {
            SchedulerController schedulerController = new SchedulerController();

            List<Scheduler> schedulerList = schedulerController.GetAllSchedulers();

            Reservation reservation = schedulerList.First().Reservations.First();

            return schedulerList;

        }
        public void MakeCustomer(string name, string phoneNumber, string password, string mail)
        {
            CustomerController customerController = new CustomerController();
            customerController.InsertCustomer(name, phoneNumber, password, mail);
        }

        public void MakeScheduler(DateTime date, TimeSpan time, int movieID, int hallID)
        {
            SchedulerController SchCtr = new SchedulerController();
            SchCtr.CreateScheduler(date, time, movieID, hallID);
        }

    }
}
