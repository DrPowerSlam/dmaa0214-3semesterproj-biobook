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
            Model.Controller.MovieController movCtr = new Model.Controller.MovieController();
            Model.Database.DBScheduler schCtr = new Model.Database.DBScheduler();

            Console.WriteLine("ID:" + schCtr.GetScheduler(1).SchID + "\nHall ID: " + schCtr.GetScheduler(1).HallID + "\nDate: " + schCtr.GetScheduler(1).Datetime);

            Console.WriteLine("WELCOME TO THE TEST APP \n");

            foreach (Customer customer in cusCtr.getAllCustomers())
            {
                Console.WriteLine(customer.ID + ": " + customer.Name + "\n");
            }

            Console.WriteLine("****************************** FIND CUSTOMER BY ID ******************************\n");

            Console.WriteLine(cusCtr.findCustomerByID("4").ID + ": " + cusCtr.findCustomerByID("4").Name + "\n");

            Console.WriteLine("****************************** FIND CUSTOMERS WITH NAME ******************************\n");

            foreach (Customer customer in cusCtr.findCustomersByName("Jens"))
            {
                Console.WriteLine(customer.ID + ": " + customer.Name + "\n");
            }

            Console.WriteLine("****************************** FIND MOVIE BY NAME ******************************\n");

            Console.WriteLine(movCtr.findMovieByName("Super-Man").MovieID + ": " + movCtr.findMovieByName("Super-Man").Name + ". Playtime: " + movCtr.findMovieByName("Super-Man").PlayTime + "\n");

            Console.WriteLine("****************************** FIND MOVIE BY ID ******************************\n");

            Console.WriteLine(movCtr.findMovieByID("3").MovieID + ": " + movCtr.findMovieByID("3").Name + ". Playtime: " + movCtr.findMovieByID("3").PlayTime + "\n");

            Console.WriteLine("****************************** FIND ALL MOVIES ******************************\n");


            foreach (Movie movie in movCtr.getAllMovies())
            {
                Console.WriteLine(movie.MovieID + ": " + movie.Name + ". Playtime: " + movie.PlayTime + "\n");
            }

            Console.ReadLine();
        }
        
    }
}

