using Dashboard.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance; //Pattern Singleton
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * From getAllCustomer()";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getByKeyword(string key)
        {
            DataTable dt = new DataTable();
            string query = "Select * From getCustomerByKeyword( @keyword )";
            object[] paramenters = new object[] { key };
            dt = DataProvider.Instance.ExecuteQuery(query, paramenters);
            return dt;
        }
        public void insert(CustomerDTO customer)
        {
            string query = "Exec insertCustomer @nameCustomer , @Caddress , @phoneNumber";
            object[] paramenters = new object[] { customer.name, customer.address, customer.phone };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public void update(CustomerDTO customer)
        {
            string query = "Exec updateCustomer @name , @Caddres , @phone ";
            object[] paramenters = new object[] { customer.name,customer.address,customer.phone };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
    }
}
