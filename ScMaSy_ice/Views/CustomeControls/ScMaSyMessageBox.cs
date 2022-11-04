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

namespace ScMaSy_ice.Views.CustomeControls
{
    public partial class ScMaSyMessageBox : KryptonForm
    {
        public ScMaSyMessageBox()
        {
            InitializeComponent();
        }

        public static void CustomShow()
        {
            ScMaSyMessageBox scMaSyMessageBox = new ScMaSyMessageBox();
            scMaSyMessageBox.ShowDialog();
        }

        private void CloseBox(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
