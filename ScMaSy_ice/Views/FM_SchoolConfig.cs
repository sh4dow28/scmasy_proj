using ComponentFactory.Krypton.Toolkit;
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
    public partial class FM_SchoolConfig : KryptonForm
    {
        public FM_SchoolConfig(string _reason="")
        {
            InitializeComponent();
            kcbx_period_system.SelectedIndex = 0;
            if(_reason == "")
            {
                klbl_title.Text = "Configurer les informations de l'établissement";
            }
            else if(_reason == "update")
            {
                klbl_title.Text = "Modifier les informations de l'établissement";
            }
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

        private void saveSchoolConfig(object sender, EventArgs e)
        {
            if(ktbx_name.Text != "")
            {
                if(ktbx_town.Text != "")
                {
                    if (ktbx_country.Text != "")
                    {
                        // Code pour sauvegarder les info de l'école
                    }
                    else
                    {
                        MessageBox.Show("Vous devez entrer le pays !", "ScMaSy - Erreur. Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ktbx_country.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez entrer la ville !", "ScMaSy - Erreur. Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ktbx_town.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez entrer le nom de votre établissement !", "ScMaSy - Erreur. Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktbx_name.Focus();
            }
        }
    }
}
