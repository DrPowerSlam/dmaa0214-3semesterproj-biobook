using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.TUI
{
    class MainWindow
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("WELCOME TO THE TEST APP \n");

            Model.Controller.CustomerController cusCtr = new Controller.CustomerController();

            foreach(Customer customer in cusCtr.getAllCustomers())
            {
                Console.WriteLine(customer.ID + " " + customer.Name);
            }
            Console.ReadLine();
        }
        
    }
}
