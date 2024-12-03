namespace QuanLyCafe.GUI
{
    partial class CreateBill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.billSettingPanel = new System.Windows.Forms.Panel();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.btnBillCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCreateBill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntFilter = new System.Windows.Forms.Button();
            this.cbPriceInc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.itemList = new System.Windows.Forms.FlowLayoutPanel();
            this.billSettingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // billSettingPanel
            // 
            this.billSettingPanel.Controls.Add(this.btnCheckCustomer);
            this.billSettingPanel.Controls.Add(this.label7);
            this.billSettingPanel.Controls.Add(this.txtCusPhone);
            this.billSettingPanel.Controls.Add(this.label6);
            this.billSettingPanel.Controls.Add(this.txtCusName);
            this.billSettingPanel.Controls.Add(this.btnBillCancel);
            this.billSettingPanel.Controls.Add(this.btnDone);
            this.billSettingPanel.Controls.Add(this.panel1);
            this.billSettingPanel.Controls.Add(this.label1);
            this.billSettingPanel.Controls.Add(this.dgvCreateBill);
            this.billSettingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.billSettingPanel.Location = new System.Drawing.Point(0, 0);
            this.billSettingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billSettingPanel.Name = "billSettingPanel";
            this.billSettingPanel.Size = new System.Drawing.Size(615, 837);
            this.billSettingPanel.TabIndex = 1;
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.Location = new System.Drawing.Point(585, 433);
            this.btnCheckCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(20, 19);
            this.btnCheckCustomer.TabIndex = 19;
            this.btnCheckCustomer.Text = "C";
            this.toolTip1.SetToolTip(this.btnCheckCustomer, "Kiểm tra khách hàng");
            this.btnCheckCustomer.UseVisualStyleBackColor = true;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số điện thoại khách hàng:";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(425, 433);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(156, 20);
            this.txtCusPhone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên khách hàng:";
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Location = new System.Drawing.Point(113, 433);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(156, 20);
            this.txtCusName.TabIndex = 6;
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBillCancel.FlatAppearance.BorderSize = 0;
            this.btnBillCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBillCancel.Location = new System.Drawing.Point(395, 500);
            this.btnBillCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Size = new System.Drawing.Size(103, 30);
            this.btnBillCancel.TabIndex = 5;
            this.btnBillCancel.Text = "Huỷ Hoá Đơn";
            this.btnBillCancel.UseVisualStyleBackColor = false;
            this.btnBillCancel.Click += new System.EventHandler(this.btnBillCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Location = new System.Drawing.Point(502, 500);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(103, 30);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Thanh Toán";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 499);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 29);
            this.panel1.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(64, 1);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁC SẢN PHẨM ĐÃ CHỌN";
            // 
            // dgvCreateBill
            // 
            this.dgvCreateBill.AllowUserToAddRows = false;
            this.dgvCreateBill.AllowUserToDeleteRows = false;
            this.dgvCreateBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemName,
            this.price,
            this.count,
            this.thanhTien,
            this.delete});
            this.dgvCreateBill.Location = new System.Drawing.Point(2, 44);
            this.dgvCreateBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCreateBill.Name = "dgvCreateBill";
            this.dgvCreateBill.RowHeadersWidth = 51;
            this.dgvCreateBill.RowTemplate.Height = 24;
            this.dgvCreateBill.Size = new System.Drawing.Size(612, 362);
            this.dgvCreateBill.TabIndex = 0;
            this.dgvCreateBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreateBill_CellContentClick);
            this.dgvCreateBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreateBill_CellValueChanged);
            this.dgvCreateBill.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvCreateBill_ColumnAdded);
            this.dgvCreateBill.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCreateBill_RowsAdded);
            this.dgvCreateBill.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCreateBill_RowsRemoved);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.Frozen = true;
            this.itemName.HeaderText = "Tên Sản Phẩm";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.Frozen = true;
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.Frozen = true;
            this.count.HeaderText = "Số Lượng";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 60;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.Frozen = true;
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            this.thanhTien.Width = 125;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "Xoá";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "Xoá";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntFilter);
            this.panel2.Controls.Add(this.cbPriceInc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtKey);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 46);
            this.panel2.TabIndex = 3;
            // 
            // bntFilter
            // 
            this.bntFilter.Location = new System.Drawing.Point(548, 18);
            this.bntFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntFilter.Name = "bntFilter";
            this.bntFilter.Size = new System.Drawing.Size(56, 19);
            this.bntFilter.TabIndex = 6;
            this.bntFilter.Text = "Lọc";
            this.bntFilter.UseVisualStyleBackColor = true;
            this.bntFilter.Click += new System.EventHandler(this.bntFilter_Click);
            // 
            // cbPriceInc
            // 
            this.cbPriceInc.FormattingEnabled = true;
            this.cbPriceInc.Items.AddRange(new object[] {
            "Cao đến thấp",
            "Thấp đến cao"});
            this.cbPriceInc.Location = new System.Drawing.Point(253, 18);
            this.cbPriceInc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPriceInc.Name = "cbPriceInc";
            this.cbPriceInc.Size = new System.Drawing.Size(114, 21);
            this.cbPriceInc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ khoá";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(52, 20);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(160, 20);
            this.txtKey.TabIndex = 0;
            // 
            // itemList
            // 
            this.itemList.AutoScroll = true;
            this.itemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemList.Location = new System.Drawing.Point(615, 46);
            this.itemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(675, 791);
            this.itemList.TabIndex = 4;
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.billSettingPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateBill";
            this.Size = new System.Drawing.Size(1290, 837);
            this.Load += new System.EventHandler(this.CreateBill_Load);
            this.billSettingPanel.ResumeLayout(false);
            this.billSettingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel billSettingPanel;
        public System.Windows.Forms.DataGridView dgvCreateBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel itemList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPriceInc;
        private System.Windows.Forms.Button bntFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Button btnCheckCustomer;
    }
}
