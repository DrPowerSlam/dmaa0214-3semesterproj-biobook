using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Customer
    {

        private string Name;
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        private int ID;
        public int GetID
        {
            get { return ID; }
            set { ID = value; }
        }

        public Customer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }


    }
}
