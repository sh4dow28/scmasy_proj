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

namespace ScMaSy_ice.Views
{
    public partial class HelpAndSupport : KryptonForm
    {
        public HelpAndSupport()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
