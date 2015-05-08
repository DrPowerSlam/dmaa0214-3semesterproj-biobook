using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace ServerProject.DatabaseLayer
{
    class DBMethods
    {
        /// <summary>
        /// A method to reset the database with an SQL script
        /// </summary>
        public void ResetDatabase()
        {
            var db = new ConnectToDatabaseDataContext();

            FileInfo file = new FileInfo("SQLscriptCinema.sql");

            string script = file.OpenText().ReadToEnd();

            db.ExecuteCommand(script);
        }
    }
}
