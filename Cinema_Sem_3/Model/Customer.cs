using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Customer
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Customer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }


    }
}
