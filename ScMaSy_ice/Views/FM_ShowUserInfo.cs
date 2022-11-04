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
    public partial class FM_ShowUserInfo : Form
    {
        public FM_ShowUserInfo(string _code, string _lastname, string _firstname, string _username, string _group, string _status="Actif")
        {
            InitializeComponent();
            lbl_code.Text = _code;
            lbl_lastname.Text = _lastname;
            lbl_firstname.Text = _firstname;
            lbl_username.Text = _username;
            lbl_group.Text = _group;
            lbl_status.Text = _status;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FM_ShowUserInfo_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            // Ouvrire formulaire pour mise à jour des informations de l'utilisateur
            FM_AddOrEditUser _AddOrEditUserFM = new FM_AddOrEditUser("update", lbl_code.Text);
            this.Close();
        }
    }
}
