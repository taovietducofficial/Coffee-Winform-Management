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

namespace QuanLyCafe.GUI
{
    public partial class ItemsList : UserControl
    {
        private CreateBill createBillControl;
        private MenuDTO menu = new MenuDTO(0, "Sản phẩm không có tên", 0.0, null);
        //private Menu menu;
        public ItemsList(CreateBill createBill = null, MenuDTO menu = null)
        {
            InitializeComponent();
            this.createBillControl = createBill;
            if(menu!=null)
                this.menu = menu;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            // Tạo một DataGridViewRow mới
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(createBillControl.dgvCreateBill);
            newRow.Cells[0].Value = menu.Id;
            newRow.Cells[1].Value = menu.Nname;
            newRow.Cells[2].Value = menu.Price;
            newRow.Cells[3].Value = 1;
            createBillControl.updateCreateBill(newRow);
        }

        private void ItemsList_Load(object sender, EventArgs e)
        {
            itemName.Text = menu.Nname.ToString();
            price.Text = menu.Price.ToString();
            try
            {
                MemoryStream ms = new MemoryStream(menu.Image);
                picImage.Image = Image.FromStream(ms);
            }
            catch (Exception)
            { }
        }
    }
}
