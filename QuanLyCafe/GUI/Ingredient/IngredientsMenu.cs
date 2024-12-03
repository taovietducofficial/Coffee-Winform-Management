using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.Ingredient
{
    public partial class IngredientsMenu : Form
    {
        private MenuDTO menu = new MenuDTO(-1, "Sản phẩm không hợp lệ", -1, null);
        DataTable dt;
        public IngredientsMenu(MenuDTO menu)
        {
            InitializeComponent();
            this.menu = menu;
            dgvIngredients.AutoGenerateColumns = false;
        }

        private void IngredientsMenu_Load(object sender, EventArgs e)
        {
            price.Text = menu.Price.ToString();
            name.Text = menu.Nname.ToString();

            loadDgv();

            cbIng.DataSource = IngredientsDAO.Instance.getAll();
            cbIng.DisplayMember = "ten";
            cbIng.ValueMember = "id";
        }
        private void loadDgv()
        {
            dt = MenuDAO.Instance.getIngredientsMenu(menu.Id);
            dgvIngredients.DataSource = dt;
        }
        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvIngredients.Columns["delete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvIngredients.Rows[e.RowIndex];
                int id = Int32.Parse(dgvIngredients.Rows[e.RowIndex].Cells["idIng"].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xoá nguyên liệu " + row.Cells[1].Value + " chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MenuDAO.Instance.deleteIngredentsMenu(menu.Id, id);
                    dgvIngredients.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MenuDAO.Instance.insertIngredientsMenu(menu.Id, Int32.Parse(cbIng.SelectedValue.ToString()), Int32.Parse(txtNumber.Text));
                MessageBox.Show("Thêm thành công!");
                loadDgv();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
