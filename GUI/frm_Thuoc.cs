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
    public partial class frm_Thuoc : DockContent
    {
        public frm_Thuoc()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Thuốc.");
        }

        private void frm_Thuoc_Load(object sender, EventArgs e)
        {
            HienThiDSThuoc();
            Auto();
            cmbDonVi.Items.Add("Viên");
            cmbDonVi.Items.Add("Gói");
            cmbDonVi.Items.Add("Ống");
            cmbDonVi.Items.Add("Chai");
        }

        private void HienThiDSThuoc()
        {
            List<Thuoc_DTO> lstThuoc = Thuoc_BUS.LayDSThuoc();
            dgvThuoc.DataSource = lstThuoc;
            dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgvThuoc.Columns["DonVi"].HeaderText = "Đơn vị";
            dgvThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvThuoc.Columns["NSX"].HeaderText = "Ngày sản xuất";
            dgvThuoc.Columns["NSX"].DefaultCellStyle.Format = "dd/MM//yyyy";
            dgvThuoc.Columns["HSD"].HeaderText = "Hạn sử dụng";
            dgvThuoc.Columns["HSD"].DefaultCellStyle.Format = "dd/MM//yyyy";
            dgvThuoc.Columns["GiaThuoc"].HeaderText = "Giá";

            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvThuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvThuoc.SelectedRows[0];
            txtMaThuoc.Text = dr.Cells["MaThuoc"].Value.ToString();
            txtTenThuoc.Text = dr.Cells["TenThuoc"].Value.ToString();
            if (dr.Cells["DonVi"].Value.ToString() == "Viên")
                cmbDonVi.SelectedItem = "Viên";
            else if (dr.Cells["DonVi"].Value.ToString() == "Gói")
                cmbDonVi.SelectedItem = "Gói";
            else if (dr.Cells["DonVi"].Value.ToString() == "Ống")
                cmbDonVi.SelectedItem = "Ống";
            else cmbDonVi.SelectedItem = "Chai";
            //cmbDonVi.SelectedItem = dr.Cells["DonVi"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuong"].Value.ToString();
            dtNSX.Text = dr.Cells["NSX"].Value.ToString();
            dtHSD.Text = dr.Cells["HSD"].Value.ToString();
            txtGiaTien.Text = dr.Cells["GiaThuoc"].Value.ToString();
        }
        
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            // Kiem tra trong
            if (txtMaThuoc.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == "" || txtGiaTien.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            Thuoc_DTO th = new Thuoc_DTO();
            th.MaThuoc = txtMaThuoc.Text;
            th.TenThuoc = txtTenThuoc.Text;
            //th.DonVi = cmbDonVi.SelectedItem.ToString();
            if (cmbDonVi.SelectedItem.ToString() == "Viên")
                th.DonVi = "Viên";
            else if (cmbDonVi.SelectedItem.ToString() == "Gói")
                th.DonVi = "Gói";
            else if (cmbDonVi.SelectedItem.ToString() == "Ống")
                th.DonVi = "Ống";
            else th.DonVi = "Chai";
            th.SoLuong = int.Parse(txtSoLuong.Text);
            th.NSX = DateTime.Parse(dtNSX.Text);
            th.HSD = DateTime.Parse(dtHSD.Text);
            th.GiaThuoc = int.Parse(txtGiaTien.Text);

            if (Thuoc_BUS.ThemThuoc(th) == false)
            {
                MessageBox.Show("Không thêm được.", "Thông báo");
                return;
            }

            HienThiDSThuoc();
            MessageBox.Show("Đã thêm thuốc.", "Thông báo");
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            Thuoc_DTO th = new Thuoc_DTO();
            th.MaThuoc = txtMaThuoc.Text;
            th.TenThuoc = txtTenThuoc.Text;
            if (cmbDonVi.SelectedItem.ToString() == "Viên")
                th.DonVi = "Viên";
            else if (cmbDonVi.SelectedItem.ToString() == "Gói")
                th.DonVi = "Gói";
            else if (cmbDonVi.SelectedItem.ToString() == "Ống")
                th.DonVi = "Ống";
            else th.DonVi = "Chai";
            th.SoLuong = int.Parse(txtSoLuong.Text);
            th.NSX = DateTime.Parse(dtNSX.Text);
            th.HSD = DateTime.Parse(dtHSD.Text);
            th.GiaThuoc = int.Parse(txtGiaTien.Text);

            if (Thuoc_BUS.SuaThuoc(th) == true)
            {
                HienThiDSThuoc();
                MessageBox.Show("Đã cập nhật thông tin thuốc.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            Thuoc_DTO th = new Thuoc_DTO();
            th.MaThuoc = txtMaThuoc.Text;

            if (Thuoc_BUS.XoaThuoc(th) == true)
            {
                HienThiDSThuoc();
                MessageBox.Show("Đã xóa thuốc.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void frm_Thuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Thuốc.");
        }

        private void Auto()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<Thuoc_DTO> lstThuoc = Thuoc_BUS.LayThuoc(txtTimThuoc.Text);
            if (lstThuoc.Count > 0)
            {
                for (int i = 0; i < lstThuoc.Count; i++)
                {
                    coll.Add(lstThuoc[i].TenThuoc);
                }
            }
            else
            {
                MessageBox.Show("Không có");
            }
            txtTimThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimThuoc.AutoCompleteCustomSource = coll;
        }

        private void btnTimThuoc_Click(object sender, EventArgs e)
        {
            List<Thuoc_DTO> lstBenhNhan = Thuoc_BUS.LayThuoc(txtTimThuoc.Text);
            dgvThuoc.DataSource = lstBenhNhan;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSThuoc();
        }
    }
}
