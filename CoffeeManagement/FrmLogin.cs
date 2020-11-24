﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Lưu ý phát triển: 
            // Trước khi logout, lưu lại trạng thái checkbox và thông tin tài khoản đăng nhập trước khi logout

            // sau khi load form, kiểm tra checkbox, 
            // Nếu đang check thì load thông tin tài khoản đăng nhập trước khi logout lên
            // Clear thông tin đăng nhập nếu không tick checkbox ckbSavePassword
            // Lưu trạng thái checkbox ckbSavePassword

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Luu ý phát triển:
            // So sánh txbUserName.Text và txbPassWord.Text với UserName và Password lưu trong DB không.
            // Khớp với Account nào thì login vào Account đó (Xem xét quyền)
            if (true) 
            {
                // Ẩn FrmLogin
                this.Hide();
                // Show Dialog FrmSaleManagement
                // Luu ý phát triển: truyền vào parameter, xác định quyền (Login vào Account nào)
                FrmSaleManagement FrmSale = new FrmSaleManagement();
                FrmSale.ShowDialog();

                // Clear thông tin đăng nhập nếu không tick checkbox lưu pass
                // Lưu trạng thái checkbox ckbSavePassword
                if (ckbSavePassword.CheckState != CheckState.Checked)
                {
                    txbUserName.Text = "";
                    txbPassword.Text = "";
                }

                // Mở lại FrmLogin
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiện thông báo "Bạn có chắc chắn muốn thoát chương trình không?"
            // Thông báo đi kèm button "OK" và button "Cancel".
            // Nếu không nhấn "OK" đồng nghĩa với bạn chưa muốn thoát chương trình.
            // Ngược lại nếu nhấn OK thì tắt chương trình.

            #region Cách 1:
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            #endregion

            #region Cách 2 : Tường minh, giải thích cho cách 1
            //String ms = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo).ToString();
            //String ds = DialogResult.Yes.ToString();
            //if(ms != ds)
            //{
            //    e.Cancel = true;
            //}
            #endregion
        }

        private void ckbSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
