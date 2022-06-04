using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        public static Account_DTO Account;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtUserName.Text;
            string MatKhau = txtPassword.Text;

            Account = new Account_DTO();
            Account = Account_BUS.LayAccount(TenDangNhap, MatKhau);
            if (Account != null)
            {
                frm_ProgressBar fl = new frm_ProgressBar();
                fl.ShowDialog();
                frm_Main f = new frm_Main();
                this.Hide();
                f.ShowDialog();
                
                this.Show();
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu","Thông báo");
            }
            ///
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                e.Cancel = true;
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienMK.Checked==true)
                txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

    }
}
