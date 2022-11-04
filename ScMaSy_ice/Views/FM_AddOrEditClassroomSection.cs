using ComponentFactory.Krypton.Toolkit;
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

namespace ScMaSy_ice.Views
{
    public partial class FM_AddOrEditClassroomSection : KryptonForm
    {
        public FM_AddOrEditClassroomSection()
        {
            InitializeComponent();
        }

        private void AddOrUpdateClassroomSection_Load(object sender, EventArgs e)
        {

        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
