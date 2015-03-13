using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Movie
    {
        private int id;
        private string name;
        private int playTime;

        public int getSetID
        {
            get { return id; }
            set { id = value; }
        }

        public int getSetPlayTime
        {
            get { return playTime; }
            set { playTime = value; }
        }

        public string getSetName
        {
            get { return name; }
            set { name = value; }
        }


    }
}
