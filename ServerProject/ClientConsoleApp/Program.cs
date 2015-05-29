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
        ServerProject.ControllerLayer.SchedulerController schCtr = new SchedulerController();
        ServerProject.ControllerLayer.SeatController seatCtr = new SeatController();
        //CustomerServiceClient client = new CustomerServiceClient();
        
        static void Main(String[] arg)
        {            
            Program program = new Program();
            ServerProject.ControllerLayer.CustomerController cusCtr = new CustomerController();

            cusCtr.DeleteCustomer(42);

            //program.schCtr.CreateScheduler(d, t, 1, 1);

            //Console.ReadLine();
            
            
            //program.GetAllschedulers();
            //program.MakeCustomer();

            //program.GetScheduler();

           

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




        public void CreateReservationTest()
        {
            resCtr.makeReservation("2,2,2", "0,1,2", 18, 1);
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
            Console.WriteLine("Press 7: To make a Reservation\n");
            Console.WriteLine("press 8: To make a Customer\n");
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
            else if (line.Equals("7"))
            {
                MakeReservation();
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("8"))
            {
                MakeCustomer();
                Console.ReadLine();
                Console.Clear();
                startScreen();
            }
            else if (line.Equals("0"))
            {
                Environment.Exit(0);
            }

        }

        public void GetAllschedulers()
        {
            foreach (Scheduler schduler in schCtr.GetAllSchedulers())
            {
                if (schduler.MovieID == schduler.Movie.MovieID)
                {
                    Console.WriteLine(schduler.Movie.name);
                }
            }
            ReserveController resCtr = new ReserveController();
            Console.WriteLine("Write the time for how long it should take");
            int sleepTime = Console.Read();
            //resCtr.UpdateReservation("1,2,3,4", "1", 1, 1, sleepTime);
        }
        public void getAllCustomers()
        {
            foreach (Customer customer in cusCtr.GetAllCustomers())
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }
        }



        //public void getAllScheduleres()//
        //{
        //    Console.WriteLine("****************************** FIND ALL SCHEDULERS ******************************\n");

        //    SchedulerController schCtr = new SchedulerController();

        //    foreach (var s in schCtr.getMovieByMovieID(1).Cast<Scheduler>())
        //    {
        //        Console.WriteLine("Scheduler ID: " + s.Movie.name);
        //        if (s.Movie.MovieID == 1)
        //        {
        //        }

        //    }

        //    //foreach (var r in resCtr.getReservationsByCustomerID(1).Cast<Reservation>())
        //    //{
        //    //    Console.WriteLine("Movie name: " + r.Scheduler.Movie.name);
        //    //    Console.WriteLine("Customer name: " + r.Customer.name + "\n" + "Reservation ID: " + r.ResID + "\n" + "Row: " + r.Row + "\nSeat: " + r.Seat + "\n");
        //    //    if (r.Customer.CusID == 1)
        //    //    {
        //    //        Console.WriteLine(r.Scheduler.Movie.name);
        //    //        Console.WriteLine(r.Customer.name + " " + r.ResID + " " + r.Row + " " + r.Seat);
        //    //    }
        //    //}           

        //}

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
                Console.WriteLine(movie.MovieID + ": " + movie.name + ". Playtime: " + movie.Playtime + "\n" + movie.Price + "\n" + movie.Image + "\n");
            }
        }

        ///Reservation
        ///

        public void getAllReservations()
        {
            Console.WriteLine("****************************** FIND ALL RESERVATION ******************************\n");
            ReserveController resCtr = new ReserveController();

            foreach (var r in resCtr.GetReservationsByCustomerID(1).Cast<Reservation>())
            {
                Console.WriteLine("Movie name: " + r.Scheduler.Movie.name);
                Console.WriteLine("Customer name: " + r.Customer.name + "\n" + "Reservation ID: " + r.ResID + "\n" + "Row: " + r.Row + "\nSeat: " + r.Seat + "\n");
                if (r.Customer.CusID == 1)
                {
                    Console.WriteLine(r.Scheduler.Movie.name);
                    Console.WriteLine(r.Customer.name + " " + r.ResID + " " + r.Row + " " + r.Seat);
                }
            }

        }


        public void MakeReservation()
        {
            Console.WriteLine("****************************** MAKE A RESERVATION ******************************\n");

            ReserveController resController = new ReserveController();


            //Change this so it works with the algorithm..
            //It must go through the algorithm first to check if the seats available (you can not reserve before you have run through the algorithm
            //and update the seat tabel in the database.

            bool successful = resController.makeReservation("1,2,3,4", "1", 1, 1);
        }



        /*
         * 
         * Customer
         * 
         * 
         * */

        public void MakeCustomer()
        {
            //Make sure that promt the user to do it
           // client.MakeCustomer("writeyournamehere", "+459999999", "kodener123", "Hej@gmail.com");
            Console.WriteLine("done making customer.");
        }

    }
}

