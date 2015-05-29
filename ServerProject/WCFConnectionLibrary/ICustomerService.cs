using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerProject.DatabaseLayer;
using System.Collections;

namespace WCFConnectionLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        Customer GetCustomerByEmail(string username);


        [OperationContract]
        List<Seat> GetAllSeatsBySchedulerID(int schedulerID);

        [OperationContract]
        int[] GetBestSeats(int amount, int schedulerID);

        [OperationContract]
        List<Movie> GetAllMovies();

        [OperationContract]
        List<Reservation> GetReservationByCustomerID(int customerID);

        [OperationContract]
        List<Scheduler> GetAllSchedulers();

        [OperationContract]
        Scheduler GetSchedulerByMovieID(int movieID);

        [OperationContract]
        Scheduler GetSchedulerByID(int schedulerID);

        [OperationContract]
        void MakeReservation(string row, string seat, int schedulerID, int customerID);

        [OperationContract]
        void MakeCustomer(string name, string phoneNumber, string password, string mail);

        [OperationContract]
        Customer GetCustomerByID(int customerID);

        [OperationContract]
        bool CustomerLogin(string userMail, string passWord);

        [OperationContract]
        void MakeScheduler(DateTime date, TimeSpan time, int movieID, int hallID);

        [OperationContract]
        Movie FindMovieByName(string name);

        [OperationContract]
        List<Scheduler> GetSchedulerListByMovieID(int movieID);

        [OperationContract]
        int[][] GetAllAvailableSeats(int schID);

        [OperationContract]
        Customer GetCustomerByPhone(string phone);

        [OperationContract]
        List<Reservation> GetResByCusPhone(string phone);

        [OperationContract]
        void DeleteCustomer(int id);

        [OperationContract]
        List<Scheduler> GetSchListByDate(DateTime date);

        [OperationContract]
        void UpdateScheduler(int schID, DateTime date, TimeSpan time, int movieID, int hallID);
    }
}
