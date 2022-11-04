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
    public partial class FM_RelationBetweenClassroom : KryptonForm
    {
        public FM_RelationBetweenClassroom()
        {
            InitializeComponent();
            kdgv_list.Rows.Add("CI", "CP");
            kdgv_list.Rows.Add("CP", "CE1");
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kbtn_save_Click(object sender, EventArgs e)
        {
            if((kcbx_firstclass.SelectedIndex > -1)&& (kcbx_secondclass.SelectedIndex > -1))
            {
                // Code pour sauvegarder
            }
            else
            {
                MessageBox.Show("Veillez renseigner tout les champs !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
