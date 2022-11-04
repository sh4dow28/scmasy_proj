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
using System.Globalization;

namespace ScMaSy_ice.Views
{
    public partial class FM_st_registration : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FM_st_registration()
        {
            InitializeComponent();
            // this.FormBorderStyle = FormBorderStyle.None;
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            krb_sex_mal.Checked = true;
            pnl_step_two.Size = new Size(1, 365);
            pnl_step_one.Size = new Size(765, 365);
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FM_st_registration_Load(object sender, EventArgs e)
        {
            kmtbx_dob.Culture = new System.Globalization.CultureInfo("fr-FR");
            kmtbx_dob.Mask = "00/00/0000";
            kmtbx_dob.ValidatingType = typeof(System.DateTime);
            kmtbx_dob.TypeValidationCompleted += new TypeValidationEventHandler(kmtbx_dob_TypeValidationCompleted);
            kmtbx_dob.KeyDown += new KeyEventHandler(kmtbx_dob_KeyDown);

            toolTip1.IsBalloon = true;
        }

        private void kbtn_select_photo_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Fichiers Image (*.jpeg;*.jpg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Multiselect = false;
                ofd.Title = "Choisire la photo de l'élève.";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = ofd.FileName;

                    MessageBox.Show(filePath);
                    pbx_st_photo.Image = Image.FromFile(filePath);
                }
            }
        }

        private void EmptyPhotoBox(object sender, EventArgs e)
        {
            pbx_st_photo.Image = null;
        }

        private void CheckDate(string enteredDate, out string dateToCorrectFormat)
        {
            dateToCorrectFormat = null;
        }
        private void ShowNextStep(object sender, EventArgs e)
        {
            // TODO : Try parse date element before convert
            
            string dateEntered = kmtbx_dob.Text;
            string[] dateSplit = dateEntered.Split('/');
            int eDay;
            int eMonth = Convert.ToInt32(dateSplit[1]);
            int eYear = Convert.ToInt32(dateSplit[2]);

            bool dayIsParsable = Int32.TryParse(dateSplit[0], out eDay);
            bool monthIsParsable = Int32.TryParse(dateSplit[1], out eMonth);
            bool yearIsParsable = Int32.TryParse(dateSplit[2], out eYear);

            if(dayIsParsable && monthIsParsable && yearIsParsable)
            {
                if (eYear < DateTime.Now.Year)
                {
                    if (eMonth <= 12)
                    {
                        if (eMonth == 2)
                        {
                            bool isALeapYear = DateTime.IsLeapYear(eYear);
                            if (isALeapYear && eDay > 29)
                            {
                                MessageBox.Show(eYear + " est une année bissextile,Février compte alors au plus 29 jours !");
                            }
                            else if (!isALeapYear && eDay > 28)
                            {

                                MessageBox.Show(eYear + " n'est pas une année bissextile, Février compte alors au plus 28jours.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("mois dépasse 12");
                    }
                }
                else
                {
                    MessageBox.Show("l'année de naissance doit être > l'année actuelle");
                }
            }
            else
            {
                MessageBox.Show("Mauvais format de date");
            }

            
            if(klbl_step_title.Text == "Etape 1/2 - Informations Générales")
            {
                pnl_step_one.Size = new Size(1, 365);
                pnl_step_two.Size = new Size(765, 365);
                klbl_step_title.Text = "Etape 2/2 - Informations sur les Parents/Tuteurs";
                kbtn_previous.Enabled = true;
                kbtn_next.Enabled = false;
                kbtn_save.Enabled = true;
            } 
        }

        private void ShowPreviousStep(object sender, EventArgs e)
        {
            if (klbl_step_title.Text != "Etape 1/2 - Informations Générales")
            {
                pnl_step_two.Size = new Size(1, 365);
                pnl_step_one.Size = new Size(765, 365);
                klbl_step_title.Text = "Etape 1/2 - Informations Générales";
                kbtn_previous.Enabled = false;
                kbtn_next.Enabled = true;
                kbtn_save.Enabled = false;
            }
        }

        private void kmtbx_dob_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            
        }

        private void kmtbx_dob_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
