using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance; //Pattern Singleton
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * From getAllBill()";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
