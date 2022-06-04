using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GUI
{
    public partial class frm_DoiMatKhau : DockContent
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Đổi Mật Khẩu.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMKcu.Text == "" || txtMKmoi.Text == "" || txtNhapLaiMKmoi.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            else
            {
                if (Account_BUS.LayAccount(txtUserName.Text, txtMKcu.Text) == null)
                {
                    MessageBox.Show("Sai mật khẩu cũ.");
                    return;
                }
                else if (txtMKmoi.Text != txtNhapLaiMKmoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không giống nhau.");
                    return;
                }
            }
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = txtUserName.Text;
            acc.MatKhau = txtMKcu.Text;
            acc.TenHienThi = frm_Login.Account.TenHienThi;
            if (Account_BUS.DoiMatKhau(acc, txtMKmoi.Text) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            else
            {
                if (MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var a = new WriteLog();
                    a.ButtonWrite("Đổi mật khẩu");

                    this.Close();
                    txtMKcu.Clear();
                    txtMKmoi.Clear();
                    txtNhapLaiMKmoi.Clear();
                }
            }
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked == true)
            {
                txtMKcu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtNhapLaiMKmoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKcu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtNhapLaiMKmoi.UseSystemPasswordChar = true;
            }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUserName.Text = frm_Login.Account.TenDangNhap;
        }

        private void frm_DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Đổi Mật Khẩu.");
        }
    }
}
