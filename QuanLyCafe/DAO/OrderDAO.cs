 using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance; //Pattern Singleton
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getByID(string id)
        {
            DataTable dt = new DataTable();
            string query = "Select * From getOrderByBillID( @billID )";
            object[] paramenters = new object[] { id };
            dt = DataProvider.Instance.ExecuteQuery(query,paramenters);
            return dt;
        }
    }
}
