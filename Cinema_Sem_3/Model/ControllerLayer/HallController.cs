using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;
using System.Collections;


namespace ServerProject.ControllerLayer
{
    
    public class HallController
    {
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
    }
}
