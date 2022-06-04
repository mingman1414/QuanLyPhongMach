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
    public partial class frm_BenhNhan : DockContent
    {
        public frm_BenhNhan()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Bệnh Nhân.");
        }

       // public static BenhNhan_DTO BenhNhan;

        private void frm_BenhNhan_Load(object sender, EventArgs e)
        {
            HienThiDSBenhNhan();
            Auto();
        }

        private void HienThiDSBenhNhan()
        {
            List<BenhNhan_DTO> lstBenhNhan = BenhNhan_BUS.LayDSBenhNhan();
            dgvBenhNhan.DataSource = lstBenhNhan;
            dgvBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã bệnh nhân";
            dgvBenhNhan.Columns["HoLot"].HeaderText = "Họ lót";
            dgvBenhNhan.Columns["TenBN"].HeaderText = "Tên";
            dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvBenhNhan.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBenhNhan.Columns["IdBenhNhan"].Visible = false;
            dgvBenhNhan.Columns["DiaChi"].Visible = false;
            dgvBenhNhan.Columns["DiaChi"].Visible = false;
            dgvBenhNhan.Columns["GhiChu"].Visible = false; 

            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvBenhNhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvBenhNhan.SelectedRows[0];
            txtIdBenhNhan.Text = dr.Cells["IdBenhNhan"].Value.ToString();
            txtMaBN.Text = dr.Cells["MaBenhNhan"].Value.ToString();
            txtHoLot.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenBN.Text = dr.Cells["TenBN"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radBNNam.Checked = true;
            }
            else
            {
                radNuBN.Checked = true;
            }
            dtNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtLienHe.Text = dr.Cells["DiaChi"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();

            btnKham.Enabled = true;
            btnXoa.Enabled = true;
            var a = new WriteLog();
            a.ButtonWrite("Xem thông tin bệnh nhân " + dr.Cells["HoLot"].Value.ToString() + " " + dr.Cells["TenBN"].Value.ToString());
        }

        

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            // Kiem tra trong
            if (txtHoLot.Text == "" || txtTenBN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            BenhNhan_DTO bn = new BenhNhan_DTO();
            bn.HoLot = txtHoLot.Text;
            bn.TenBN = txtTenBN.Text;
            if (radBNNam.Checked == true)
            {
                bn.GioiTinh = "Nam";
            }
            else
            {
                bn.GioiTinh = "Nữ";
            }
            bn.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            bn.DiaChi = txtDiaChi.Text;
            bn.LienHe = txtLienHe.Text;
            bn.Ghichu = txtGhiChu.Text;

            if (BenhNhan_BUS.ThemBenhNhan(bn) == false)
            {
                MessageBox.Show("Không thêm được.","Thông báo");
                return;
            }

            HienThiDSBenhNhan();
            MessageBox.Show("Đã thêm bệnh nhân.","Thông báo");
            var a = new WriteLog();
            a.ButtonWrite("Thêm bệnh nhân " + txtHoLot.Text + " " + txtTenBN.Text);
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            BenhNhan_DTO bn = new BenhNhan_DTO();
            bn.MaBenhNhan = txtMaBN.Text;
            bn.HoLot = txtHoLot.Text;
            bn.TenBN = txtTenBN.Text;
            if (radBNNam.Checked == true)
            {
                bn.GioiTinh = "Nam";
            }
            else
            {
                bn.GioiTinh = "Nữ";
            }
            bn.NgaySinh = DateTime.Parse(dtNgaySinh.Text);
            bn.DiaChi = txtDiaChi.Text;
            bn.LienHe = txtLienHe.Text;
            bn.Ghichu = txtGhiChu.Text;
            
            if (BenhNhan_BUS.SuaBenhNhan(bn) == true)
            {
                HienThiDSBenhNhan();
                MessageBox.Show("Đã cập nhật thông tin bệnh nhân.");
                var a = new WriteLog();
                a.ButtonWrite("Sửa thông tin bệnh nhân " + txtHoLot.Text + " " + txtTenBN.Text);
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BenhNhan_DTO bn = new BenhNhan_DTO();
            bn.MaBenhNhan = txtMaBN.Text;
            
            if (BenhNhan_BUS.XoaBenhNhan(bn) == true)
            {
                HienThiDSBenhNhan();
                MessageBox.Show("Đã xóa bệnh nhân.");
                var a = new WriteLog();
                a.ButtonWrite("Xóa bệnh nhân " + txtHoLot.Text + " " + txtTenBN.Text);
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnKham_Click(object sender, EventArgs e)
        {
            frm_KhamBenh f = new frm_KhamBenh();
            //this.Hide();
            f.txtIdBenhNhan.Text = txtIdBenhNhan.Text;
            f.txtBenhNhan.Text = txtHoLot.Text + " " + txtTenBN.Text;
            f.ShowDialog();
            
            //this.Show();
        }

        private void frm_BenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Bệnh Nhân.");
        }

        private void Auto()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<BenhNhan_DTO> lstBenhNhan = BenhNhan_BUS.LayDSBenhNhan();
            if (lstBenhNhan.Count > 0)
            {
                for (int i = 0; i < lstBenhNhan.Count; i++)
                {
                    coll.Add(lstBenhNhan[i].HoLot + " "+lstBenhNhan[i].TenBN);
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            txtTimBN.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimBN.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimBN.AutoCompleteCustomSource = coll;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            HienThiDSBenhNhan();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<BenhNhan_DTO> lstBenhNhan = BenhNhan_BUS.LayBenhNhan(txtTimBN.Text);
            dgvBenhNhan.DataSource = lstBenhNhan;
        }
    }
}
