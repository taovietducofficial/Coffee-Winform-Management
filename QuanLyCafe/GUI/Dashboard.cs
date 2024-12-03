using QuanLyCafe.GUI;
using QuanLyCafe.GUI.BillManagement;
using QuanLyCafe.GUI.Customer;
using QuanLyCafe.GUI.Emloyee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class Dashboard : Form
    {
        private CreateBill createBill = new CreateBill();
        private MenuManagement menu = new MenuManagement();
        private NguyenLieu nguyenLieu = new NguyenLieu();
        private BillManagement billManagement = new BillManagement();
        private Customer customer = new Customer();
        private EmployeeManagement employeeManagement = new EmployeeManagement(); 
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //CreateBill createBill = new CreateBill();
            //createBill.Dock = DockStyle.Fill;
            // mainPanel.Controls.Clear();
            //mainPanel.Controls.Add(createBill);
            addToMainPanel(createBill, btnCreateBill);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            addToMainPanel(createBill, btnCreateBill);

        }
        private void addToMainPanel(UserControl userControl, Button button)
        {
                userControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add((UserControl)userControl);
            foreach (Button item in fpnButton.Controls)
            {
                item.BackColor = Color.White;
            }
            button.BackColor = Color.Teal;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            addToMainPanel(menu, btnMenu);
        }

        private void btnIngre_Click(object sender, EventArgs e)
        {
            addToMainPanel(nguyenLieu, btnIngre);
        }

        private void btnBillManagement_Click(object sender, EventArgs e)
        {
            addToMainPanel(billManagement, btnBillManagement);
        }

        private void btnCusManagement_Click(object sender, EventArgs e)
        {
            addToMainPanel(customer,btnCusManagement);
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            addToMainPanel(employeeManagement, btnEmp);
        }
    }
}
