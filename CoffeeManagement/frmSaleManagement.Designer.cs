namespace CoffeeManagement
{
    partial class FrmSaleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleManagement));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.mnsTableManagement = new System.Windows.Forms.MenuStrip();
            this.mnsiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmNumbersFood = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDiscountMode = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.mnsTableManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumbersFood)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscountValue)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(452, 433);
            this.flpTable.TabIndex = 1;
            // 
            // mnsTableManagement
            // 
            this.mnsTableManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiAdmin,
            this.mnsiAccount});
            this.mnsTableManagement.Location = new System.Drawing.Point(0, 0);
            this.mnsTableManagement.Name = "mnsTableManagement";
            this.mnsTableManagement.Size = new System.Drawing.Size(829, 24);
            this.mnsTableManagement.TabIndex = 0;
            this.mnsTableManagement.Text = "menuStrip1";
            // 
            // mnsiAdmin
            // 
            this.mnsiAdmin.Name = "mnsiAdmin";
            this.mnsiAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnsiAdmin.Text = "Admin";
            // 
            // mnsiAccount
            // 
            this.mnsiAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiAccountInfo,
            this.mnsiLogout});
            this.mnsiAccount.Name = "mnsiAccount";
            this.mnsiAccount.Size = new System.Drawing.Size(69, 20);
            this.mnsiAccount.Text = "Tài khoản";
            // 
            // mnsiAccountInfo
            // 
            this.mnsiAccountInfo.Name = "mnsiAccountInfo";
            this.mnsiAccountInfo.Size = new System.Drawing.Size(180, 22);
            this.mnsiAccountInfo.Text = "Thông tin tài khoản";
            this.mnsiAccountInfo.Click += new System.EventHandler(this.mnsiAccountInfo_Click);
            // 
            // mnsiLogout
            // 
            this.mnsiLogout.Name = "mnsiLogout";
            this.mnsiLogout.Size = new System.Drawing.Size(180, 22);
            this.mnsiLogout.Text = "Đăng xuất";
            this.mnsiLogout.Click += new System.EventHandler(this.mnsiLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.nmNumbersFood);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(470, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(269, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 54);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // nmNumbersFood
            // 
            this.nmNumbersFood.Location = new System.Drawing.Point(192, 22);
            this.nmNumbersFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmNumbersFood.Name = "nmNumbersFood";
            this.nmNumbersFood.Size = new System.Drawing.Size(71, 20);
            this.nmNumbersFood.TabIndex = 4;
            this.nmNumbersFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmNumbersFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 36);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(183, 21);
            this.cbFood.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(183, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDiscountMode);
            this.panel2.Controls.Add(this.btnSwitchTable);
            this.panel2.Controls.Add(this.nmDiscountValue);
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.cbSwitchTable);
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Location = new System.Drawing.Point(470, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 60);
            this.panel2.TabIndex = 7;
            // 
            // cbDiscountMode
            // 
            this.cbDiscountMode.FormattingEnabled = true;
            this.cbDiscountMode.Location = new System.Drawing.Point(137, 36);
            this.cbDiscountMode.Name = "cbDiscountMode";
            this.cbDiscountMode.Size = new System.Drawing.Size(76, 21);
            this.cbDiscountMode.TabIndex = 8;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(126, 23);
            this.btnSwitchTable.TabIndex = 12;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscountValue
            // 
            this.nmDiscountValue.Location = new System.Drawing.Point(219, 37);
            this.nmDiscountValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscountValue.Name = "nmDiscountValue";
            this.nmDiscountValue.Size = new System.Drawing.Size(44, 20);
            this.nmDiscountValue.TabIndex = 9;
            this.nmDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDiscountValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(137, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(126, 23);
            this.btnDiscount.TabIndex = 10;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 36);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(126, 21);
            this.cbSwitchTable.TabIndex = 11;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(269, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 54);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(470, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 301);
            this.panel3.TabIndex = 4;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(347, 301);
            this.lsvBill.TabIndex = 6;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // FrmSaleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(829, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.mnsTableManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsTableManagement;
            this.Name = "FrmSaleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán coffee";
            this.mnsTableManagement.ResumeLayout(false);
            this.mnsTableManagement.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmNumbersFood)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscountValue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.MenuStrip mnsTableManagement;
        private System.Windows.Forms.ToolStripMenuItem mnsiAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnsiAccount;
        private System.Windows.Forms.ToolStripMenuItem mnsiAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem mnsiLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmNumbersFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscountValue;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.ComboBox cbDiscountMode;
    }
}