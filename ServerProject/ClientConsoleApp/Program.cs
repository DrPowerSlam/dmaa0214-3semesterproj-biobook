using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;
using ClientConsoleApp.CustomerServiceReference;

namespace ConsoleApplication1
{
    class Program
    {
        ServerProject.ControllerLayer.CustomerController cusCtr = new CustomerController();
        ServerProject.ControllerLayer.MovieController movCtr = new MovieController();
        ServerProject.ControllerLayer.ReserveController resCtr = new ReserveController();
        ServerProject.DatabaseLayer.DBScheduler schCtr = new ServerProject.DatabaseLayer.DBScheduler();
        

        static void Main(String[] arg)
        {
            Program program = new Program();

            program.getAllReservations();
           

            //program.GetScheduler();

        //    var client = new CustomerServiceClient();

            //Scheduler scheduler = client.getSchedulerByMovie(1);
           // Scheduler scheduler = client.getSchedulerByID(1);

            //somehow this does not work. I want to get the movie from the scheduler that is referenced by the foreign key in the database?
            //Movie movie = scheduler.Movie;
            //Use only the ones that are from the database. The one that are in the class gives an nullpointerexception
            //Console.WriteLine(scheduler.Movie.name);
            //Console.WriteLine(program.movCtr.findMovieByID(1).name);
           // Console.WriteLine(scheduler.MovieID);
            
            Console.ReadLine();



           
        }

        


        public void GetScheduler()
        {
            startScreen();
        }

        public void startScreen()
        {
            string line;
            string methodLine;

            Console.WriteLine("WELCOME TO THE TEST APP \n");
            Console.WriteLine("Press 1: See all customers\n");
            Console.WriteLine("Press 2: Find a customer by ID\n");
            Console.WriteLine("Press 3: Find all customers with a given name\n");
            Console.WriteLine("Press 4: Find a movie by name\n");
            Console.WriteLine("Press 5: Find a movie by ID\n");
            Console.WriteLine("Press 6: See all movies\n");
            Console.WriteLine("Press 0: Close the application\n");
            line = Console.ReadLine();
            if (line.Equals("1"))
            {
                getAllCustomers();
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("2"))
            {
                Console.WriteLine("Type the ID of the customer you want to find\n");
                methodLine = Console.ReadLine();
                findCustomerByID(int.Parse(methodLine));
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("3"))
            {
                Console.WriteLine("Type the Name of the customer you want to find\n");
                methodLine = Console.ReadLine();
                findCustomerByName(methodLine);
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("4"))
            {
                Console.WriteLine("Type the name of the movie you want to find\n");
                methodLine = Console.ReadLine();
                findMovieByName(methodLine);
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("5"))
            {
                Console.WriteLine("Type the ID of the movie you want to find\n");
                methodLine = Console.ReadLine();
                findMovieByID(int.Parse(methodLine));
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("6"))
            {
                getAllMovies();
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("0"))
            {
                Environment.Exit(0);
            }
        }
        public void getAllCustomers()
        {
            foreach (Customer customer in cusCtr.GetAllCustomers())
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }
        }

        //public void GetScheduler()
        //{
        //    Console.WriteLine("ID:" + schCtr.GetScheduler(1).SchID + "\nHall ID: " + schCtr.GetScheduler(1).HallID + "\nDate: " + schCtr.GetScheduler(1).Datetime);
        //}

        

        public void findCustomerByID(int ID)
        {
            Console.WriteLine("****************************** FIND CUSTOMER BY ID ******************************\n");

            Console.WriteLine(cusCtr.GetCustomerByID(ID).CusID + ": " + cusCtr.GetCustomerByID(ID).name + "\n");
        }

        public void findCustomerByName(string name)
        {
            Console.WriteLine("****************************** FIND CUSTOMERS WITH NAME ******************************\n");

            foreach (Customer customer in cusCtr.FindCustomerByName(name))
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }
        }

        public void findMovieByName(string name)
        {
            Console.WriteLine("****************************** FIND MOVIE BY NAME ******************************\n");

            Console.WriteLine(movCtr.FindMovieByName(name).MovieID + ": " + movCtr.FindMovieByName(name).name + ". Playtime: " + movCtr.FindMovieByName(name).Playtime + "\n");
        }

        public void findMovieByID(int ID)
        {
            Console.WriteLine("****************************** FIND MOVIE BY ID ******************************\n");

            Console.WriteLine(movCtr.FindMovieByID(ID).MovieID + ": " + movCtr.FindMovieByID(ID).name + ". Playtime: " + movCtr.FindMovieByID(ID).Playtime + "\n");
        }

        public void getAllMovies()
        {
            Console.WriteLine("****************************** FIND ALL MOVIES ******************************\n");


            foreach (Movie movie in movCtr.GetAllMovies())
            {
                Console.WriteLine(movie.MovieID + ": " + movie.name + ". Playtime: " + movie.Playtime + "\n");
            }
        }







        ///Reservation
        ///

        public void getAllReservations()
        {
            Console.WriteLine("****************************** FIND ALL RESERVATION ******************************\n");
            ReserveController resCtr = new ReserveController();

            foreach(var r in resCtr.getReservationsByCustomerID(4).Cast<Reservation>())
            {
                Console.WriteLine("Movie name: " + r.Scheduler.Movie.name);
                Console.WriteLine("Customer name: " + r.Customer.name + "\n" + "Reservation ID: " + r.ResID + "\n" + "Row: " + r.Row + "\nSeat: " + r.Seat + "\n");
                if (r.Customer.CusID == 4)
                {
                    Console.WriteLine(r.Scheduler.Movie.name);
                    Console.WriteLine(r.Customer.name + " " + r.ResID + " " + r.Row + " " + r.Seat);
                }
            }           
        }
    }
}

