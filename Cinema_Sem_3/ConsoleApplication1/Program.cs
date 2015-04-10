using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleApplication1
{ 
    class Program
    {
        static void Main(String[] arg)
        {
            Model.Controller.CustomerController cusCtr = new Model.Controller.CustomerController();
            Console.WriteLine("WELCOME TO THE TEST APP \n");

            foreach(Customer customer in cusCtr.getAllCustomers())
            {
                Console.WriteLine(customer.ID + ": " + customer.Name + "\n");
            }

            Console.WriteLine("****************************** FIND CUSTOMER BY ID ******************************\n");

            Console.WriteLine(cusCtr.findCustomerByID("4").ID + ": " + cusCtr.findCustomerByID("4").Name + "\n");

            Console.WriteLine("****************************** FIND CUSTOMERS WITH NAME ******************************\n");

            foreach(Customer customer in cusCtr.findCustomersByName("Jens"))
            {
                Console.WriteLine(customer.ID + ": " + customer.Name + "\n");
            }

            Console.ReadLine();
        }
        
    }
}

