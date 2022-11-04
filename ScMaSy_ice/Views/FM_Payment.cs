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
    public partial class FM_Payment : Form
    {
        public FM_Payment()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavePayment(object sender, EventArgs e)
        {
            // Code pour enregistrer le paiement ici
            if(kcbx_academic_year.SelectedIndex > -1)
            {
                if(kcbx_class.SelectedIndex > -1)
                {
                    if(kcbx_student.SelectedIndex > -1)
                    {
                        if(kcbx_reason.SelectedIndex > -1)
                        {
                            if(ktbx_paid_amount.Text != "")
                            {
                                double _paid_amount = Convert.ToDouble(ktbx_paid_amount.Text);
                                // Enregistrer Paiement
                                FM_PaymentResum _PaymentResumFM = new FM_PaymentResum(
                                    kcbx_academic_year.Text, 
                                    kcbx_class.Text, 
                                    kcbx_student.Text, 
                                    ktbx_paid_amount.Text, 
                                    kcbx_reason.Text, 
                                    "user009"
                                    );
                                _PaymentResumFM.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Veillez entrer le montant payé !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ktbx_paid_amount.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veillez selectionner la raison du payement !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kcbx_reason.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veillez selectionner un apprenants !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kcbx_student.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Veillez choisir la classe concernée !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kcbx_class.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veillez choisir l'année scolaire concernée !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kcbx_academic_year.Focus();
            }
        }

        private void ktbx_paid_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFunctions.OnlyNumeric(e);
        }

        private void klabel_frm_title_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
