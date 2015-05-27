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

        public int[] GetBestSeats(int amount, int schedulerID)
        {
            SeatController seatCtr = new SeatController();
            int[] bestSeats = seatCtr.FindBestSeats(amount, schedulerID);

            return bestSeats;
        }

        public Movie FindMovieByName(string name)
        {
            MovieController movieCtr = new MovieController();

            return movieCtr.FindMovieByName(name);
            
        }

        public List<Reservation> GetReservationByCustomerID(int customerID)
        {
            ReserveController resCtr = new ReserveController();
            return resCtr.GetReservationsByCustomerID(customerID);
        }

        public List<Movie> GetAllMovies()
        {
            MovieController movieCtr = new MovieController();

            List<Movie> movieList = movieCtr.GetAllMovies();

            //loop through it to have the schedulers loaded imidiately
            foreach (Movie movie in movieList)
            {
                List<Scheduler> scheduler = movie.Schedulers.ToList();
            }

            return movieList;


            //SchedulerController schedulerController = new SchedulerController();

            //List<Scheduler> schedulerList = schedulerController.GetAllSchedulers();

            //Reservation reservation = schedulerList.First().Reservations.First();

            //return schedulerList;
        }

        public Scheduler GetSchedulerByMovieID(int movieID)
        {
            SchedulerController schedulerController = new SchedulerController();

            return schedulerController.GetSchedulerByMovie(movieID);
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

        // get customer by id
        public Customer GetCustomerByID(int customerID)
        {
            CustomerController customerCtr = new CustomerController();


            return customerCtr.GetCustomerByID(customerID);
        }

        // get user login
        public bool CustomerLogin(string userMail, string passWord)
        {
            CustomerController customerCtr = new CustomerController();

            return customerCtr.CustomerLogin(userMail, passWord);
        }


        public void MakeScheduler(DateTime date, TimeSpan time, int movieID, int hallID)
        {
            SchedulerController SchCtr = new SchedulerController();
            SchCtr.CreateScheduler(date, time, movieID, hallID);
        }

        public List<Scheduler> GetSchedulerListByMovieID(int movieID)
        {
            SchedulerController SchCtr = new SchedulerController();
            return SchCtr.GetSchListByMovieID(movieID);
        }

        public int[][] GetAllAvailableSeats(int schID)
        {
            SeatController seatCtr = new SeatController();
            return seatCtr.ListAvailable(schID);
        }

        public Customer GetCustomerByPhone(string phone)
        {
            CustomerController cStr = new CustomerController();
            return cStr.getByPhone(phone);
        }

        public List<Reservation> GetResByCusPhone(string phone)
        {
            ReserveController rCtr = new ReserveController();
            return rCtr.GetResByCusPhone(phone);
        }
    }
}
