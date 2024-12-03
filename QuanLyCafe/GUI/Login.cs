using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.GUI
{
    public partial class Login : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        bool KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            if(tendangnhap == this.tentaikhoan && matkhau == this.matkhau) 
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtpass.Text))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản hoặc Mật Khẩu", "Lỗi Đăng Nhập");
            }
        }
    }
}
