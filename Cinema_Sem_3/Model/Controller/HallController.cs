using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Database;
using System.Collections;
using Model;


namespace Model.Controller
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
        public Hall findHallByID(string ID)
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
