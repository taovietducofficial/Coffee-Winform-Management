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

namespace QuanLyCafe.GUI
{
    public partial class CreateBill : UserControl
    {
        DataTable dt = new DataTable();
        public CreateBill()
        {
            InitializeComponent();
        }

        public void updateCreateBill(DataGridViewRow row)
        {
            //ItemsList item = new ItemsList(this);
            //itemList.Controls.Add(item);
            foreach(DataGridViewRow item in dgvCreateBill.Rows)
            {
                if (item.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                {
                    int count = int.Parse(item.Cells["count"].Value.ToString()) + 1;
                    item.Cells["count"].Value = count.ToString();
                    return;
                }
            }
            dgvCreateBill.Rows.Add(row);
        }

        private void CreateBill_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
           
            
            // Xóa tất cả các control hiện có trong itemList trước khi thêm mới
            itemList.Controls.Clear();

            // Lấy danh sách các món từ cơ sở dữ liệu
            dt = MenuDAO.Instance.getAll();
            cbPriceInc.SelectedIndex = 0;
            
            loadMenuPanel();
        }
        private void sortMenuByPrice()
        {
            bool isSort = true;
            if(cbPriceInc.SelectedIndex == 0)
                isSort = false;
            // Tạo một DataView từ DataTable để sắp xếp dữ liệu
            DataView dv = dt.DefaultView;
            if (isSort)
                dv.Sort = "price ASC"; // Sắp xếp theo cột "price" theo thứ tự tăng dần
            else
                dv.Sort = "price DESC";
            // Lấy DataTable đã sắp xếp từ DataView
            DataTable sortedDt = dv.ToTable();

            // Xóa tất cả các hàng trong DataTable gốc
            dt.Rows.Clear();

            // Thêm các hàng từ DataTable đã sắp xếp vào DataTable gốc
            foreach (DataRow row in sortedDt.Rows)
            {
                dt.Rows.Add(row.ItemArray);
            }
        }
        private void loadMenuPanel()
        {
            itemList.Controls.Clear();
            sortMenuByPrice();
            
            // Duyệt qua từng hàng trong DataTable và tạo các đối tượng MenuDTO
            foreach (DataRow row in dt.Rows)
            {
                //MessageBox.Show(row.ToString());
                // Lấy thông tin từng cột trong hàng
                int id = Convert.ToInt32(row["id"]);
                string name = row["nname"].ToString();
                double price = Convert.ToDouble(row["price"]);
                byte[] imageurl = null;
                if (row["imageurl"] != DBNull.Value && row["imageurl"] is byte[])
                {
                    imageurl = (byte[])row["imageurl"];
                }

                // Tạo đối tượng MenuDTO từ dữ liệu
                MenuDTO menu = new MenuDTO(id, name, price, imageurl);

                // Tạo một control mới cho mỗi món và thêm vào itemList
                ItemsList item = new ItemsList(this, menu);
                itemList.Controls.Add(item);
            }
        }


        private void dgvCreateBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateTotalCell();
            
        }
        private void updateTotalCell()
        {
            float total = 0;
            foreach (DataGridViewRow item in dgvCreateBill.Rows)
            {
                float price = float.Parse(item.Cells[2].Value.ToString());
                float count = float.Parse(item.Cells[3].Value.ToString());
                float equal = price * count;
                item.Cells[4].Value = equal;
                total += equal;
                
            }
            txtTotal.Text = total.ToString();
            
        }

        private void dgvCreateBill_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            updateTotalCell();
        }

        private void dgvCreateBill_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateTotalCell();
        }

        private void dgvCreateBill_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateTotalCell();
        }

        private void dgvCreateBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCreateBill.Columns["delete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCreateBill.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show( "Bạn chắc chắn muốn xoá sản phẩm " + row.Cells[1].Value +" chứ?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    dgvCreateBill.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn huỷ hoá đơn đang thực thi chứ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                dgvCreateBill.Rows.Clear(); }
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            txtCusName.Text = null;
            string name = MenuDAO.Instance.checkCustomer(txtCusPhone.Text);
            if(name  == "0")
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Error"); return;
            }
            txtCusName.Text = name;
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrderDTO> orders = new List<OrderDTO>();
                foreach (DataGridViewRow row in dgvCreateBill.Rows)
                {
                    if (!row.IsNewRow) // Loại bỏ hàng mới tạo
                    {
                        int idMenu = Convert.ToInt32(row.Cells["id"].Value);
                        int number = Convert.ToInt32(row.Cells["count"].Value);
                        string name = row.Cells["itemName"].Value.ToString();
                        string id = (row.Index + 1).ToString();
                        if(number  < 1)
                        {
                            MessageBox.Show("Sản phẩm " + name + " ở cột số " + id + " có số lượng không hợp lệ!");
                            return;
                        }    
                        OrderDTO order = new OrderDTO(0, idMenu, "s", number);
                        orders.Add(order);
                    }
                }
                if(orders.Count <= 0)
                {
                    MessageBox.Show("Chưa chọn sản phẩm!");
                    return;
                }
                string phoneNo = "0000000000";
                if (!String.IsNullOrEmpty(txtCusPhone.Text))
                {
                    phoneNo = txtCusPhone.Text;
                }

                BillDTO billDTO = new BillDTO(null, 1, DateTime.Now, phoneNo);
                MenuDAO.Instance.insert(billDTO, orders);
                MessageBox.Show("Tạo hoá đơn thành công!");

                //Clean
                dgvCreateBill.Rows.Clear();
                txtCusName.ResetText();
                txtTotal.Text = "0";
                txtCusPhone.ResetText();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Tạo hoá đơn thất bại!");
            }
        }

        private void bntFilter_Click(object sender, EventArgs e)
        {
            //Select* from getMenuByKeyword(
            dt = MenuDAO.Instance.searchByKeyword(txtKey.Text);
            loadMenuPanel();
        }
    }
}
