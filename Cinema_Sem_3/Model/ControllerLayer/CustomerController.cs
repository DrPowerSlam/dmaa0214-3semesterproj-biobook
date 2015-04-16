using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/CustomerController.cs
=======
using ServerProject.DatabaseLayer;
using System.Collections;
>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/CustomerController.cs

namespace ServerProject.ControllerLayer
{
    class CustomerController
    {
<<<<<<< HEAD:Cinema_Sem_3/Model/Controller/CustomerController.cs
=======
        DBCustomer dbCus = new DBCustomer();

        public IEnumerable getAllCustomers()
        {
            return dbCus.getAllCustomers();
        }

        public ServerProject.ModelLayer.Customer findCustomerByID(int ID)
        {
            return dbCus.selectWhereID(ID);
        }

        public ArrayList findCustomersByName(string name)
        {
            ArrayList customerList = new ArrayList();
            foreach (Customer c in dbCus.selectWhereName(name))
            {
                if (c.name == name)
                {
                    ServerProject.ModelLayer.Customer customerModel = new ServerProject.ModelLayer.Customer();
                    customerModel.CusID = c.CusID;
                    customerModel.Name = c.name;
                    customerList.Add(customerModel);
                }
            }
            return customerList;
        }
>>>>>>> 02dd249414c384d58cfbf064a1f5ff2d094c055d:Cinema_Sem_3/Model/ControllerLayer/CustomerController.cs
    }
}
