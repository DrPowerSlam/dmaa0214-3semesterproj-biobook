using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ServerProject.ModelLayer;

namespace ServerProject.DatabaseLayer
{
    public class DBMovie
    {
        public ModelLayer.Movie selectWhereID(int movieID)
        {
            var db = new ConnectToDBDataContext();

            var movie = db.Movies.Select(x => x).AsEnumerable().Where(x => x.MovieID.Equals(movieID));
            ModelLayer.Movie movieModel = new ModelLayer.Movie();
            movieModel.MovieID = movie.First().MovieID;
            movieModel.Name = movie.First().name;
            movieModel.PlayTime = (int)movie.First().Playtime;

            return movieModel;
        }

        public ServerProject.ModelLayer.Movie selectWhereName(string name)
        {
            var db = new ConnectToDBDataContext();

            var movie = db.Movies.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));
            ServerProject.ModelLayer.Movie movieModel = new ServerProject.ModelLayer.Movie();
            movieModel.MovieID = movie.First().MovieID;
            movieModel.Name = movie.First().name;
            movieModel.PlayTime = (int)movie.First().Playtime;

            return movieModel;
        }

        public ArrayList getAllMovies()
        {
            ArrayList movieList = new ArrayList();

            var db = new ConnectToDBDataContext();
            int movieID = 1;

            while (movieID <= db.Movies.AsEnumerable().Last().MovieID)
            {
                var movie = db.Movies.Select(x => x).AsEnumerable().Where(x => x.MovieID == movieID).Where(x => !x.name.Equals(null));
                ServerProject.ModelLayer.Movie movieModel = new ServerProject.ModelLayer.Movie();
                movieModel.MovieID = movie.First().MovieID;
                movieModel.Name = movie.First().name;
                movieModel.PlayTime = (int)movie.First().Playtime;
                movieList.Add(movieModel);
                movieID++;
            }

            return movieList;
        }
    }
}
