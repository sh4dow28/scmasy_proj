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
using System.IO;

namespace ScMaSy_ice.Views
{
    public partial class FM_Registration : KryptonForm
    {
        public FM_Registration()
        {
            InitializeComponent();
           
        }

        private void closeRegistrationFm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kpnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContinueRegistration(object sender, EventArgs e)
        {
            // TODO : Registration code
        }

        private void kbtn_browsimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers Image (*.jpeg;*.jpg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Choisir la photo de l'apprenant.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // string fileExtension = openFileDialog.SafeFileName.Split('.')[1];
                // string appBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                // string saveFilePath = appBaseDirectory + "\\images\\students\\st-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + fileExtension;
                pbx_studentphoto.Image = Image.FromFile(openFileDialog.FileName);

                // File.Copy(openFileDialog.FileName, saveFilePath);
            }
        }
    }
}
