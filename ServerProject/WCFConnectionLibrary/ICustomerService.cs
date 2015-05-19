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
        Scheduler[] GetAllSchedulers();

        [OperationContract]
        Scheduler getSchedulerByMovie(int movieID);
        
        [OperationContract]
        Scheduler getSchedulerByID(int schedulerID);

        [OperationContract]
        void makeReservation(string row, string seat, int schedulerID, int customerID);

        
    }
}
