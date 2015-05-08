using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ServerProject.DatabaseLayer
{
    class DBHall
    {
        //string cnStr = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString; // Concencting string

        /// <summary>
        /// Gets a hall by it's ID
        /// </summary>
        /// <param name="hallID">The ID of the hall</param>
        /// <returns>Returns a hall of type hall object</returns>
        public Hall GetByHallID(int hallID)
        {
            var db = new ConnectToDatabaseDataContext();

            Hall hall = db.Halls.Single(x => x.HallID == hallID);

            return hall;
        }



       /// <summary>
       /// Gets all halls with a given name (in case some have the same name)
       /// </summary>
       /// <param name="name">Name of the hall</param>
       /// <returns>Returns an IEnumerable with all the halls with the name</returns>
        public IEnumerable GetHallByName(string name)
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDatabaseDataContext();

            var hall = db.Halls.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));

            return hall;
        }

        /// <summary>
        /// Gets all halls
        /// </summary>
        /// <returns>An IEnumerable with all halls</returns>
        public IEnumerable GetAllHalls()
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDatabaseDataContext();

            var hall = db.Halls.Select(x => x).AsEnumerable();

            return hall;
        }

    }
}