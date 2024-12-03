using Dashboard.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance; //Pattern Singleton
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getAll()
        {
            string query = "select * from getAll()";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public string checkCustomer(string phoneNo) {
            string name = null;
            if(phoneNo != null)
            {
                string query = "SELECT dbo.checkCustomerFunc ( @soDienThoai )";
                object[] parameters = new object[] { phoneNo };
                name = DataProvider.Instance.ExecuteScalar(query, parameters).ToString();
            }
            return name;
        }

        public float checkVoucher(string voucherCode)
        {
            float discount = -1;
            if (voucherCode != null)
            {
                string query = "SELECT dbo.checkVoucher ( @voucherCode )";
                object[] parameters = new object[] { voucherCode };
                discount = float.Parse(DataProvider.Instance.ExecuteScalar(query, parameters).ToString());
            }
            return discount;
        }

        public void insert(BillDTO bill, List<OrderDTO> orders) {
            DateTime now = DateTime.Now;
            string id = "T" + now.Day.ToString() + now.Year.ToString() + now.Month.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + now.Millisecond.ToString();
            string query = "EXEC insertBill @id , @idEmployee , @phoneNo ";
            object[] paramenters = new object[] {id, 1, bill.getPhoneNumber()};
            DataProvider.Instance.ExecuteQuery(query, paramenters);
            foreach(OrderDTO order in orders)
            {
                insertOrder(order,id);
            }
        }
        public DataTable searchByKeyword(string key)
        {
            DataTable dt = new DataTable();
            string query = "Select* from getMenuByKeyword( @keyword )";
            object[] paramenters = new object[] {key};
            dt = DataProvider.Instance.ExecuteQuery(query, paramenters);
            return dt;
        }
        public void insertOrder(OrderDTO order, string billID)
        {
            string query = "EXEC insertOrder @idBill , @idMenu , @number ";
            object[] paramenters = new object[] {billID,order.getIdMenu(),order.getNumber()};
            DataProvider.Instance.ExecuteQuery(query,paramenters);
        }

        public void insertNewItem(MenuDTO menu)
        {
            string query = "EXEC insertMenu @nameMenu , @price , @imageURL ";
            object[] paramenters = new object[] { menu.Nname, menu.Price, menu.Image };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public void updateOldItem(MenuDTO menu)
        {
            string query = "EXEC updateMenu @id , @nameMenu , @price , @imageURL ";
            object[] paramenters = new object[] { menu.Id,menu.Nname, menu.Price, menu.Image };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public DataTable getIngredientsMenu(int menuid)
        {
            string query = "Select * from getIngredientsByMenuID( @idMenu ) ";
            object[] paramenters = new object[] { menuid };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, paramenters);
            return dt;
        }
        public void deleteIngredentsMenu(int memuid, int ingredientid)
        {
            string query = "EXEC deleteIngredentsMenu @idMenu , @idIngredient ";
            object[] paramenters = new object[] { memuid, ingredientid };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public void insertIngredientsMenu(int memuid, int ingredientid, int number)
        {
            string query = "EXEC insertIngredientsMenu @idIngredient , @idMenu , @number";
            object[] paramenters = new object[] {  ingredientid , memuid, number};
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
    }
}
