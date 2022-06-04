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
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Đăng nhập bằng người dùng: "+frm_Login.Account.TenDangNhap+".");
            a.FormWrite("Mở form Main.");
        }

        public bool TrangThaiDangNhap;
        public static Account_DTO Account;
        frm_Profile fProfile;
        frm_DoanhThu fDoanhThu;
        frm_TaiKhoanQL fTaiKhoan;
        frm_BacSi fBacSi;
        frm_Thuoc fThuoc;
        frm_BenhNhan fBenhNhan;
        frm_LogForm fLogForm;
        frm_LogButton fLogButton;
        frm_QLBacSi fQLBacSi;
        frm_LuongBS fLuongBS;
        frm_DsBenhNhan fDSBenhNhan;

        private void i_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if (fProfile == null || fProfile.IsDisposed)
            {
                fProfile = new frm_Profile();
                fProfile.MdiParent = this;
                fProfile.Show(dockPanel1, DockState.Document);
            }
        }


        private void i_TaiKhoanQL_Click(object sender, EventArgs e)
        {
            if (fTaiKhoan == null || fTaiKhoan.IsDisposed)
            {
                fTaiKhoan = new frm_TaiKhoanQL();
                fTaiKhoan.MdiParent = this;
                fTaiKhoan.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_BacSi_Click(object sender, EventArgs e)
        {
            if (fBacSi == null || fBacSi.IsDisposed)
            {
                fBacSi = new frm_BacSi();
                fBacSi.MdiParent = this;
                fBacSi.Show(dockPanel1, DockState.Document);
            }
        }

        

        private void i_BenhNhan_Click(object sender, EventArgs e)
        {
            if (fBenhNhan == null || fBenhNhan.IsDisposed)
            {
                fBenhNhan = new frm_BenhNhan();
                fBenhNhan.MdiParent = this;
                fBenhNhan.Show(dockPanel1,DockState.Document);
                if (frm_Login.Account.Loai == 1)
                    fBenhNhan.btnXoa.Enabled = true;
            }
        }

        private void i_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
            var a = new WriteLog();
            a.FormWrite("Đăng xuất khỏi người dùng: " + frm_Login.Account.TenDangNhap + ".");
        }

        private void i_Thuoc_Click(object sender, EventArgs e)
        {
            if (fThuoc == null || fThuoc.IsDisposed)
            {
                fThuoc = new frm_Thuoc();
                fThuoc.MdiParent = this;
                fThuoc.Show(dockPanel1, DockState.Document);
            }
        }

        private void HienMenu()
        {
            ststrTrangThai.Text = frm_Login.Account.TenHienThi;
            if (DateTime.Now.ToString("dddd") == "Monday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ hai " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else if (DateTime.Now.ToString("dddd") == "Tuesday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ ba " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else if (DateTime.Now.ToString("dddd") == "Wednesday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ tư " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else if(DateTime.Now.ToString("dddd")=="Thursday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ năm " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else if (DateTime.Now.ToString("dddd") == "Friday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ sáu " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else if (DateTime.Now.ToString("dddd") == "Saturday")
                ststrThoiGian.Text = "Đăng nhập vào: Thứ bảy " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");
            else ststrThoiGian.Text = "Đăng nhập vào: Chủ nhật " + DateTime.Now.ToString("dd MM yyyy HH:mm:ss");    
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            HienMenu();
            PhanQuyen();
        } 
        
        private void PhanQuyen()
        {
            if(frm_Login.Account.Loai==0)
            {
                i_Admin.Enabled = false;
                i_Account.Enabled = true;
                i_BenhNhan.Enabled = true;
                i_Thuoc.Enabled = true;
            }
            else
            {
                i_Admin.Enabled = true;
                i_Account.Enabled = true;
                i_BenhNhan.Enabled = true;
                i_Thuoc.Enabled = true;
            }
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Main.");
        }

        private void i_LogForm_Click(object sender, EventArgs e)
        {
            if (fLogForm == null || fLogForm.IsDisposed)
            {
                fLogForm = new frm_LogForm();
                fLogForm.MdiParent = this;
                fLogForm.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_LogButton_Click(object sender, EventArgs e)
        {
            if (fLogButton == null || fLogButton.IsDisposed)
            {
                fLogButton = new frm_LogButton();
                fLogButton.MdiParent = this;
                fLogButton.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_SaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog thumuc = new FolderBrowserDialog();
            thumuc.Description = "Chọn thư mục lưu trữ";
            if(thumuc.ShowDialog()==DialogResult.OK)
            {
                string link = thumuc.SelectedPath;
                if (SaoLuu_PhucHoi_BUS.SaoLuu(link) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + link);
                else
                    MessageBox.Show("Không thành công");
            }
        }

        private void i_PhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "File Backup (*.bak)|*.bak|All files (*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                var a = (SaoLuu_PhucHoi_BUS.PhucHoi(d.FileName, "QLPM", @"LAPTOP-UP3QC2F2", "", "")) ?
                MessageBox.Show("Phục hồi thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) : MessageBox.Show("Phục hồi thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void i_DoanhThu_Click_1(object sender, EventArgs e)
        {
            if (fDoanhThu == null || fDoanhThu.IsDisposed)
            {
                fDoanhThu = new frm_DoanhThu();
                fDoanhThu.MdiParent = this;
                fDoanhThu.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_QLBacSi_Click(object sender, EventArgs e)
        {
            
            if (fQLBacSi == null || fQLBacSi.IsDisposed)
            {
                fQLBacSi = new frm_QLBacSi();
                fQLBacSi.MdiParent = this;
                fQLBacSi.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_LuongBacSi_Click(object sender, EventArgs e)
        {
            if (fLuongBS == null || fLuongBS.IsDisposed)
            {
                fLuongBS = new frm_LuongBS();
                fLuongBS.MdiParent = this;
                fLuongBS.Show(dockPanel1, DockState.Document);
            }
        }

        private void i_QLBenhNhan_Click(object sender, EventArgs e)
        {
            if (fDSBenhNhan == null || fDSBenhNhan.IsDisposed)
            {
                fDSBenhNhan = new frm_DsBenhNhan();
                fDSBenhNhan.MdiParent = this;
                fDSBenhNhan.Show(dockPanel1, DockState.Document);
            }
        }
    }
}
