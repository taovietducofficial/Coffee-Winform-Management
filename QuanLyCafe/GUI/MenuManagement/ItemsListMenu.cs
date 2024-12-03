using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using QuanLyCafe.GUI.Ingredient;
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
using System.Xml.Linq;

namespace QuanLyCafe.GUI
{
    public partial class ItemsListMenu : UserControl
    {
        private MenuDTO menu = new MenuDTO(-1,"Sản phẩm chưa có tên",-1,null);
        private bool flag = false;
        public ItemsListMenu(MenuDTO menu)
        {
            if(menu != null)
                this.menu = menu;
            InitializeComponent();
            //this.Controls.Add(menu);
        }

        private void ItemsListMenu_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(menu.Nname))
                nname.Text = menu.Nname;
            else
                nname.Text = "Sản phẩm chưa có tên";
            price.Text = menu.Price.ToString();
            try
            {
                MemoryStream ms = new MemoryStream(menu.Image);
                picImage.Image = Image.FromStream(ms);
            }
            catch (Exception)
            { }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                float Tprice = -1;
                if (String.IsNullOrEmpty(price.Text))
                    return;
                Tprice = float.Parse(price.Text);
                MemoryStream ms = new MemoryStream();
                picImage.Image.Save(ms, picImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                MenuDTO Mmenu = new MenuDTO(this.menu.Id, nname.Text, Tprice, img);
                MenuDAO.Instance.updateOldItem(Mmenu);
                //product.productImageURL = img;

                price.Enabled = false;
                nname.Enabled = false;
                btnMenuIngredient.Enabled = false;
                flag = false;
                btnUpdate.Text = "Chỉnh sửa";
            }
            else
            {
                price.Enabled = true;
                nname.Enabled = true;
                flag = true;
                btnMenuIngredient.Enabled =true;
                btnUpdate.Text = "Hoàn thành";
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            if (flag)
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
        }

        private void btnMenuIngredient_Click(object sender, EventArgs e)
        {
            IngredientsMenu ingredients = new IngredientsMenu(menu);
            ingredients.ShowDialog();
        }
    }
}
