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
    public partial class FM_AddOrEditClassroomView : KryptonForm
    {
        public FM_AddOrEditClassroomView(String CreateOrUpdate="update")
        {
            InitializeComponent();
            if(CreateOrUpdate != null)
            {
                if(CreateOrUpdate == "create")
                {
                    klabel_title.Text = "nouvelle classe".ToUpper();
                }
                else if(CreateOrUpdate == "update")
                {
                    klabel_title.Text = "modification d'une classe".ToUpper();
                }
            }
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            if(InputNotEmpty() != null)
            {
                if(MessageBox.Show("Voulez-vous vraiment quitter ?", "ScMaSy - Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private String InputNotEmpty()
        {
            if (kcbx_cycle.SelectedItem != null)
            {
                return "Cycle";
            }
            if (!string.IsNullOrEmpty(ktbx_nom.Text))
            {
                return "Nom de la classe";
            }
            if (!string.IsNullOrEmpty(ktbx_reg_fees.Text))
            {
                return "Montant de l'inscription";
            }
            if (!string.IsNullOrEmpty(ktbx_re_reg_fees.Text))
            {
                return "Montant de la reinscription";
            }
            if (!string.IsNullOrEmpty(ktbx_tuition.Text))
            {
                return "Montant de l'écolage";
            }
            return null;
        }
        private void openSectionForm(object sender, EventArgs e)
        {
            FM_AddOrEditClassroomSection _AddOrUpdateClassroomSection = new FM_AddOrEditClassroomSection();
            _AddOrUpdateClassroomSection.ShowDialog();
        }

        private void ktbx_reg_fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFunctions.OnlyNumeric(e);
        }

        private void ktbx_re_reg_fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFunctions.OnlyNumeric(e);
        }

        private void ktbx_tuition_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFunctions.OnlyNumeric(e);
        }

        private void kryptonCommand1_Execute(object sender, EventArgs e)
        {
            if(kcbx_cycle.SelectedIndex > -1)
            {
                if(ktbx_nom.Text != "")
                {
                    if(kcbx_previou_class.SelectedIndex > -1)
                    {
                        if(ktbx_reg_fees.Text != "")
                        {
                            if (ktbx_re_reg_fees.Text != "")
                            {
                                if (ktbx_tuition.Text != "")
                                {
                                    // Code save classe
                                    if(kdbtn_submit.Values.Text != "Enregistrer et Continuer") { this.Close();  }
                                }
                                else
                                {
                                    MessageBox.Show("Vous devez saisir le montant de la scolarité !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ktbx_tuition.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vous devez saisir le montant de la réinscription !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ktbx_re_reg_fees.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vous devez saisir le montant de l'inscription !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ktbx_reg_fees.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez préciser la classe précédente !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kcbx_previou_class.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez entrer le nom de la classe !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ktbx_nom.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner le cycle !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kcbx_cycle.Focus();
            }
            
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
