﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsoleApp.CustomerServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceReference.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAllSchedulers", ReplyAction="http://tempuri.org/ICustomerService/GetAllSchedulersResponse")]
        ServerProject.DatabaseLayer.Scheduler[] GetAllSchedulers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAllSchedulers", ReplyAction="http://tempuri.org/ICustomerService/GetAllSchedulersResponse")]
        System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler[]> GetAllSchedulersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetSchedulerByMovie", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerByMovieResponse")]
        ServerProject.DatabaseLayer.Scheduler GetSchedulerByMovie(int movieID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetSchedulerByMovie", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerByMovieResponse")]
        System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerByMovieAsync(int movieID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetSchedulerByID", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerByIDResponse")]
        ServerProject.DatabaseLayer.Scheduler GetSchedulerByID(int schedulerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetSchedulerByID", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerByIDResponse")]
        System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerByIDAsync(int schedulerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/MakeReservation", ReplyAction="http://tempuri.org/ICustomerService/MakeReservationResponse")]
        void MakeReservation(string row, string seat, int schedulerID, int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/MakeReservation", ReplyAction="http://tempuri.org/ICustomerService/MakeReservationResponse")]
        System.Threading.Tasks.Task MakeReservationAsync(string row, string seat, int schedulerID, int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/MakeCustomer", ReplyAction="http://tempuri.org/ICustomerService/MakeCustomerResponse")]
        void MakeCustomer(string name, string phoneNumber, string password, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/MakeCustomer", ReplyAction="http://tempuri.org/ICustomerService/MakeCustomerResponse")]
        System.Threading.Tasks.Task MakeCustomerAsync(string name, string phoneNumber, string password, string mail);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : ClientConsoleApp.CustomerServiceReference.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<ClientConsoleApp.CustomerServiceReference.ICustomerService>, ClientConsoleApp.CustomerServiceReference.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServerProject.DatabaseLayer.Scheduler[] GetAllSchedulers() {
            return base.Channel.GetAllSchedulers();
        }
        
        public System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler[]> GetAllSchedulersAsync() {
            return base.Channel.GetAllSchedulersAsync();
        }
        
        public ServerProject.DatabaseLayer.Scheduler GetSchedulerByMovie(int movieID) {
            return base.Channel.GetSchedulerByMovie(movieID);
        }
        
        public System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerByMovieAsync(int movieID) {
            return base.Channel.GetSchedulerByMovieAsync(movieID);
        }
        
        public ServerProject.DatabaseLayer.Scheduler GetSchedulerByID(int schedulerID) {
            return base.Channel.GetSchedulerByID(schedulerID);
        }
        
        public System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerByIDAsync(int schedulerID) {
            return base.Channel.GetSchedulerByIDAsync(schedulerID);
        }
        
        public void MakeReservation(string row, string seat, int schedulerID, int customerID) {
            base.Channel.MakeReservation(row, seat, schedulerID, customerID);
        }
        
        public System.Threading.Tasks.Task MakeReservationAsync(string row, string seat, int schedulerID, int customerID) {
            return base.Channel.MakeReservationAsync(row, seat, schedulerID, customerID);
        }
        
        public void MakeCustomer(string name, string phoneNumber, string password, string mail) {
            base.Channel.MakeCustomer(name, phoneNumber, password, mail);
        }
        
        public System.Threading.Tasks.Task MakeCustomerAsync(string name, string phoneNumber, string password, string mail) {
            return base.Channel.MakeCustomerAsync(name, phoneNumber, password, mail);
        }
    }
}
