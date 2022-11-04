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
    public partial class FM_Courses : Form
    {
        public FM_Courses()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void insertCourses(object sender, EventArgs e)
        {
            // Code pour créer une nouvelle matière ici
            if (ktbx_label.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Entrez l'intitulé(nom) de la matière !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ktbx_label.Focus();
            }
        }
        private void editCourses(object sender, EventArgs e)
        {
            // Code pour modifier une matière ici
        }

        private void deleteCourses(object sender, EventArgs e)
        {
            // Code pour supprimer une matière ici
        }

        private void printCoursesList(object sender, EventArgs e)
        {
            // Code pour imprimer la liste ici
        }
    }
}
