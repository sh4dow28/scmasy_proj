using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;

using System.Globalization;
using ScMaSy_ice.Components;
using ScMaSy_ice.Models;

namespace ScMaSy_ice
{
    public partial class FM_Main: Form
    {
        private Form currentChildForm;
        public MUsers CurrentUser;
        public FM_Main()
        {
            InitializeComponent();
            klabel_username.Text = "Fake Text";

            klabel_date.Text = DateTime.Now.ToString("dddd dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR")) + " - " + DateTime.Now.ToString("HH: mm: ss", CultureInfo.CreateSpecificCulture("fr-FR"));
            timer_date.Start();
            // this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            klabel_current_academiqu_year.Text = DateTime.Now.Year + " - " + (DateTime.Now.Year + 1);

            // Quick Search form
            ktbx_quicksearch.Text = "Entrez le matricule ou le nom de l'apprenant...";
            ktbx_quicksearch.StateCommon.Content.Color1 = Color.DarkGray;
        }
        public FM_Main(MUsers AUser)
        {
            InitializeComponent();

            klabel_username.Text = AUser.us_name;

            klabel_date.Text = DateTime.Now.ToString("dddd dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR")) + " - " + DateTime.Now.ToString("HH: mm: ss", CultureInfo.CreateSpecificCulture("fr-FR"));
            timer_date.Start();
            // this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            klabel_current_academiqu_year.Text = DateTime.Now.Year + " - " + (DateTime.Now.Year + 1);

            // Quick Search form
            ktbx_quicksearch.Text = "Entrez le matricule ou le nom de l'apprenant...";
            ktbx_quicksearch.StateCommon.Content.Color1 = Color.DarkGray;

        }

        private void Shut(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnlargeOrRestore(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void showOrHideNav(object sender, EventArgs e)
        {
            // knav_left.Visible = !knav_left.Visible;
            kpnl_left.Visible = !kpnl_left.Visible;
        }
        private void kpnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void klabel_date_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void timer_date_Tick(object sender, EventArgs e)
        {
            klabel_date.Text = DateTime.Now.ToString("dddd dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR")) + " - " + DateTime.Now.ToString("HH: mm: ss", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.ClassroomView());
        }
        private void openSchoolInfo(object sender, EventArgs e)
        {
            Views.SchoolConfigView fm_schoolInfo=new Views.SchoolConfigView();
            fm_schoolInfo.ShowDialog();
        }

        private void informationSurLétablissementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.SchoolConfigView fm_schoolInfo = new Views.SchoolConfigView();
            fm_schoolInfo.ShowDialog();
        }

        private void cyclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_AddOrEditClassroomSection classroomSection = new Views.FM_AddOrEditClassroomSection();
            classroomSection.ShowDialog();
        }

        private void FM_Main_Resize(object sender, EventArgs e)
        {
            //if(currentChildForm == null){MessageBox.Show("null");}
        }

        private void matièresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_Courses _Courses = new Views.FM_Courses();
            _Courses.ShowDialog();
        }

        private void afficherLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrire la liste des utilisateur
            OpenChildForm(new Views.UsersView());
        }
        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }
        private void OpenChildForm(Form childForm)
        {
            //close form who is open
            CloseChildForm();
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            kpnl_main.Controls.Add(childForm);
            kpnl_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void ktbx_quicksearch_Enter(object sender, EventArgs e)
        {
            if(ktbx_quicksearch.Text == "Entrez le matricule ou le nom de l'apprenant...")
            {
                ktbx_quicksearch.Text = "";
                ktbx_quicksearch.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ktbx_quicksearch_Leave(object sender, EventArgs e)
        {
            if (ktbx_quicksearch.Text == "")
            {
                ktbx_quicksearch.Text = "Entrez le matricule ou le nom de l'apprenant...";
                ktbx_quicksearch.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void kbtn_seach_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ktbx_quicksearch.Text) || ktbx_quicksearch.Text == "Entrez le matricule ou le nom de l'apprenant...")
            {
                KryptonMessageBox.Show("Vous devez saisi un matricule ou un nom d'élève");
            }
            else
            {
                if (ControlFunctions.CheckIfContainNumner(ktbx_quicksearch.Text))
                {
                    // Code pour recherche par matricule de l'apprenant
                    MessageBox.Show("Recherche par Matricule");
                }
                else
                {
                    // Code pour recherche par nom de l'apprenant
                    MessageBox.Show("Recherche par Noms");
                }
            }
        }

        

        private void elèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrire formulaire apprenants comme childForm
            


        }

        private void aProposDeNousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrire popup a propos
            AboutUsView aboutUsView = new AboutUsView();
            aboutUsView.ShowDialog();
        }

        private void annéeScolaireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Ouvrire popup creation d'anné scolaire
            Views.FM_NewAcademicYear _NewAcademicYear = new Views.FM_NewAcademicYear();
            _NewAcademicYear.ShowDialog();
        }

        private void aideSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.HelpAndSupport _HelpAndSupport = new Views.HelpAndSupport();
            _HelpAndSupport.ShowDialog();
        }

        private void quitterLeSystèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment quitter le logiciel ?", "ScMaSy - Demande de Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_Registration _RegistrationFM = new Views.FM_Registration();
            _RegistrationFM.ShowDialog();
        }

        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_AddOrEditUser _AddOrEditUserFM = new Views.FM_AddOrEditUser();
            _AddOrEditUserFM.ShowDialog();
        }

        private void réinscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_Re_registration _Re_RegistrationFM = new Views.FM_Re_registration();
            _Re_RegistrationFM.ShowDialog();
        }

        private void listeDesElèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.StudentView());
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Views.FM_ShowUserInfo _ShowUserInfoFM = new Views.FM_ShowUserInfo();
            //_ShowUserInfoFM.ShowDialog();
        }

        private void groupesDutilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.UserGroupConfig userGroupConfigFM = new Views.UserGroupConfig();
            OpenChildForm(userGroupConfigFM);
        }

        private void vérouillerLeSystèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Views.LoginView _LoginViewFM = new Views.LoginView();
            _LoginViewFM.Show();
        }

        private void historisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.SystemHistory());
        }

        private void ajouterUnEnseignantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.FM_AddOrUpdateTeacher _AddOrUpdateTeacherFM = new Views.FM_AddOrUpdateTeacher();
            _AddOrUpdateTeacherFM.ShowDialog();
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            Views.FM_Registration _RegistrationFM = new Views.FM_Registration();
            _RegistrationFM.ShowDialog();
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            Views.FM_Re_registration _Re_RegistrationFM = new Views.FM_Re_registration();
            _Re_RegistrationFM.ShowDialog();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.StudentView());
        }

        private void kryptonButton15_Click(object sender, EventArgs e)
        {
            Views.FM_AddOrUpdateTeacher _AddOrUpdateTeacherFM = new Views.FM_AddOrUpdateTeacher();
            _AddOrUpdateTeacherFM.ShowDialog();
        }

        private void kryptonButton17_Click(object sender, EventArgs e)
        {
            Views.FM_Payment _PaymentFM = new Views.FM_Payment();
            _PaymentFM.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Views.FM_AddOrEditUser _AddOrEditUserFM = new Views.FM_AddOrEditUser();
            _AddOrEditUserFM.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Views.UserGroupConfig userGroupConfigFM = new Views.UserGroupConfig();
            OpenChildForm(userGroupConfigFM);
        }

        private void kryptonButton21_Click(object sender, EventArgs e)
        {
            Views.SchoolConfigView fm_schoolInfo = new Views.SchoolConfigView();
            fm_schoolInfo.ShowDialog();
        }

        private void kryptonButton19_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.ClassroomView());
        }

        private void kryptonButton18_Click(object sender, EventArgs e)
        {
            Views.FM_Courses _Courses = new Views.FM_Courses();
            _Courses.ShowDialog();
        }
    }
}
