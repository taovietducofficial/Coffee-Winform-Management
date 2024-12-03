using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace QuanLyCafe.GUI
{
    public partial class MenuManagement : UserControl
    {
        DataTable dt = new DataTable();
        public MenuManagement()
        {
            InitializeComponent();
        }
        private void MenuManagement_Load(object sender, EventArgs e)
        {
            dt = MenuDAO.Instance.getAll();
            cbPriceInc.SelectedIndex = 0;
            loadData();
        }
        private void loadData()
        {
            //ItemsListMenu itemsListMenu = new ItemsListMenu(null);
            //flpMenu.Controls.Add(itemsListMenu);
            flpMenu.Controls.Clear();
            sortMenuByPrice();

            // Duyệt qua từng hàng trong DataTable và tạo các đối tượng MenuDTO
            foreach (DataRow row in dt.Rows)
            {
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
                ItemsListMenu item = new ItemsListMenu(menu);
                flpMenu.Controls.Add(item);
            }
        }
        private void sortMenuByPrice()
        {
            bool isSort = true;
            if (cbPriceInc.SelectedIndex == 0)
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt = MenuDAO.Instance.searchByKeyword(txtKey.Text);
            loadData();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = new Bitmap(openFileDialog.FileName);
                    MessageBox.Show("Upload ảnh thành công!");
                }
                else
                {
                    MessageBox.Show("Upload ảnh thất bại! vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra rồi! \nNỘI DUNG LỖI: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float price = -1;
            if (String.IsNullOrEmpty(txtPrice.Text))
                return;
            price = float.Parse(txtPrice.Text);
            MemoryStream ms = new MemoryStream();
            picImage.Image.Save(ms, picImage.Image.RawFormat);
            byte[] img = ms.ToArray();
            MenuDTO menu = new MenuDTO(-1, txtName.Text, price,img);
            MenuDAO.Instance.insertNewItem(menu);
            loadData();
            //product.productImageURL = img;
        }
    }
}
