namespace QuanLyCafe.GUI.Ingredient
{
    partial class IngredientsMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.cbIng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.idIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbIng);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 125);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIngredients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 444);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(210, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 1;
            this.name.Text = "label2";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(56, 20);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 16);
            this.price.TabIndex = 3;
            this.price.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIng,
            this.nname,
            this.prices,
            this.number,
            this.delete});
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.Location = new System.Drawing.Point(0, 0);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.RowHeadersWidth = 51;
            this.dgvIngredients.RowTemplate.Height = 24;
            this.dgvIngredients.Size = new System.Drawing.Size(955, 444);
            this.dgvIngredients.TabIndex = 0;
            this.dgvIngredients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellContentClick);
            // 
            // cbIng
            // 
            this.cbIng.FormattingEnabled = true;
            this.cbIng.Location = new System.Drawing.Point(601, 39);
            this.cbIng.Name = "cbIng";
            this.cbIng.Size = new System.Drawing.Size(121, 24);
            this.cbIng.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nguyên Liệu: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(760, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(601, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm vào danh sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // idIng
            // 
            this.idIng.DataPropertyName = "idIng";
            this.idIng.HeaderText = "ID Nguyên Liệu";
            this.idIng.MinimumWidth = 6;
            this.idIng.Name = "idIng";
            this.idIng.ReadOnly = true;
            this.idIng.Width = 125;
            // 
            // nname
            // 
            this.nname.DataPropertyName = "nname";
            this.nname.HeaderText = "Tên Nguyên Liệu";
            this.nname.MinimumWidth = 6;
            this.nname.Name = "nname";
            this.nname.ReadOnly = true;
            this.nname.Width = 125;
            // 
            // prices
            // 
            this.prices.DataPropertyName = "price";
            this.prices.HeaderText = "Giá Nhập";
            this.prices.MinimumWidth = 6;
            this.prices.Name = "prices";
            this.prices.ReadOnly = true;
            this.prices.Width = 125;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Định Lượng";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Xoá";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xoá";
            this.delete.ToolTipText = "Xoá";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // IngredientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IngredientsMenu";
            this.Text = "IngredientsMenu";
            this.Load += new System.EventHandler(this.IngredientsMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn nname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}