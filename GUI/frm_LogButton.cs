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
    public partial class frm_LogButton : DockContent
    {
        public frm_LogButton()
        {
            InitializeComponent();

            var a = new WriteLog();
            a.FormWrite("Mở form Log Button.");
        }

        private void frm_LogButton_Load(object sender, EventArgs e)
        {
            string file = @"Button.log";
            System.IO.StreamReader r;
            r = new System.IO.StreamReader(file);
            txtLogButton.Text = r.ReadToEnd();
            r.Close();
        }
    }
}
