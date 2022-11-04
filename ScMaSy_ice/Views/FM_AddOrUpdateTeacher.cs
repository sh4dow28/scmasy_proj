using ScMaSy_ice.Components;
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
    public partial class FM_AddOrUpdateTeacher : Form
    {
        public FM_AddOrUpdateTeacher(string reason="create")
        {
            InitializeComponent();
            if (reason == "create")
            {
                klbl_title.Values.Text = "Enregistrer un enseignant";
            }
            else if(reason == "update")
            {
                klbl_title.Values.Text = "Modifier les informations d'un enseignant";
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klabel_frm_title_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
