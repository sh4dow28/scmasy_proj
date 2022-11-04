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
    public partial class UsersView : Form
    {
        public UsersView()
        {
            InitializeComponent();
        }

        private void openCreateUserFm(object sender, EventArgs e)
        {
            // Ouvrire le formulaire de création d'utilisateur
            FM_AddOrEditUser _AddOrEditUserFM = new FM_AddOrEditUser("create");
            _AddOrEditUserFM.ShowDialog();
        }

        private void openEditUserFm(object sender, EventArgs e)
        {
            // Ouvrire le formulaire de création d'utilisateur en mode update
            FM_AddOrEditUser _AddOrEditUserFM = new FM_AddOrEditUser("update");
            _AddOrEditUserFM.ShowDialog();
        }

        private void printUserList(object sender, EventArgs e)
        {
            // Code pour imprimer la liste des utilisateurs
        }

        private void refreshUserList(object sender, EventArgs e)
        {
            // Code pour actualiser la liste des utilisateur
        }
    }
}
