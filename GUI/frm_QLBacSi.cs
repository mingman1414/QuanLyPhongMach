using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_QLBacSi : DockContent
    {
        public frm_QLBacSi()
        {
            InitializeComponent();
        }

        private void frm_QLBacSi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLPMDataSet4.QuanLiBacSi' table. You can move, or remove it, as needed.
            Auto();
        }

        private void Auto()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            List<BacSi_DTO> lstBS = BacSi_BUS.LayDSBacSi();
            if (lstBS.Count > 0)
            {
                for (int i = 0; i < lstBS.Count; i++)
                {
                    coll.Add(lstBS[i].HoLot+" "+lstBS[i].TenBS);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy.");
            }
            txtTenBS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenBS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenBS.AutoCompleteCustomSource = coll;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("TenBS",txtTenBS.Text),
                new Microsoft.Reporting.WinForms.ReportParameter("TuNgay",dtTuNgay.Value.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("ToiNgay",dtDenNgay.Value.ToString())
            };
            reportViewer1.LocalReport.SetParameters(param);
            this.QuanLiBacSiTableAdapter.Fill(this.QLPMDataSet4.QuanLiBacSi, txtTenBS.Text, dtTuNgay.Value, dtDenNgay.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
