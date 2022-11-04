using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScMaSy_ice.Components;

namespace ScMaSy_ice
{
    public partial class AboutUsView : Form
    {
        public AboutUsView()
        {
            InitializeComponent();
        }

        private void closeFm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_center_top_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
