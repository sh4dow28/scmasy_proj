using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;
using ScMaSy_ice.Components;

namespace ScMaSy_ice.Views
{
    public partial class FM_AddOrEditUser : KryptonForm
    {
        public FM_AddOrEditUser(string openingMode="create", string userCode="")
        {
            InitializeComponent();

            if(openingMode == "create")
            {
                klabel_title.Values.Text = "Création d'Utilisateur";
                kbtn_create.Values.Text = "Créer";
            }else if(openingMode == "update")
            {
                klabel_title.Values.Text = "Mettre à jour un utilisateur";
                kbtn_create.Values.Text = "Modifier";
            }
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kpnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void krb_enable_CheckedChanged(object sender, EventArgs e)
        {
            krb_enable.Checked = !krb_diseable.Checked;
        }

        private void kbtn_create_Click(object sender, EventArgs e)
        {
            if(ktbx_lastname.Text != "")
            {
                if (ktbx_firstname.Text != "")
                {
                    if(ktbx_username.Text != "")
                    {
                        if (ktbx_pwd.Text != "")
                        {
                            if (ktbx_conf_pwd.Text != "")
                            {
                                if(ktbx_pwd.Text == ktbx_conf_pwd.Text)
                                {
                                    // Code for create user hier
                                    string _lastname = ktbx_lastname.Text;
                                    string _firstname = ktbx_firstname.Text;
                                    string _username = ktbx_username.Text;
                                    string _password = ktbx_pwd.Text;
                                    string _status = krb_enable.Checked ? "enable" : "disable";
                                }
                                else
                                {
                                    MessageBox.Show("Les mots de passe ne sont pas conforme !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ktbx_conf_pwd.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Confirmer votre mot de passe !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ktbx_conf_pwd.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Entrez un mot de passe !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ktbx_pwd.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez un nom d'utilisateur !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ktbx_username.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Entrez le prénom de l'utilisateur !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ktbx_firstname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Entrez le nom de l'utilisateur !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ktbx_lastname.Focus();
            }
        }
    }
}
