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

        // Select hall by  id
        public Hall selectWhereID(int hallID)
        {
            var db = new ConnectToDatabaseDataContext();

            Hall hall = db.Halls.Single(x => x.HallID == hallID);

            return hall;
        }



        // Select * halls

        public IEnumerable selectWhereName(string name)
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDatabaseDataContext();

            var hall = db.Halls.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));

            return hall;
        }

        public IEnumerable getAllHalls()
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDatabaseDataContext();

            var hall = db.Halls.Select(x => x).AsEnumerable();

            return hall;
        }

    }


}
