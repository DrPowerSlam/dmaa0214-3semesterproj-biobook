using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/HallController.cs
=======
using ServerProject.DatabaseLayer;
using System.Collections;

>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/HallController.cs

namespace ServerProject.ControllerLayer
{
    class HallController
    {
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/HallController.cs
=======
        DBHall dbHall = new DBHall();

        //Get all halls
        public ArrayList getAllHalls()
        {
            return dbHall.getAllHalls();
        }

        // Gets hall by ID
        public Hall findHallByID(int ID)
        {
            return dbHall.selectWhereID(ID);
        }


        // Gets hall by name
        public ArrayList findHallByName(string name)
        {
            return dbHall.selectWhereName(name);
        }
>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/HallController.cs
    }
}
