namespace QuanLyCafe.GUI
{
    partial class ItemsListMenu
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nname = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMenuIngredient = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(29, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giá:";
            // 
            // nname
            // 
            this.nname.Enabled = false;
            this.nname.Location = new System.Drawing.Point(29, 109);
            this.nname.Name = "nname";
            this.nname.Size = new System.Drawing.Size(177, 22);
            this.nname.TabIndex = 10;
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(74, 141);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 11;
            // 
            // btnMenuIngredient
            // 
            this.btnMenuIngredient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuIngredient.Enabled = false;
            this.btnMenuIngredient.Location = new System.Drawing.Point(29, 217);
            this.btnMenuIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuIngredient.Name = "btnMenuIngredient";
            this.btnMenuIngredient.Size = new System.Drawing.Size(177, 34);
            this.btnMenuIngredient.TabIndex = 12;
            this.btnMenuIngredient.Text = "Chi Tiết Nguyên Liệu";
            this.btnMenuIngredient.UseVisualStyleBackColor = false;
            this.btnMenuIngredient.Click += new System.EventHandler(this.btnMenuIngredient_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::QuanLyCafe.Properties.Resources._3767084;
            this.picImage.Location = new System.Drawing.Point(44, 2);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(147, 102);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            this.toolTip1.SetToolTip(this.picImage, "Nhấn vô để thay đổi ảnh");
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // ItemsListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnMenuIngredient);
            this.Controls.Add(this.price);
            this.Controls.Add(this.nname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemsListMenu";
            this.Size = new System.Drawing.Size(233, 260);
            this.Load += new System.EventHandler(this.ItemsListMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nname;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMenuIngredient;
    }
}
