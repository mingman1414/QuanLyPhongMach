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
    public partial class frm_DsBenhNhan : DockContent
    {
        public frm_DsBenhNhan()
        {
            InitializeComponent();
        }

        private void frm_DsBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLPMDataSet6.DSBenhNhan' table. You can move, or remove it, as needed.
            this.DSBenhNhanTableAdapter.Fill(this.QLPMDataSet6.DSBenhNhan);

            this.reportViewer1.RefreshReport();
        }
    }
}
