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

        /// <summary>
        /// Get all halls
        /// </summary>
        /// <returns>Return a list of halls</returns>
        public IEnumerable GetAllHalls()
        {
            return dbHall.GetAllHalls();
        }

        /// <summary>
        /// Find a hall by it's ID
        /// </summary>
        /// <param name="ID">The ID of the hall you want to find</param>
        /// <returns>Returns a hall object</returns>
        public Hall FindHallByID(int ID)
        {
            return dbHall.GetByHallID(ID);
        }


        /// <summary>
        /// Find a hall by it's name
        /// </summary>
        /// <param name="name">The name of the hall you want to find</param>
        /// <returns>Returns a list of halls, in case there's more than one with the same name</returns>
        public IEnumerable FindHallByName(string name)
        {
            return dbHall.GetHallByName(name);
        }
    }
}
