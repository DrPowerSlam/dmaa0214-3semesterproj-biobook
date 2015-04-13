using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ServerProject.ModelLayer;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ServerProject.DatabaseLayer
{
    class DBHall
    {
        string cnStr = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString; // Concencting string

        // Select hall by  id
        public Hall selectWhereID(int hallID)
        {
            var db = new ConnectToDBDataContext();

            var hall = db.Halls.Select(x => x).AsEnumerable().Where(x => x.HallID == hallID);

            return hall.First<Hall>();
        }



        // Select * halls

        public ArrayList selectWhereName(string name)
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDBDataContext();
            int hallID = 1;

            while (hallID < db.Halls.AsEnumerable().Last().HallID)
            {
                var hall = db.Halls.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));
                hallList.Add(hall.First<Hall>());
                hallID++;
            }

            return hallList;
        }

        public ArrayList getAllHalls()
        {
            ArrayList hallList = new ArrayList();

            var db = new ConnectToDBDataContext();
            int hallID = 1;

            while (hallID < db.Halls.AsEnumerable().Last().HallID)
            {
                var hall = db.Halls.Select(x => x).AsEnumerable().Where(x => x.HallID == hallID);
                hallList.Add(hall.First<Hall>());
                hallID++;
            }

            return hallList;
        }

    }


}
