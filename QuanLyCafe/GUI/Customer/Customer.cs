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

namespace QuanLyCafe.GUI.Customer
{
    public partial class Customer : UserControl
    {
        DataTable dt = new DataTable();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dt = CustomerDAO.Instance.getAll();
            dgvCustomer.DataSource = dt;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) { return; }
            DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
            txtAdd.Text = row.Cells["Cadd"].Value.ToString();
            txtName.Text = row.Cells["Cname"].Value.ToString();
            txtPhone.Text = row.Cells["phone"].Value.ToString();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt = CustomerDAO.Instance.getByKeyword(txtFilter.Text);
            dgvCustomer.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAdd.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerDTO cus = new CustomerDTO(txtPhone.Text, txtName.Text, txtAdd.Text);
            CustomerDAO.Instance.insert(cus);
            dt = CustomerDAO.Instance.getAll();
            dgvCustomer.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerDTO cus = new CustomerDTO(txtPhone.Text, txtName.Text, txtAdd.Text);
            CustomerDAO.Instance.update(cus);
            dt = CustomerDAO.Instance.getAll();
            dgvCustomer.DataSource = dt;
        }
    }
}
