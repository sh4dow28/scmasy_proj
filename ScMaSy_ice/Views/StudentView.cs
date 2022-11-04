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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
            kdgv_studentlist.Rows.Add("123-ST-2021", "KOKOU KUKUI", "Janvier Vincent");
        }

        private void openRegistrationF(object sender, EventArgs e)
        {
            // Ouvrire le formulaire d'inscription
            FM_Registration _RegistrationFM = new FM_Registration();
            _RegistrationFM.ShowDialog();
        }

        private void openReRegistrationFm(object sender, EventArgs e)
        {
            // Ouvrire le formulaire de réinscription
            FM_Re_registration _Re_RegistrationFM = new FM_Re_registration();
            _Re_RegistrationFM.ShowDialog();
        }

        private void openTuitionPaymentFm(object sender, EventArgs e)
        {
            // Ouvrire le formulaire de payement de scolarité
            string matricule = kdgv_studentlist.SelectedRows[0].Cells[0].Value.ToString();
            FM_Payment _PaymentFM = new FM_Payment();
            _PaymentFM.ShowDialog();
        }

        private void kbtn_studentinfo_Click(object sender, EventArgs e)
        {
            string matricule = kdgv_studentlist.SelectedRows[0].Cells[0].Value.ToString();
            FM_ShowStudentDetails _ShowStudentDetailsFM = new FM_ShowStudentDetails(matricule);
            _ShowStudentDetailsFM.ShowDialog();
        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            string studentname = kdgv_studentlist.SelectedRows[0].Cells[1].Value.ToString() + " " + kdgv_studentlist.SelectedRows[0].Cells[2].Value.ToString();

            if(MessageBox.Show("Voulez-vous vraiment supprimer l'apprenant "+studentname+" ?", "ScMaSy - Confirmation de suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Supprimer l'apprenant avec le matricule
                string ren = kdgv_studentlist.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show("le matricule " + ren + "");
            }
        }

        private void EditStudent(object sender, EventArgs e)
        {
            string ren = kdgv_studentlist.SelectedRows[0].Cells[0].Value.ToString();
            // Code pour modifier les information de l'apprenant.
        }
    }
}
