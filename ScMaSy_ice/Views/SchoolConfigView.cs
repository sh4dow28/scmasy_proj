using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace ScMaSy_ice.Views
{
    public partial class SchoolConfigView : KryptonForm
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public SchoolConfigView()
        {
            InitializeComponent();
            ofd_choose_logo.Filter = "Fichiers Image (*.jpeg;*.jpg;*.png;*.ico)|*.jpg;*.jpeg;*.png;*.ico";
            ofd_choose_logo.Multiselect = false;
            ofd_choose_logo.Title = "Choisir un logo";
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeLogo(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (ofd_choose_logo.ShowDialog() == DialogResult.OK)
            {
                //string fileExtension = ofd_choose_logo.SafeFileName.Split('.')[1];
                //string appBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //string saveFilePath = appBaseDirectory + "\\images\\students\\st-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + fileExtension;
                pbx_school_logo.Image = Image.FromFile(ofd_choose_logo.FileName);
                // TODO : Sauvegarder l'image immédiatement après le choix

                //File.Copy(ofd_choose_logo.FileName, saveFilePath);
            }
        }

        private void openUpdateSchoolInfoFm(object sender, EventArgs e)
        {
            FM_SchoolConfig schoolConfig = new FM_SchoolConfig();
            schoolConfig.ShowDialog();
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
