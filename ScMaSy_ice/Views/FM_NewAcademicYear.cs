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
    public partial class FM_NewAcademicYear : Form
    {
        public FM_NewAcademicYear()
        {
            InitializeComponent();
            kdtp_end_date.Value=kdtp_start_date.Value.AddMonths(9);
            kmtbx_label.Text = kdtp_start_date.Value.Year.ToString() + kdtp_end_date.Value.Year.ToString();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code pour modifier une année scolaire
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code pour supprimer une année scolaire
        }

        private void createAcademicYear(object sender, EventArgs e)
        {
            string[] splitYearLabel = kmtbx_label.Text.Split('-');
            if((splitYearLabel[0] == kdtp_start_date.Value.Year.ToString()) && (splitYearLabel[1] == kdtp_end_date.Value.Year.ToString()))
            {
                // Code pour créer une année scolaire
                /*
                    - Verifier si l'année n'existe pas encore enregistrer 
                */
                kdgv_academic_year_list.Rows.Add(kmtbx_label.Text, kdtp_start_date.Value, kdtp_end_date.Value);
            }
            else
            {
                if (MessageBox.Show("L'intitulé est mal formulé. Voulez-vous que ScMaSy s'en charge pour vous ?", "ScMaSy - Erreur. Mauvais format", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kmtbx_label.Text = kdtp_start_date.Value.Year.ToString() + kdtp_end_date.Value.Year.ToString();
                    kbtn_create.PerformClick();
                }
                else
                {
                    MessageBox.Show("Veillez corrigé l'intitulé pour continuer.", "ScMaSy - Erreur. Mauvais format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kmtbx_label.Focus();
                }
            }
            
            
        }
        private void klabel_frm_title_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
