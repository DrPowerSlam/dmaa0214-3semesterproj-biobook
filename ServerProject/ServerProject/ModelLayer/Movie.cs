using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.ModelLayer
{
    class Movie
    {
        private int movieID;
        private string name;
        private int playTime;

        public Movie(int movieID, string name, int playTime)
        {
            this.movieID = movieID;
            this.name = name;
            this.playTime = playTime;
        }

        public int MovieID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public int PlayTime
        {
            get { return playTime; }
            set { playTime = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
