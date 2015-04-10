using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Model
{
    class DBCustomer
    {
        public DBCustomer()
        { 
        }

        public String cnStr = "Data Source=kraka.ucn.dk;Initial Catalog=dmaa0214_3Sem_2;Persist Security Info=True;User ID=dmaa0214_3sem_2;Password=IsAllowed";

        public Customer selectWhereID(string customerID)
        {
            Customer customer = new Customer();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Customer";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            if(customerID.Equals(myDataReader["CusID"].ToString()))
                            {
                                customer.ID = (int)myDataReader["CusID"];
                                customer.Name = myDataReader["name"].ToString();
                            }
                        }
                    }
                }
                cn.Close();
            }
            return customer;
        }

        public ArrayList selectWhereName(string name)
        {
            ArrayList customerList = new ArrayList();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Customer";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            if (name.Equals(myDataReader["name"].ToString()))
                            {
                                Customer customer = new Customer();
                                customer.ID = (int)myDataReader["CusID"];
                                customer.Name = myDataReader["name"].ToString();
                                customerList.Add(customer);
                            }
                        }
                    }
                }
                cn.Close();
            }
            return customerList;
        }

        public ArrayList getAllCustomers()
        {
            ArrayList customerList = new ArrayList();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();


                string strSQL = "Select * from Customer";

                using (SqlCommand myCommand = new SqlCommand(strSQL, cn))
                {
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                                Customer customer = new Customer();
                                customer.ID = (int)myDataReader["CusID"];
                                customer.Name = myDataReader["name"].ToString();
                                customerList.Add(customer);
                        }
                    }
                }
                cn.Close();
            }
            return customerList;
        }
    }
      
}
