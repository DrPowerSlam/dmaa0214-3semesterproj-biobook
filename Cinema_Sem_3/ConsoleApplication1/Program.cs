using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProject.ControllerLayer;
using ServerProject.ModelLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] arg)
        {
            Program program = new Program();

            program.GetScheduler();

            //program.getHall();
        }

        public void GetScheduler()
        {
            CustomerController cusCtr = new CustomerController();
            MovieController movCtr = new MovieController();
            ServerProject.DatabaseLayer.DBScheduler schCtr = new ServerProject.DatabaseLayer.DBScheduler();

            Console.WriteLine("ID:" + schCtr.GetScheduler(1).SchID + "\nHall ID: " + schCtr.GetScheduler(1).HallID + "\nDate: " + schCtr.GetScheduler(1).Datetime);

            Console.WriteLine("WELCOME TO THE TEST APP \n");

            foreach (ServerProject.DatabaseLayer.Customer customer in cusCtr.getAllCustomers())
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }

            Console.WriteLine("****************************** FIND CUSTOMER BY ID ******************************\n");

            Console.WriteLine(cusCtr.findCustomerByID(4).ID + ": " + cusCtr.findCustomerByID(4).Name + "\n");

            Console.WriteLine("****************************** FIND CUSTOMERS WITH NAME ******************************\n");

            foreach (Customer customer in cusCtr.findCustomersByName("Jens"))
            {
                Console.WriteLine(customer.ID + ": " + customer.Name + "\n");
            }

            Console.WriteLine("****************************** FIND MOVIE BY NAME ******************************\n");

            Console.WriteLine(movCtr.findMovieByName("Super-Man").MovieID + ": " + movCtr.findMovieByName("Super-Man").Name + ". Playtime: " + movCtr.findMovieByName("Super-Man").PlayTime + "\n");

            Console.WriteLine("****************************** FIND MOVIE BY ID ******************************\n");

            Console.WriteLine(movCtr.findMovieByID(3).MovieID + ": " + movCtr.findMovieByID(3).Name + ". Playtime: " + movCtr.findMovieByID(3).PlayTime + "\n");

            Console.WriteLine("****************************** FIND ALL MOVIES ******************************\n");


            foreach (Movie movie in movCtr.getAllMovies())
            {
                Console.WriteLine(movie.MovieID + ": " + movie.Name + ". Playtime: " + movie.PlayTime + "\n");
            }

            Console.ReadLine();

        }

        public void getHall()
        {
            Console.WriteLine("WELCOME TO THE TEST APP \n");
        }

    }
}

