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
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_TaiKhoanQL : DockContent
    {
        public frm_TaiKhoanQL()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Quản Lí Tài Khoản.");
        }

        private void frm_TaiKhoanQL_Load(object sender, EventArgs e)
        {
            HienThiDSAccount();
            cmbLoaiTK.Items.Add("Admin");
            cmbLoaiTK.Items.Add("Nhân viên");
        }

        private void HienThiDSAccount()
        {
            List<Account_DTO> lstNhanVien = Account_BUS.LayDSAccount();
            dgvTaiKhoan.DataSource = lstNhanVien;
            dgvTaiKhoan.Columns["TenHienThi"].HeaderText = "Tên hiển thị";
            dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvTaiKhoan.Columns["MatKhau"].Visible = false;
            dgvTaiKhoan.Columns["Loai"].HeaderText = "Loại";

            dgvTaiKhoan.Columns["TenHienThi"].Width = 120;
            dgvTaiKhoan.Columns["TenDangNhap"].Width = 120;
            dgvTaiKhoan.Columns["Loai"].Width = 50;

            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvTaiKhoan.SelectedRows[0];
            txtTenDangNhap.Text = dr.Cells["TenDangNhap"].Value.ToString();
            txtTenHienThi.Text= dr.Cells["TenHienThi"].Value.ToString();
            if (int.Parse(dr.Cells["Loai"].Value.ToString()) == 1)
                cmbLoaiTK.SelectedItem = "Admin";
            else cmbLoaiTK.SelectedItem = "Nhân viên";
            var a = new WriteLog();
            a.ButtonWrite("Xem thông tin tài khoản "+ dr.Cells["TenDangNhap"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = txtTenDangNhap.Text;

            if (Account_BUS.XoaAccount(acc) == true)
            {
                HienThiDSAccount();
                MessageBox.Show("Đã xóa tài khoản.");
                var a = new WriteLog();
                a.ButtonWrite("Xóa tài khoản "+txtTenDangNhap.Text);
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiem tra trong
            if (txtTenDangNhap.Text == "" || txtTenHienThi.Text == "" || cmbLoaiTK.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = txtTenDangNhap.Text;
            acc.TenHienThi = txtTenHienThi.Text;
            if (cmbLoaiTK.SelectedItem.ToString() == "Admin")
                acc.Loai = 1;
            else acc.Loai = 0;

            if (Account_BUS.ThemAccount(acc) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDSAccount();
            MessageBox.Show("Đã thêm tài khoản.", "Thông báo");
            var a = new WriteLog();
            a.ButtonWrite("Thêm tài khoản " + txtTenDangNhap.Text);
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = txtTenDangNhap.Text;
            if (Account_BUS.ResetPass(acc) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDSAccount();
            MessageBox.Show("Đã đặt lại mật khẩu cho tài khoản.\nMật khẩu mới là: 1", "Thông báo");
            var a = new WriteLog();
            a.ButtonWrite("Reset mật khẩu tài khoản "+txtTenDangNhap.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = txtTenDangNhap.Text;
            acc.TenHienThi = txtTenHienThi.Text;
            if (cmbLoaiTK.SelectedItem.ToString() == "Admin")
                acc.Loai = 1;
            else acc.Loai = 0;

            if (Account_BUS.SuaAccount(acc) == false)
            {
                MessageBox.Show("Không sửa được.", "Thông báo");
                return;
            }

            HienThiDSAccount();
            MessageBox.Show("Đã sửa tài khoản.", "Thông báo");
            var a = new WriteLog();
            a.ButtonWrite("Sửa thông tin tài khoản " + txtTenDangNhap.Text);
        }

        private void frm_TaiKhoanQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Quản Lí Tài Khoản.");
        }
    }
}
