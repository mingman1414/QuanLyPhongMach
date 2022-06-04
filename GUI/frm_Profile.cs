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
    public partial class frm_Profile : DockContent
    {
        public frm_Profile()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Thông Tin Tài Khoản.");

            LoadThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau f = new frm_DoiMatKhau();
            f.ShowDialog();
        }

        private void LoadThongTin()
        {
            txtTenDangNhap.Text = frm_Login.Account.TenDangNhap;
            txtTenHienThi.Text = frm_Login.Account.TenHienThi;
            if (frm_Login.Account.Loai == 0)
                txtLoai.Text = "Nhân viên";
            else txtLoai.Text = "Admin";
        }

        private void frm_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Thông Tin Tài Khoản.");
        }
    }
}
