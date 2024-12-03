using QuanLyCafe.DAO;
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

namespace QuanLyCafe.GUI.BillManagement
{
    public partial class BillManagement : UserControl
    {
        public DataTable dt = new DataTable();
        public BillManagement()
        {
            InitializeComponent();
        }

        private void BillManagement_Load(object sender, EventArgs e)
        {
            if (dgvBill.Columns["Employee"] is DataGridViewComboBoxColumn)
            {
                var column = dgvBill.Columns["Employee"] as DataGridViewComboBoxColumn;
                if (column != null)
                {
                    column.DataSource = EmployeeDAO.Instance.getAll();
                    column.DisplayMember = "ten";
                    column.ValueMember = "id"; 
                }
            }
            if (dgvBill.Columns["phone"] is DataGridViewComboBoxColumn)
            {
                var column = dgvBill.Columns["phone"] as DataGridViewComboBoxColumn;
                if (column != null)
                {
                    column.DataSource = CustomerDAO.Instance.getAll();
                    column.DisplayMember = "Cname";
                    column.ValueMember = "phone";
                }
            }
            if (dgvOrder.Columns["menu"] is DataGridViewComboBoxColumn)
            {
                var column = dgvOrder.Columns["menu"] as DataGridViewComboBoxColumn;
                if (column != null)
                {
                    column.DataSource = MenuDAO.Instance.getAll();
                    column.DisplayMember = "nname";
                    column.ValueMember = "id";
                }
            }
            dgvOrder.AutoGenerateColumns = false;
            dgvBill.AutoGenerateColumns = false;
            dt = BillDAO.Instance.getAll();
            dgvBill.DataSource = dt;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBill.Rows[e.RowIndex];
            if (row != null)
            {
                string id = row.Cells["Bill"].Value.ToString();
                dgvOrder.DataSource = OrderDAO.Instance.getByID(id);

            }
        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            dt = BillDAO.Instance.getAll();
            dgvBill.DataSource = dt;
        }
    }
}
