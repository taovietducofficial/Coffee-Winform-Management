namespace QuanLyCafe.GUI
{
    partial class ItemsList
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Image = global::QuanLyCafe.Properties.Resources._3767084;
            this.picImage.Location = new System.Drawing.Point(20, 20);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(147, 89);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(3, 112);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(186, 16);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Trà Sữa Trân Trâu Hoàng Kim";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(20, 191);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(147, 39);
            this.addItem.TabIndex = 2;
            this.addItem.Text = "Thêm Sản Phẩm";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(118, 138);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(49, 16);
            this.price.TabIndex = 3;
            this.price.Text = "100000";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.price);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.picImage);
            this.Name = "ItemsList";
            this.Size = new System.Drawing.Size(189, 249);
            this.Load += new System.EventHandler(this.ItemsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label price;
    }
}
