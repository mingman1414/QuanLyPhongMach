using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Flash : Form
    {
        public frm_Flash()
        {
            InitializeComponent();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            timerFade.Start();
            if (timerFade.Interval == 100)
            {
                if (this.Opacity > 0.0)
                    this.Opacity -= 0.025;
                else
                {
                    timerFade.Stop();
                    this.Dispose();
                }
            }
        }

    }
}
