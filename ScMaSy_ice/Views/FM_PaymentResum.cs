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
    public partial class FM_PaymentResum : Form
    {
        public FM_PaymentResum()
        {
            InitializeComponent();
            klbl_datetime.Text = DateTime.Now.ToString("dd/MM/yyyy à HH:mm");
        }

        public FM_PaymentResum(string _academicyear, string _class, string _student, string _amount, string _reason, string _currentuser)
        {
            InitializeComponent();
            klbl_datetime.Text = DateTime.Now.ToString("dd/MM/yyyy à HH:mm");
            klbl_academicyear.Text = _academicyear;
            klbl_class.Text = _class;
            klbl_student.Text = _student;
            klbl_amount.Text = _amount + " FCFA";
            klbl_reason.Text = _reason;
            klbl_user.Text = _currentuser;
        }
        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FM_PaymentResum_Load(object sender, EventArgs e)
        {

        }

        private void kbtn_submitpayment_Click(object sender, EventArgs e)
        {
            // Code pour enregistrer le paiement ici
        }

        private void kbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klabel_frm_title_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
