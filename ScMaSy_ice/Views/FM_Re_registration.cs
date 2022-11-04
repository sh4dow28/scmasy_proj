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
    public partial class FM_Re_registration : Form
    {
        public FM_Re_registration()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klabel_frm_title_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void kcb_readoublant_CheckedChanged(object sender, EventArgs e)
        {
            kcb_passant.Checked = !kcb_readoublant.Checked;
            kcb_readoublant.Checked = !kcb_passant.Checked;
        }

        private void kcb_passant_CheckedChanged(object sender, EventArgs e)
        {
            kcb_readoublant.Checked = !kcb_passant.Checked;
            kcb_passant.Checked = !kcb_readoublant.Checked;
        }

        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kbtn_reregistration_Click(object sender, EventArgs e)
        {
            // Réinscription
            if (CheckFields() == true)
            {
                MessageBox.Show("En cliquant sur ce boutton vous êtes sur le point d'inscrire l'apprenant sans les frais de réinscription pour le moment !", "ScMaSy - Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(MessageBox.Show("Voulez-vous continuer ?", "ScMaSy - Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Enregistrer le réinscription
                }
            }
        }

        private void kbtn_payment_Click(object sender, EventArgs e)
        {
            // Paiement
            if (CheckFields() == true)
            {
                // Hint - Passer des infos en parametres pour le paiement serait bien je crois...
                FM_Payment _PaymentFM = new FM_Payment();
                _PaymentFM.ShowDialog();
            }
        }

        bool CheckFields()
        {
            if(kcbx_academicyear.SelectedIndex > -1)
            {
                if(kcbx_previousclass.SelectedIndex > -1)
                {
                    if (kcbx_newclass.SelectedIndex > -1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Choisir la nouvelle classe !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kcbx_newclass.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Choisir l'ancienne classe !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kcbx_previousclass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Choisir l'année académique concernée !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kcbx_academicyear.Focus();
                return false;
            }
        }
    }
}
