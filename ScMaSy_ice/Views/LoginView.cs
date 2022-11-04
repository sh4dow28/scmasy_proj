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

using System.Globalization;

using ScMaSy_ice.Properties;
using ScMaSy_ice.Components;
using ScMaSy_ice.Views.CustomeControls;
using ScMaSy_ice.Models;

namespace ScMaSy_ice.Views
{
    public partial class LoginView : KryptonForm
    {
        MUsers CurrentUser;
        public LoginView()
        {
            InitializeComponent();

            
            klabel_time.Text = DateTime.Now.ToString("HH :mm :ss", CultureInfo.CreateSpecificCulture("fr-FR"));
            timer1.Start();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            kbtn_showpwd.Enabled = false;
        }
        private void LoginView_Load(object sender, EventArgs e)
        {
            
        }
        private void kryptonPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kbtn_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ktbx_username_Enter(object sender, EventArgs e)
        {
            if (ktbx_username.Text == "Nom d'utilisateur")
            {
                ktbx_username.Text = "";
                ktbx_username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ktbx_username_Leave(object sender, EventArgs e)
        {
            if (ktbx_username.Text == "")
            {
                ktbx_username.Text = "Nom d'utilisateur";
                ktbx_username.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void ktbx_password_Leave(object sender, EventArgs e)
        {
            if (ktbx_password.Text == "")
            {
                ktbx_password.UseSystemPasswordChar = false;
                ktbx_password.Text = "Mot de passe";
                ktbx_password.StateCommon.Content.Color1 = Color.DarkGray;
            }
        }

        private void ktbx_password_Enter(object sender, EventArgs e)
        {
            if (ktbx_password.Text == "Mot de passe")
            {
                ktbx_password.Text = "";
                ktbx_password.UseSystemPasswordChar = true;
                ktbx_password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ktbx_password_TextChanged(object sender, EventArgs e)
        {
            if(ktbx_password.Text != "" && ktbx_password.Text != "Mot de passe")
            {
                kbtn_showpwd.Enabled = true;
            }
            else
            {
                kbtn_showpwd.Enabled = false;
            }
        }

        private void Login(String username, String password)
        {
            if(username == "" || password == "" || username == "Nom d'utilisateur" || password == "Mot de passe")
            {
                MessageBox.Show("Veillez renseigner votre nom d'utilisateur et votre mot de passe s'il vous plait !", "ScMaSy - LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You are logged in without auth information beacause user verification is disable...");
                FM_Main _Main = new FM_Main();
                _Main.Show();
                this.Hide();
                /*CurrentUser = new MUsers();
                CurrentUser.us_username = username;
                CurrentUser.us_password = password;

                if (CurrentUser.ValidateUser())
                {
                    FM_Main _Main = new FM_Main(CurrentUser);
                    _Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Informations d'identification incorrect, veillez rééseayer svp !", "ScMaSy - LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ktbx_password.Text = "";
                    ktbx_password.Focus();
                }*/
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            klabel_time.Text = dateTime.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
        private void ShowOrHidePassword(object sender, MouseEventArgs e)
        {
            if (ktbx_password.Text != "Mot de passe" && ktbx_password.Text != "")
            {
                //ktbx_password.UseSystemPasswordChar = !ktbx_password.UseSystemPasswordChar;
                ktbx_password.UseSystemPasswordChar = false;
            }
        }
        private void kbtn_showpwd_MouseUp(object sender, MouseEventArgs e)
        {
            ktbx_password.UseSystemPasswordChar = true;
        }

        private void ktbx_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kbtn_login.PerformClick();
            }
        }

        private void OpenDBConfig(object sender, EventArgs e)
        {
            FirstStartupConfig.FM_DBConfig _DBConfigFM = new FirstStartupConfig.FM_DBConfig();
            _DBConfigFM.ShowDialog();
        }

        private void Authentication(object sender, EventArgs e)
        {
            Login(ktbx_username.Text, ktbx_password.Text);

        }
    }
}
