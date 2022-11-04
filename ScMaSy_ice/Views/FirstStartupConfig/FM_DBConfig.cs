using ComponentFactory.Krypton.Toolkit;
using ScMaSy_ice.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScMaSy_ice.Views.FirstStartupConfig
{
    public partial class FM_DBConfig : KryptonForm
    {
        // string ProcName = System.AppDomain.CurrentDomain.FriendlyName.Replace(".exe", "");

        // int r = 0;        
        
        public FM_DBConfig()
        {
            InitializeComponent();
            // foreach (Process p in Process.GetProcesses()) { if(p.ProcessName == ProcName) { r += 1; } }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TryConnectToServer(object sender, EventArgs e)
        {
            // TODO try to connect to server and database
            if (ktbx_servername.Text.Trim() != "")
            {
                if (ktbx_dbname.Text != "")
                {
                    if (ktbx_username.Text != "")
                    {
                        // Connection code here
                        Properties.Settings.Default.isFirstTime = true;
                        Properties.Settings.Default.Save();
                        MessageBox.Show(Properties.Settings.Default.isFirstTime.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Entrez un nom d'utilisateur !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ktbx_username.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Entrez le nom de la base de donnée !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ktbx_dbname.Focus();
                }
            }
            else
            {
                MessageBox.Show("Entrez le nom du serveur !", "ScMaSy - Erreur Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ktbx_servername.Focus();
            }
        }

        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
