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
    public class EmployeeDAO
    {
        private static EmployeeDAO instance; //Pattern Singleton
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * From getAllEmployee()";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getByKeyword(string key)
        {
            DataTable dt = new DataTable();
            string query = "Select * From getEmloyeeByKeyword( @keyword )";
            object[] paramenters = new object[] { key };
            dt = DataProvider.Instance.ExecuteQuery(query,paramenters);
            return dt;
        }
        public void insert(EmployeeDTO employee)
        {
            string query = "Exec insertEmployee @Ename , @dateOfBirth , @gender , @Eaddress , " +
            "@phoneNumber";
            object[] paramenters = new object[] { employee.ten, employee.dob, employee.gioiTinh, employee.diaChi ,employee.phone};
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public void update(EmployeeDTO employee) {
            string query = "Exec updateEmployee @idEmployee , @Ename , @dateOfBirth , @gender , @Eaddress , " +
                "@phoneNumber";
            object[] paramenters = new object[] { employee.Id , employee.ten, employee.dob, employee.gioiTinh, employee.diaChi, employee.phone };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
    }
}
