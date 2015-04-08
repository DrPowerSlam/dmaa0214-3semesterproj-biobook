using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Customer
    {

        private string name;
        private int cusID;

        public Customer()
        {
            name = null;
            cusID = -1;
        }

        public Customer(string name, int cusID)
        {
            this.name = name;
            this.cusID = cusID;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return cusID; }
            set { cusID = value; }
        }

        public Customer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }


    }
}
