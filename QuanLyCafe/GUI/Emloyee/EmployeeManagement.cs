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
using System.Xml.Linq;

namespace QuanLyCafe.GUI.Emloyee
{
    public partial class EmployeeManagement : UserControl
    {
        DataTable dt = new DataTable();
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            dt = EmployeeDAO.Instance.getAll();
            loadData();
        }
        private void loadData()
        {
            dgvEmployee.DataSource = dt;
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) { return; }
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            txtID.Text = row.Cells["id"].Value.ToString();
            DateTime birthDate;
            if (DateTime.TryParse(row.Cells["birth"].Value.ToString(), out birthDate))
            {
                dtpBirth.Value = birthDate;
            }
            else
            {
                // Handle parsing failure
                // For example, display an error message or set a default value for the DateTimePicker
            }
            txtAddr.Text = row.Cells["diachi"].Value.ToString();
            txtName.Text = row.Cells["ten"].Value.ToString();
            txtGen.Text = row.Cells["gen"].Value.ToString();
            txtPhone.Text = row.Cells["phone"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPhone.ResetText();
            txtAddr.ResetText();
            txtGen.ResetText();
            txtID.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
            dtpBirth.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeDTO employee = new EmployeeDTO(0, txtName.Text, txtGen.Text, dtpBirth.Value, txtAddr.Text, txtPhone.Text);
            EmployeeDAO.Instance.insert(employee);
            dt = EmployeeDAO.Instance.getAll();
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt = EmployeeDAO.Instance.getByKeyword(txtFilter.Text);
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text)) return;
            EmployeeDTO employee = new EmployeeDTO(Int32.Parse(txtID.Text), txtName.Text, txtGen.Text, dtpBirth.Value, txtAddr.Text, txtPhone.Text);
            EmployeeDAO.Instance.update(employee);
            dt = EmployeeDAO.Instance.getAll();
            loadData();
        }
    }
}
