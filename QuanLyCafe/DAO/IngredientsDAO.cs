using Dashboard.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class IngredientsDAO
    {
        private static IngredientsDAO instance; //Pattern Singleton
        public static IngredientsDAO Instance
        {
            get { if (instance == null) instance = new IngredientsDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable getAll()
        {
            string query = "Select * from getAllIngredient()";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable getByKey(string key)
        {
            string query = "Select * from getIngredientByKeyword( @keyword )";
            object[] paramenters = new object[] { key };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,paramenters);
            return dt;
        }
        public void insert(IngredientsDTO ingredients)
        {
            string query = "Exec insertIngredient @Iname , @price , @number";
            object[] paramenters = new object[] { ingredients.name, ingredients.price, 0 };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public void update(IngredientsDTO ingredients)
        {
                string query = "Exec updateIngredient @id , @name , @price , @number ";
            object[] paramenters = new object[] { ingredients.id , ingredients.name, ingredients.number };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
        public int createImport(int employeeID)
        {
            string query = "Exec insertImport @idEmployee ";
            object[] paramenters = new object[] { employeeID };
            int id = Int32.Parse(DataProvider.Instance.ExecuteScalar(query, paramenters).ToString());
            return id;
        }
        public void createImportedIngredient(ImportedIngredientDTO importedIngredient)
        {
            string query = "Exec insertImportedIngredients @idIngredient , @idImport , @number ";
            object[] paramenters = new object[] { importedIngredient.idIngredient , importedIngredient.idImport ,importedIngredient.number };
            DataProvider.Instance.ExecuteQuery(query, paramenters);
        }
    }
}
