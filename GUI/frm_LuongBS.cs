using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_LuongBS : DockContent
    {
        public frm_LuongBS()
        {
            InitializeComponent();
        }

        private void frm_LuongBS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLPMDataSet5.LuongBS' table. You can move, or remove it, as needed.
            this.LuongBSTableAdapter.Fill(this.QLPMDataSet5.LuongBS);

            this.reportViewer1.RefreshReport();
        }
    }
}
