using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScMaSy_ice.Components;


namespace ScMaSy_ice.Views.CustomeControls
{
    public partial class ChooseDate : UserControl
    {
        private string[] monthString = { 
            "Janvier", 
            "Février", 
            "Mars", 
            "Avril", 
            "Mai", 
            "Juin", 
            "Juillet", 
            "Août", 
            "Septembre", 
            "Octobre", 
            "Novembre", 
            "Décembre" 
        };
        public ChooseDate()
        {
            InitializeComponent();
            ktbx_day.Text = "";
            ktbx_month.Text = "";
            ktbx_year.Text = "";
            klbl_date_string.Text = "";
        }
        // Fields
        private WDateFormat format;
        private int maxYear = 2022;
        private readonly string fullDateString;

        [Category("WControl")]
        [Description("Jour en entier")]
        [StringLength(2,ErrorMessage ="Day must be 2 characters.",MinimumLength =2 )]
        public string Day { get => ktbx_day.Text; set => ktbx_day.Text = value; }

        [Category("WControl")]
        [Description("Mois en entier")]
        [StringLength(2, ErrorMessage = "Month must be 2 characters.", MinimumLength = 2)]
        public string Month 
        {
            get { return ktbx_month.Text; }
            set { ktbx_month.Text = value; } 
        }

        [Category("WControl")]
        [Description("Année en entier")]
        [StringLength(4, ErrorMessage = "Year must be 4 characters.", MinimumLength = 4)]
        public string Year { get => ktbx_year.Text; set => ktbx_year.Text = value; }
        [Category("WControl")]
        [Description("Format de la date")]
        public WDateFormat Format { get => format; set => format = value; }
        [Category("WControl")]
        [Description("Année maximum")]
        public int MaxYear { get => maxYear; set => maxYear = value; }

        public string FullDateString 
        { 
            get 
            {
                return formatWithZero(Day) + monthString[Convert.ToInt32(Month) - 1].ToString() + Year; ;
            } 
            // set { klbl_date_string.Text = formatWithZero(Day) + monthString[Convert.ToInt32(Month) - 1].ToString() + Year;}
        }

        public string ChosenDate()
        {
            return ktbx_day.Text + "/" + ktbx_month.Text + "/" + ktbx_year.Text;
        }
        public string formatWithZero(string value)
        {
            if (value.Length == 1) value = "0" + value;
            return value;
        }
        private void ktbx_day_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ktbx_day.Text))
            {
                if (Convert.ToInt32(ktbx_day.Text) > 31)
                    ktbx_day.Text = "31";
                if (Convert.ToInt32(ktbx_day.Text) < 1)
                    ktbx_day.Text = "01";
                
                string _day = string.IsNullOrEmpty(ktbx_day.Text) ? "" : formatWithZero(ktbx_day.Text);
                string _month = string.IsNullOrEmpty(ktbx_month.Text) ? "" : monthString[Convert.ToInt32(ktbx_month.Text) - 1].ToString();
                string _year = string.IsNullOrEmpty(ktbx_year.Text)? "" : ktbx_year.Text;

                klbl_date_string.Text = _day + " " + _month + " " + _year;
            }
        }

        private void ktbx_month_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ktbx_month.Text))
            {
                if (Convert.ToInt32(ktbx_month.Text) > 12)
                    ktbx_month.Text = "12";
                if (Convert.ToInt32(ktbx_month.Text) < 1)
                    ktbx_month.Text = "01";

                string _day = string.IsNullOrEmpty(ktbx_day.Text) ? "" : formatWithZero(ktbx_day.Text);
                string _month = string.IsNullOrEmpty(ktbx_month.Text) ? "" : monthString[Convert.ToInt32(ktbx_month.Text) - 1].ToString();
                string _year = string.IsNullOrEmpty(ktbx_year.Text) ? "" : ktbx_year.Text;

                klbl_date_string.Text = _day + " " + _month + " " + _year;
            }                           
        }                               
                                        
        private void ktbx_year_Leave(object sender, EventArgs e)
        {                               
            if (!string.IsNullOrEmpty(ktbx_year.Text))
            {                           
                if (Convert.ToInt32(ktbx_year.Text) > maxYear)
                    ktbx_year.Text = maxYear.ToString();

                string _day = string.IsNullOrEmpty(ktbx_day.Text) ? "" : formatWithZero(ktbx_day.Text);
                string _month = string.IsNullOrEmpty(ktbx_month.Text) ? "" : monthString[Convert.ToInt32(ktbx_month.Text) - 1].ToString();
                string _year = string.IsNullOrEmpty(ktbx_year.Text) ? "" : ktbx_year.Text;

                klbl_date_string.Text = _day + " " + _month + " " + _year;
            }
        }

        public bool CheckDate(string value)
        {
            return true;
        }

        private void ktbx_day_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ktbx_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFunctions.OnlyNumeric(e);
        }
    }
}
