namespace QuanLyCafe
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.toolBox = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnIngre = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.fpnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBillManagement = new System.Windows.Forms.Button();
            this.btnCusManagement = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.toolBox.SuspendLayout();
            this.fpnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBox
            // 
            this.toolBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolBox.Controls.Add(this.btnLogout);
            this.toolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBox.Location = new System.Drawing.Point(205, 0);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(1697, 50);
            this.toolBox.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Location = new System.Drawing.Point(1598, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.toolTip1.SetToolTip(this.btnLogout, "Đăng xuất khỏi tài khoản");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(205, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1697, 983);
            this.mainPanel.TabIndex = 2;
            // 
            // btnIngre
            // 
            this.btnIngre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIngre.FlatAppearance.BorderSize = 0;
            this.btnIngre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngre.Location = new System.Drawing.Point(3, 155);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(197, 70);
            this.btnIngre.TabIndex = 2;
            this.btnIngre.Text = "Quản Lý Nguyên Liệu";
            this.btnIngre.UseVisualStyleBackColor = false;
            this.btnIngre.Click += new System.EventHandler(this.btnIngre_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(3, 79);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(197, 70);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateBill.FlatAppearance.BorderSize = 0;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Location = new System.Drawing.Point(3, 3);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(197, 70);
            this.btnCreateBill.TabIndex = 0;
            this.btnCreateBill.Text = "Lập Hoá Đơn";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // fpnButton
            // 
            this.fpnButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.fpnButton.Controls.Add(this.btnCreateBill);
            this.fpnButton.Controls.Add(this.btnMenu);
            this.fpnButton.Controls.Add(this.btnIngre);
            this.fpnButton.Controls.Add(this.btnBillManagement);
            this.fpnButton.Controls.Add(this.btnCusManagement);
            this.fpnButton.Controls.Add(this.btnEmp);
            this.fpnButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnButton.Location = new System.Drawing.Point(0, 0);
            this.fpnButton.Name = "fpnButton";
            this.fpnButton.Size = new System.Drawing.Size(205, 1033);
            this.fpnButton.TabIndex = 0;
            // 
            // btnBillManagement
            // 
            this.btnBillManagement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBillManagement.FlatAppearance.BorderSize = 0;
            this.btnBillManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillManagement.Location = new System.Drawing.Point(3, 231);
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.Size = new System.Drawing.Size(197, 70);
            this.btnBillManagement.TabIndex = 3;
            this.btnBillManagement.Text = "Quản Lý Hoá Đơn";
            this.btnBillManagement.UseVisualStyleBackColor = false;
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click);
            // 
            // btnCusManagement
            // 
            this.btnCusManagement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCusManagement.FlatAppearance.BorderSize = 0;
            this.btnCusManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusManagement.Location = new System.Drawing.Point(3, 307);
            this.btnCusManagement.Name = "btnCusManagement";
            this.btnCusManagement.Size = new System.Drawing.Size(197, 70);
            this.btnCusManagement.TabIndex = 4;
            this.btnCusManagement.Text = "Quản Lý Khách Hàng";
            this.btnCusManagement.UseVisualStyleBackColor = false;
            this.btnCusManagement.Click += new System.EventHandler(this.btnCusManagement_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Location = new System.Drawing.Point(3, 383);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(197, 70);
            this.btnEmp.TabIndex = 5;
            this.btnEmp.Text = "Quản Lý Nhân Viên";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.fpnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.toolBox.ResumeLayout(false);
            this.fpnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.FlowLayoutPanel fpnButton;
        private System.Windows.Forms.Button btnBillManagement;
        private System.Windows.Forms.Button btnCusManagement;
        private System.Windows.Forms.Button btnEmp;
    }
}

