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
    public partial class frm_BacSi : DockContent
    {
        public frm_BacSi()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Bác Sĩ.");
        }

        private void frm_BacSi_Load(object sender, EventArgs e)
        {
            HienThiDSBacSi();
            Auto();
        }

        private void HienThiDSBacSi()
        {
            List<BacSi_DTO> lstBacSi = BacSi_BUS.LayDSBacSi();
            dgvBacSi.DataSource = lstBacSi;
            dgvBacSi.Columns["IdBacSi"].Visible = false;
            dgvBacSi.Columns["MaBacSi"].HeaderText = "Mã bác sĩ";
            dgvBacSi.Columns["HoLot"].HeaderText = "Họ lót";
            dgvBacSi.Columns["TenBS"].HeaderText = "Tên";
            dgvBacSi.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvBacSi.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvBacSi.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBacSi.Columns["DiaChi"].Visible = false;
            dgvBacSi.Columns["SDT"].Visible = false;
            dgvBacSi.Columns["Email"].Visible = false;
            dgvBacSi.Columns["HeSoLuong"].Visible = false;  

            dgvBacSi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvBacSi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvBacSi.SelectedRows[0];
            txtMaBS.Text = dr.Cells["MaBacSi"].Value.ToString();
            txtHoLotBS.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenBS.Text = dr.Cells["TenBS"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radBsNam.Checked = true;
            }
            else
            {
                radBsNu.Checked = true;
            }
            dtNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtsdt.Text = dr.Cells["SDT"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txthsluong.Text = dr.Cells["HeSoLuong"].Value.ToString();
            var a = new WriteLog();
            a.ButtonWrite("Xem thông tin bác sĩ "+ dr.Cells["HoLot"].Value.ToString()+" "+ dr.Cells["TenBS"].Value.ToString());
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtHoLotBS.Text == "" || txtTenBS.Text == "" || txtsdt.Text =="" || txtEmail.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            

            BacSi_DTO bs = new BacSi_DTO();
            bs.HoLot = txtHoLotBS.Text;
            bs.TenBS = txtTenBS.Text;
            if (radBsNam.Checked == true)
            {
                bs.GioiTinh = "Nam";
            }
            else
            {
                bs.GioiTinh = "Nữ";
            }
            bs.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            bs.DiaChi = txtDiaChi.Text;
            bs.SDT = txtsdt.Text;
            bs.Email = txtEmail.Text;
            bs.HeSoLuong = float.Parse(txthsluong.Text);

            if (BacSi_BUS.ThemBacSi(bs) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSBacSi();
            MessageBox.Show("Đã thêm bác sĩ.");
            var a = new WriteLog();
            a.ButtonWrite("Thêm bác sĩ " + txtHoLotBS.Text + " " + txtTenBS.Text);
        }

        private void btnSuaBS_Click(object sender, EventArgs e)
        {
            BacSi_DTO bs = new BacSi_DTO();
            bs.MaBacSi = txtMaBS.Text;
            bs.HoLot = txtHoLotBS.Text;
            bs.TenBS = txtTenBS.Text;
            if (radBsNam.Checked == true)
            {
                bs.GioiTinh = "Nam";
            }
            else
            {
                bs.GioiTinh = "Nữ";
            }
            bs.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            bs.DiaChi = txtDiaChi.Text;
            bs.SDT = txtsdt.Text;
            bs.Email = txtEmail.Text;
            bs.HeSoLuong = float.Parse(txthsluong.Text);

            if (BacSi_BUS.SuaBacSi(bs) == true)
            {
                HienThiDSBacSi();
                MessageBox.Show("Đã cập nhật thông tin bác sĩ.");
                var a = new WriteLog();
                a.ButtonWrite("Sửa thông tin bác sĩ " + txtHoLotBS.Text + " " + txtTenBS.Text);
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            BacSi_DTO bs = new BacSi_DTO();
            bs.MaBacSi = txtMaBS.Text;

            if (BacSi_BUS.XoaBacSi(bs) == true)
            {
                HienThiDSBacSi();
                MessageBox.Show("Đã xóa bác sĩ.");
                var a = new WriteLog();
                a.ButtonWrite("Xóa bác sĩ " + txtHoLotBS.Text + " " + txtTenBS.Text);
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void frm_BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Bác Sĩ.");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            HienThiDSBacSi();
        }

        private void btnTimBS_Click(object sender, EventArgs e)
        {
            List<BacSi_DTO> lstBacSi = BacSi_BUS.LayBacSi(txtTimBS.Text);
            dgvBacSi.DataSource = lstBacSi;
        }

        private void Auto()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<BacSi_DTO> lstBacSi = BacSi_BUS.LayBacSi(txtTimBS.Text);
            if (lstBacSi.Count > 0)
            {
                for (int i = 0; i < lstBacSi.Count; i++)
                {
                    coll.Add(lstBacSi[i].HoLot + " " + lstBacSi[i].TenBS);
                }
            }
            else
            {
                MessageBox.Show("Không có");
            }
            txtTimBS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimBS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimBS.AutoCompleteCustomSource = coll;
        }
    }
}
