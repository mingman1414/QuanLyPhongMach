namespace GUI
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.i_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.i_ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.i_BenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_Thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.i_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.i_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.i_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_QLBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LuongBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_QLBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_TaiKhoanQL = new System.Windows.Forms.ToolStripMenuItem();
            this.i_BacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.i_XemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LogForm = new System.Windows.Forms.ToolStripMenuItem();
            this.i_LogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.i_DuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_SaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_PhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ststrTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.ststrThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_Account,
            this.i_BenhNhan,
            this.i_Thuoc,
            this.i_Admin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // i_Account
            // 
            this.i_Account.BackColor = System.Drawing.Color.DodgerBlue;
            this.i_Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_ThongTinTaiKhoan,
            this.i_DangXuat});
            this.i_Account.Enabled = false;
            this.i_Account.ForeColor = System.Drawing.Color.Black;
            this.i_Account.Name = "i_Account";
            this.i_Account.Size = new System.Drawing.Size(85, 24);
            this.i_Account.Text = "Tài khoản";
            // 
            // i_ThongTinTaiKhoan
            // 
            this.i_ThongTinTaiKhoan.Name = "i_ThongTinTaiKhoan";
            this.i_ThongTinTaiKhoan.Size = new System.Drawing.Size(224, 26);
            this.i_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.i_ThongTinTaiKhoan.Click += new System.EventHandler(this.i_ThongTinTaiKhoan_Click);
            // 
            // i_DangXuat
            // 
            this.i_DangXuat.Name = "i_DangXuat";
            this.i_DangXuat.Size = new System.Drawing.Size(224, 26);
            this.i_DangXuat.Text = "Đăng xuất";
            this.i_DangXuat.Click += new System.EventHandler(this.i_DangXuat_Click);
            // 
            // i_BenhNhan
            // 
            this.i_BenhNhan.Enabled = false;
            this.i_BenhNhan.Name = "i_BenhNhan";
            this.i_BenhNhan.Size = new System.Drawing.Size(92, 24);
            this.i_BenhNhan.Text = "Bệnh nhân";
            this.i_BenhNhan.Click += new System.EventHandler(this.i_BenhNhan_Click);
            // 
            // i_Thuoc
            // 
            this.i_Thuoc.Enabled = false;
            this.i_Thuoc.Name = "i_Thuoc";
            this.i_Thuoc.Size = new System.Drawing.Size(63, 24);
            this.i_Thuoc.Text = "Thuốc";
            this.i_Thuoc.Click += new System.EventHandler(this.i_Thuoc_Click);
            // 
            // i_Admin
            // 
            this.i_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_ThongKe,
            this.i_TaiKhoanQL,
            this.i_BacSi,
            this.i_XemLog,
            this.i_DuLieu});
            this.i_Admin.Enabled = false;
            this.i_Admin.Name = "i_Admin";
            this.i_Admin.Size = new System.Drawing.Size(67, 24);
            this.i_Admin.Text = "Admin";
            // 
            // i_ThongKe
            // 
            this.i_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_DoanhThu,
            this.i_QLBacSi,
            this.i_LuongBacSi,
            this.i_QLBenhNhan});
            this.i_ThongKe.Name = "i_ThongKe";
            this.i_ThongKe.Size = new System.Drawing.Size(154, 26);
            this.i_ThongKe.Text = "Thống kê";
            // 
            // i_DoanhThu
            // 
            this.i_DoanhThu.Name = "i_DoanhThu";
            this.i_DoanhThu.Size = new System.Drawing.Size(176, 26);
            this.i_DoanhThu.Text = "Doanh thu";
            this.i_DoanhThu.Click += new System.EventHandler(this.i_DoanhThu_Click_1);
            // 
            // i_QLBacSi
            // 
            this.i_QLBacSi.Name = "i_QLBacSi";
            this.i_QLBacSi.Size = new System.Drawing.Size(176, 26);
            this.i_QLBacSi.Text = "Bác sĩ";
            this.i_QLBacSi.Click += new System.EventHandler(this.i_QLBacSi_Click);
            // 
            // i_LuongBacSi
            // 
            this.i_LuongBacSi.Name = "i_LuongBacSi";
            this.i_LuongBacSi.Size = new System.Drawing.Size(176, 26);
            this.i_LuongBacSi.Text = "Lương bác sĩ";
            this.i_LuongBacSi.Click += new System.EventHandler(this.i_LuongBacSi_Click);
            // 
            // i_QLBenhNhan
            // 
            this.i_QLBenhNhan.Name = "i_QLBenhNhan";
            this.i_QLBenhNhan.Size = new System.Drawing.Size(176, 26);
            this.i_QLBenhNhan.Text = "Bệnh nhân";
            this.i_QLBenhNhan.Click += new System.EventHandler(this.i_QLBenhNhan_Click);
            // 
            // i_TaiKhoanQL
            // 
            this.i_TaiKhoanQL.Name = "i_TaiKhoanQL";
            this.i_TaiKhoanQL.Size = new System.Drawing.Size(154, 26);
            this.i_TaiKhoanQL.Text = "Tài khoản";
            this.i_TaiKhoanQL.Click += new System.EventHandler(this.i_TaiKhoanQL_Click);
            // 
            // i_BacSi
            // 
            this.i_BacSi.Name = "i_BacSi";
            this.i_BacSi.Size = new System.Drawing.Size(154, 26);
            this.i_BacSi.Text = "Bác sĩ";
            this.i_BacSi.Click += new System.EventHandler(this.i_BacSi_Click);
            // 
            // i_XemLog
            // 
            this.i_XemLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_LogForm,
            this.i_LogButton});
            this.i_XemLog.Name = "i_XemLog";
            this.i_XemLog.Size = new System.Drawing.Size(154, 26);
            this.i_XemLog.Text = "Xem log";
            // 
            // i_LogForm
            // 
            this.i_LogForm.Name = "i_LogForm";
            this.i_LogForm.Size = new System.Drawing.Size(165, 26);
            this.i_LogForm.Text = "Log form";
            this.i_LogForm.Click += new System.EventHandler(this.i_LogForm_Click);
            // 
            // i_LogButton
            // 
            this.i_LogButton.Name = "i_LogButton";
            this.i_LogButton.Size = new System.Drawing.Size(165, 26);
            this.i_LogButton.Text = "Log button";
            this.i_LogButton.Click += new System.EventHandler(this.i_LogButton_Click);
            // 
            // i_DuLieu
            // 
            this.i_DuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_SaoLuu,
            this.i_PhucHoi});
            this.i_DuLieu.Name = "i_DuLieu";
            this.i_DuLieu.Size = new System.Drawing.Size(154, 26);
            this.i_DuLieu.Text = "Dữ liệu";
            // 
            // i_SaoLuu
            // 
            this.i_SaoLuu.Name = "i_SaoLuu";
            this.i_SaoLuu.Size = new System.Drawing.Size(148, 26);
            this.i_SaoLuu.Text = "Sao lưu";
            this.i_SaoLuu.Click += new System.EventHandler(this.i_SaoLuu_Click);
            // 
            // i_PhucHoi
            // 
            this.i_PhucHoi.Name = "i_PhucHoi";
            this.i_PhucHoi.Size = new System.Drawing.Size(148, 26);
            this.i_PhucHoi.Text = "Phục hồi";
            this.i_PhucHoi.Click += new System.EventHandler(this.i_PhucHoi_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ststrTrangThai,
            this.ststrThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1007);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1902, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststrTrangThai
            // 
            this.ststrTrangThai.Name = "ststrTrangThai";
            this.ststrTrangThai.Size = new System.Drawing.Size(150, 20);
            this.ststrTrangThai.Text = "Trạng thái đăng nhập";
            // 
            // ststrThoiGian
            // 
            this.ststrThoiGian.Name = "ststrThoiGian";
            this.ststrThoiGian.Size = new System.Drawing.Size(71, 20);
            this.ststrThoiGian.Text = "Thời gian";
            // 
            // dockPanel1
            // 
            this.dockPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 28);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1902, 979);
            this.dockPanel1.TabIndex = 5;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí phòng mạch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem i_Account;
        private System.Windows.Forms.ToolStripMenuItem i_BenhNhan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem i_ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem i_Admin;
        private System.Windows.Forms.ToolStripMenuItem i_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem i_TaiKhoanQL;
        private System.Windows.Forms.ToolStripMenuItem i_BacSi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ststrThoiGian;
        private System.Windows.Forms.ToolStripMenuItem i_Thuoc;
        public System.Windows.Forms.ToolStripStatusLabel ststrTrangThai;
        private System.Windows.Forms.ToolStripMenuItem i_XemLog;
        private System.Windows.Forms.ToolStripMenuItem i_LogForm;
        private System.Windows.Forms.ToolStripMenuItem i_LogButton;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem i_DuLieu;
        private System.Windows.Forms.ToolStripMenuItem i_SaoLuu;
        private System.Windows.Forms.ToolStripMenuItem i_PhucHoi;
        private System.Windows.Forms.ToolStripMenuItem i_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem i_QLBacSi;
        private System.Windows.Forms.ToolStripMenuItem i_LuongBacSi;
        private System.Windows.Forms.ToolStripMenuItem i_QLBenhNhan;
        public System.Windows.Forms.ToolStripMenuItem i_DangXuat;
    }
}