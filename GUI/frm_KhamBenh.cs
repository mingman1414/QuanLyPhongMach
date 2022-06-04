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
    public partial class frm_KhamBenh : Form
    {
        public frm_KhamBenh()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Khám Bệnh.");
        }

        public static BacSi_DTO BacSi;
        public static Thuoc_DTO Thuoc;
        public static DonThuoc_DTO Don;

        private void frm_KhamBenh_Load(object sender, EventArgs e)
        {
            AutoPhieu();
            Auto();
            txtBacSi.Text = frm_Login.Account.TenHienThi;
            frm_BenhNhan f1 = new frm_BenhNhan();
            HienThiDSPhieuKham();
            HienListTrong();
            rp_DonThuoc.Visible = false;
            btnDongDonThuoc.Visible = false;
            btnLapDonThuoc.Enabled = false;
            rp_HoaDon.Visible = false;
            btnInHoaDon.Enabled = false;
            btnDongHoaDon.Visible = false;
            
        }





        private void HienThiDSPhieuKham()
        {
            List<PhieuKham_DTO> lstPhieuKham = PhieuKham_BUS.LayDSPhieuKham();
            dgvPhieuKham.DataSource = lstPhieuKham;
            dgvPhieuKham.Columns["MaPhieuKham"].HeaderText = "Mã phiếu khám";
            dgvPhieuKham.Columns["NgayKham"].HeaderText = "Ngày khám";
            dgvPhieuKham.Columns["BenhNhan"].HeaderText = "Bệnh nhân";
            dgvPhieuKham.Columns["BacSi"].HeaderText = "Bác sĩ";
            dgvPhieuKham.Columns["IdPhieuKham"].Visible = false;
            dgvPhieuKham.Columns["IdBenhNhan"].Visible = false;
            dgvPhieuKham.Columns["IdBacSi"].Visible = false;
            dgvPhieuKham.Columns["TrieuChung"].Visible = false;
            dgvPhieuKham.Columns["ChuanDoan"].Visible = false;
            dgvPhieuKham.Columns["GhiChu"].Visible = false;
            dgvPhieuKham.Columns["ThanhTien"].Visible = false;

            dgvPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPhieuKham_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvPhieuKham.SelectedRows[0];
            txtMaPhieuKham.Text = dr.Cells["MaPhieuKham"].Value.ToString();
            txtBenhNhan.Text = dr.Cells["BenhNhan"].Value.ToString();
            dtNgayKham.Text = dr.Cells["NgayKham"].Value.ToString();
            dgvPhieuKham.Columns["NgayKham"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            txtBacSi.Text = dr.Cells["BacSi"].Value.ToString();
            txtTrieuChung.Text = dr.Cells["TrieuChung"].Value.ToString();
            txtChuanDoan.Text = dr.Cells["ChuanDoan"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();
            txtIdPhieu.Text = dr.Cells["IdPhieuKham"].Value.ToString();

            btnXoaPhieu.Enabled = true;
            var a = new WriteLog();
            a.ButtonWrite("Xem thông tin khám bệnh của bệnh nhân " + dr.Cells["BenhNhan"].Value.ToString());
            HienThiDonThuoc();
            btnInHoaDon.Enabled = true;
            btnLapDonThuoc.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuKham_DTO ph = new PhieuKham_DTO();
            ph.IdBenhNhan = int.Parse(txtIdBenhNhan.Text);
            ph.NgayKham = DateTime.Now;
            ph.TrieuChung = txtTrieuChung.Text;
            ph.ChuanDoan = txtChuanDoan.Text;
            frm_Login f = new frm_Login();
            BacSi = new BacSi_DTO();
            BacSi = BacSi_BUS.LayIdBacSi(frm_Login.Account.TenHienThi);
            ph.IdBacSi = BacSi.IdBacSi;
            ph.GhiChu = txtGhiChu.Text;
            ph.ThanhTien = 0;

            DialogResult rs= MessageBox.Show("Bạn có muốn thêm phiếu khám vào cơ sở dữu liệu:\nBệnh nhân: "+txtBenhNhan.Text+"\nBác sĩ khám: "+txtBacSi.Text,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (PhieuKham_BUS.ThemPhieuKham(ph) == false)
                {
                    MessageBox.Show("Không thêm được.", "Thông báo");
                    return;
                }

                HienThiDSPhieuKham();
                MessageBox.Show("Đã thêm phiếu khám.", "Thông báo");
                var a = new WriteLog();
                a.ButtonWrite("Thêm thông tin khám bệnh vào CSDL.");
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuKham_DTO ph = new PhieuKham_DTO();
            ph.MaPhieuKham = txtMaPhieuKham.Text;
            if (PhieuKham_BUS.XoaPhieuKham(ph) == true)
            {
                HienThiDSPhieuKham();
                MessageBox.Show("Đã xóa phiếu khám.");
                var a = new WriteLog();
                a.ButtonWrite("Xóa thông tin khám bệnh.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void Auto()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<Thuoc_DTO> lstThuoc = Thuoc_BUS.LayDSThuoc();
            if(lstThuoc.Count>0)
            {
                for(int i=0;i<lstThuoc.Count;i++)
                {
                    coll.Add(lstThuoc[i].TenThuoc);
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            txtTenThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenThuoc.AutoCompleteCustomSource = coll;
        }

        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text != null)
            {
                Thuoc = Thuoc_BUS.LayTenThuoc(txtTenThuoc.Text);
                txtDVT.Text = Thuoc.DonVi.ToString();
                txtMaThuoc.Text = Thuoc.MaThuoc.ToString();
            }
        }

        private void HienThiDonThuoc()
        {
            lstDonThuoc.Items.Clear();
            int s = int.Parse(txtIdPhieu.Text);
            List<DonThuoc_DTO> Don = DonThuoc_BUS.LayDonThuoc(s);
            if (Don != null)
            {
                int TienThuoc = 0;
                foreach (DonThuoc_DTO item in Don)
                {
                    ListViewItem lstDonItem = new ListViewItem(item.MaThuoc);
                    lstDonItem.SubItems.Add(item.TenThuoc.ToString());
                    lstDonItem.SubItems.Add(item.CachDung.ToString());
                    lstDonItem.SubItems.Add(item.SLSang.ToString());
                    lstDonItem.SubItems.Add(item.SLTrua.ToString());
                    lstDonItem.SubItems.Add(item.SLChieu.ToString());
                    lstDonItem.SubItems.Add(item.SLToi.ToString());
                    lstDonItem.SubItems.Add(item.TongTien.ToString());
                    TienThuoc += item.TongTien;
                    lstDonThuoc.Items.Add(lstDonItem);
                }
                txtGiaTien.Text = TienThuoc.ToString();
            }
            
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            DonThuoc_DTO d = new DonThuoc_DTO();
            d.MaThuoc = txtMaThuoc.Text;
            d.IdDonThuoc = int.Parse(txtIdPhieu.Text);

            if (DonThuoc_BUS.XoaThuoc(d) == true)
            {
                HienThiDonThuoc();
                MessageBox.Show("Đã xóa thuốc.");
                var a = new WriteLog();
                a.ButtonWrite("Xóa thuốc khỏi đơn.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }

        }

        

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            DonThuoc_DTO d = new DonThuoc_DTO();
            d.IdDonThuoc = int.Parse(txtIdPhieu.Text);
            d.MaThuoc = txtMaThuoc.Text;
            d.CachDung = txtCachDung.Text;
            d.SLSang = int.Parse(udSang.Value.ToString());
            d.SLTrua = int.Parse(udTrua.Value.ToString());
            d.SLChieu = int.Parse(udChieu.Value.ToString());
            d.SLToi = int.Parse(udToi.Value.ToString());

            if (DonThuoc_BUS.ThemThuoc(d) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDonThuoc();
            MessageBox.Show("Đã thêm thuốc.", "Thông báo");
            var a = new WriteLog();
            a.ButtonWrite("Thêm thuốc vào đơn.");
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            DonThuoc_DTO d = new DonThuoc_DTO();
            d.IdDonThuoc = int.Parse(txtIdPhieu.Text);
            d.MaThuoc = txtMaThuoc.Text;
            d.CachDung = txtCachDung.Text;
            d.SLSang = int.Parse(udSang.Value.ToString());
            d.SLTrua = int.Parse(udTrua.Value.ToString());
            d.SLChieu = int.Parse(udChieu.Value.ToString());
            d.SLToi = int.Parse(udToi.Value.ToString());


            if (DonThuoc_BUS.SuaThuoc(d) == true)
            {
                HienThiDonThuoc();
                MessageBox.Show("Đã cập nhật thông tin thuốc.");
                var a = new WriteLog();
                a.ButtonWrite("Thay đổi thông tin thuốc trong đơn.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }

            
        }
        private void HienListTrong()
        {
            lstDonThuoc.Columns.Add("Ma thuốc", 122);
            lstDonThuoc.Columns.Add("Tên thuốc",122);
            lstDonThuoc.Columns.Add("Cách dùng",122);
            lstDonThuoc.Columns.Add("Sáng",50);
            lstDonThuoc.Columns.Add("Trưa",50);
            lstDonThuoc.Columns.Add("Chiều",50);
            lstDonThuoc.Columns.Add("Tối",50);
        }

        private void lstDonThuoc_Click(object sender, EventArgs e)
        {
            txtMaThuoc.Text = lstDonThuoc.SelectedItems[0].SubItems[0].Text;
            txtTenThuoc.Text = lstDonThuoc.SelectedItems[0].SubItems[1].Text;
            txtCachDung.Text = lstDonThuoc.SelectedItems[0].SubItems[2].Text;
            udSang.Text = lstDonThuoc.SelectedItems[0].SubItems[3].Text;
            udTrua.Text = lstDonThuoc.SelectedItems[0].SubItems[4].Text;
            udChieu.Text = lstDonThuoc.SelectedItems[0].SubItems[5].Text;
            udToi.Text = lstDonThuoc.SelectedItems[0].SubItems[6].Text;
        }

        private void frm_KhamBenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Khám Bệnh.");
        }

        private void btnLapDonThuoc_Click(object sender, EventArgs e)
        {
            btnDongDonThuoc.Visible = true;
            rp_DonThuoc.Visible = true;
            this.LapDonThuocTableAdapter.Fill(this.QLPMDataSet.LapDonThuoc, int.Parse(txtIdPhieu.Text));
            this.rp_DonThuoc.RefreshReport();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            PhieuKham_DTO ph = new PhieuKham_DTO();
            ph.IdPhieuKham = int.Parse(txtIdPhieu.Text);
            ph.ThanhTien = int.Parse(txtGiaTien.Text);
            PhieuKham_BUS.CongTien(ph);
            btnDongHoaDon.Visible = true;
            rp_HoaDon.Visible = true;
            this.HoaDonTableAdapter.Fill(this.QLPMDataSet1.HoaDon, int.Parse(txtIdPhieu.Text));
            this.TongTienTableAdapter.Fill(this.QLPMDataSet2.TongTien, int.Parse(txtIdPhieu.Text));
            this.rp_HoaDon.RefreshReport();
        }


        private void bntHienGrid_Click(object sender, EventArgs e)
        {
            btnDongDonThuoc.Visible = false;
            rp_DonThuoc.Visible = false;
            btnDongHoaDon.Visible = false;
            rp_HoaDon.Visible = false;
        }

        private void btnDongDonThuoc_Click(object sender, EventArgs e)
        {
            btnDongDonThuoc.Visible = false;
            rp_DonThuoc.Visible = false;
        }

        private void btnDongHoaDon_Click(object sender, EventArgs e)
        {
            btnDongHoaDon.Visible = false;
            rp_HoaDon.Visible = false;
        }

        private void AutoPhieu()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<BenhNhan_DTO> lstBenhNhan = BenhNhan_BUS.LayDSBenhNhan();
            if (lstBenhNhan.Count > 0)
            {
                for (int i = 0; i < lstBenhNhan.Count; i++)
                {
                    coll.Add(lstBenhNhan[i].HoLot + " " + lstBenhNhan[i].TenBN);
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            txtTimPhieuKham.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimPhieuKham.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimPhieuKham.AutoCompleteCustomSource = coll;
        }

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            List<PhieuKham_DTO> lstBenhNhan = PhieuKham_BUS.LayPhieuKham(txtTimPhieuKham.Text);
            dgvPhieuKham.DataSource = lstBenhNhan;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuKham();
        }
    }
}
