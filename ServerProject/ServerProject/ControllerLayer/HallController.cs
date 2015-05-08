using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;
using System.Collections;
namespace ServerProject.ControllerLayer
{
    class HallController
    {
        DBHall dbHall = new DBHall();

        //Get all halls
        public IEnumerable getAllHalls()
        {
            return dbHall.getAllHalls();
        }

        // Gets hall by ID
        public Hall findHallByID(int ID)
        {
            return dbHall.selectWhereID(ID);
        }


        // Gets hall by name
        public IEnumerable findHallByName(string name)
        {
            return dbHall.selectWhereName(name);
        }
    }
}
