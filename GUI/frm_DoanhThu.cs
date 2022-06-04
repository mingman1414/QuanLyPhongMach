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
    public partial class frm_DoanhThu : DockContent
    {
        public frm_DoanhThu()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Doanh Thu.");
        }

        private void frm_DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = new WriteLog();
            a.FormWrite("Đóng form Doanh Thu.");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("tuNgay",dtTuNgay.Value.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("toiNgay",dtDenNgay.Value.ToString())
            };
            reportViewer1.LocalReport.SetParameters(param);
            this.ThongKeHoaDonTableAdapter.Fill(this.QLPMDataSet3.ThongKeHoaDon, dtTuNgay.Value, dtDenNgay.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
