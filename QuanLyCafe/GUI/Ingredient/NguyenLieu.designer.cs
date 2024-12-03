namespace QuanLyCafe.GUI
{
    partial class NguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnImport = new System.Windows.Forms.Panel();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.idIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImportDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnResetInput = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.billSettingPanel = new System.Windows.Forms.Panel();
            this.dgvIngredient = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pnImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.panel3.SuspendLayout();
            this.billSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(635, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 49);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(445, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(298, 22);
            this.txtId.TabIndex = 0;
            // 
            // pnImport
            // 
            this.pnImport.Controls.Add(this.dgvImport);
            this.pnImport.Controls.Add(this.panel3);
            this.pnImport.Controls.Add(this.btnClose);
            this.pnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnImport.Location = new System.Drawing.Point(1247, 0);
            this.pnImport.Margin = new System.Windows.Forms.Padding(4);
            this.pnImport.Name = "pnImport";
            this.pnImport.Size = new System.Drawing.Size(473, 1030);
            this.pnImport.TabIndex = 19;
            this.pnImport.Visible = false;
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIng,
            this.number});
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(0, 49);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.RowHeadersWidth = 51;
            this.dgvImport.RowTemplate.Height = 24;
            this.dgvImport.Size = new System.Drawing.Size(473, 981);
            this.dgvImport.TabIndex = 20;
            // 
            // idIng
            // 
            this.idIng.DataPropertyName = "idIng";
            this.idIng.HeaderText = "ID Nguyên Liệu";
            this.idIng.MinimumWidth = 6;
            this.idIng.Name = "idIng";
            this.idIng.Width = 125;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Số lượng nhập về";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImportDone);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtEmployeeID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 49);
            this.panel3.TabIndex = 19;
            // 
            // btnImportDone
            // 
            this.btnImportDone.Location = new System.Drawing.Point(323, 12);
            this.btnImportDone.Name = "btnImportDone";
            this.btnImportDone.Size = new System.Drawing.Size(119, 23);
            this.btnImportDone.TabIndex = 7;
            this.btnImportDone.Text = "Hoàn Thành";
            this.btnImportDone.UseVisualStyleBackColor = true;
            this.btnImportDone.Click += new System.EventHandler(this.btnImportDone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Nhân viên nhập:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(128, 13);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 6;
            this.txtEmployeeID.Text = "1";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(867, 76);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(298, 26);
            this.btnImport.TabIndex = 31;
            this.btnImport.Text = "Nhập thêm nguyên liệu";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnResetInput
            // 
            this.btnResetInput.Location = new System.Drawing.Point(764, 42);
            this.btnResetInput.Name = "btnResetInput";
            this.btnResetInput.Size = new System.Drawing.Size(401, 23);
            this.btnResetInput.TabIndex = 29;
            this.btnResetInput.Text = "Reset Input";
            this.btnResetInput.UseVisualStyleBackColor = true;
            this.btnResetInput.Click += new System.EventHandler(this.btnResetInput_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(640, 79);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(203, 23);
            this.btnUpd.TabIndex = 28;
            this.btnUpd.Text = "Chỉnh sửa";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Nguyên Liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(445, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(298, 22);
            this.txtPrice.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(867, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 22);
            this.txtName.TabIndex = 22;
            // 
            // billSettingPanel
            // 
            this.billSettingPanel.Controls.Add(this.dgvIngredient);
            this.billSettingPanel.Controls.Add(this.panel1);
            this.billSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billSettingPanel.Location = new System.Drawing.Point(0, 0);
            this.billSettingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billSettingPanel.Name = "billSettingPanel";
            this.billSettingPanel.Size = new System.Drawing.Size(1247, 1030);
            this.billSettingPanel.TabIndex = 22;
            // 
            // dgvIngredient
            // 
            this.dgvIngredient.AllowUserToAddRows = false;
            this.dgvIngredient.AllowUserToDeleteRows = false;
            this.dgvIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.gia,
            this.so});
            this.dgvIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredient.Location = new System.Drawing.Point(0, 113);
            this.dgvIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.RowHeadersWidth = 51;
            this.dgvIngredient.RowTemplate.Height = 24;
            this.dgvIngredient.Size = new System.Drawing.Size(1247, 917);
            this.dgvIngredient.TabIndex = 3;
            this.dgvIngredient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredient_CellContentClick);
            this.dgvIngredient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredient_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.Frozen = true;
            this.ten.HeaderText = "Tên Nguyên Liệu";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 200;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.Frozen = true;
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 125;
            // 
            // so
            // 
            this.so.DataPropertyName = "so";
            this.so.Frozen = true;
            this.so.HeaderText = "Số Lượng";
            this.so.MinimumWidth = 6;
            this.so.Name = "so";
            this.so.Width = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnResetInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnUpd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 113);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(19, 76);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(315, 22);
            this.txtFilter.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Từ khoá";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(93, 49);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(241, 23);
            this.btnFilter.TabIndex = 34;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.billSettingPanel);
            this.Controls.Add(this.pnImport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NguyenLieu";
            this.Size = new System.Drawing.Size(1720, 1030);
            this.Load += new System.EventHandler(this.NguyenLieu_Load);
            this.pnImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.billSettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnImport;
        private System.Windows.Forms.Panel billSettingPanel;
        public System.Windows.Forms.DataGridView dgvIngredient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResetInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn so;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Button btnImportDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
    }
}
