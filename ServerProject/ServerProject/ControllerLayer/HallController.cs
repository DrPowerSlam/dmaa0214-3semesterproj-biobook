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
        public IEnumerable GetAllHalls()
        {
            return dbHall.GetAllHalls();
        }

        // Gets hall by ID
        public Hall FindHallByID(int ID)
        {
            return dbHall.GetByHallID(ID);
        }


        // Gets hall by name
        public IEnumerable FindHallByName(string name)
        {
            return dbHall.GetHallByName(name);
        }
    }
}
