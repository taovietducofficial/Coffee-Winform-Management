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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCafe.GUI
{
    public partial class NguyenLieu : UserControl
    {
        private DataTable dt = new DataTable();
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            dt = IngredientsDAO.Instance.getAll();
            dgvIngredient.DataSource = dt;
        }

        private void dgvIngredient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvIngredient.Rows[e.RowIndex];
            txtId.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["ten"].Value.ToString();
            txtPrice.Text = row.Cells["gia"].Value.ToString();

        }

        private void btnResetInput_Click(object sender, EventArgs e)
        {
            txtId.ResetText();
            txtName.ResetText();
            txtPrice.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IngredientsDTO ingredients = new IngredientsDTO(0, txtName.Text, float.Parse(txtPrice.Text), 0);
                IngredientsDAO.Instance.insert(ingredients);
                MessageBox.Show("Thêm thành công!");
                NguyenLieu_Load(null, null);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                IngredientsDTO ingredients = new IngredientsDTO(Int32.Parse(txtId.Text), txtName.Text, float.Parse(txtPrice.Text), -1);
                IngredientsDAO.Instance.update(ingredients);
                MessageBox.Show("Chỉnh sửa thành công!");
                NguyenLieu_Load(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(!pnImport.Visible)
            {
                pnImport.Visible = true;
            }
        }

        private void btnImportDone_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeID = Int32.Parse(txtEmployeeID.Text);
                int index = IngredientsDAO.Instance.createImport(employeeID);
                foreach (DataGridViewRow dr in dgvImport.Rows)
                {
                    if (!dr.IsNewRow)
                    {
                        int id = Convert.ToInt32(dr.Cells["idIng"].Value.ToString());
                        int number = Convert.ToInt32(dr.Cells["number"].Value.ToString());
                        ImportedIngredientDTO imported = new ImportedIngredientDTO(index, id, number);
                        IngredientsDAO.Instance.createImportedIngredient(imported);
                        NguyenLieu_Load(null, null);
                    }
                }
                MessageBox.Show("Nhập hàng thành công!");
                dgvImport.Rows.Clear();
                pnImport.Visible = false;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt = IngredientsDAO.Instance.getByKey(txtFilter.Text);
            dgvIngredient.DataSource = dt;
        }
    }
}
