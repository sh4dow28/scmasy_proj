using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScMaSy_ice.Views.CustomeControls
{
    public partial class wDate : UserControl
    {
        private string fullDate = string.Empty;
        private struct SDate
        {
            private string aDay;
            private string aMonth;
            private string aYear;
        }

        public wDate()
        {
            InitializeComponent();

            ktbx_day.StateCommon.Content.Color1 = Color.DarkGray;
            ktbx_month.StateCommon.Content.Color1 = Color.DarkGray;
            ktbx_year.StateCommon.Content.Color1 = Color.DarkGray;

            
        }
        SDate currentDate = new SDate();
        // Fields
        private int maxYear = 2022;
        private readonly string fullDateToString;

        public string Day { get => ktbx_day.Text; set => ktbx_day.Text = value; }
        public string Month
        {
            get { return ktbx_month.Text; }
            set { ktbx_month.Text = value; }
        }
        public string Year { get => ktbx_year.Text; set => ktbx_year.Text = value; }
        public int MaxYear { get => maxYear; set => maxYear = value; }

        public string DateToFrFormat => ktbx_day.Text + "/" + ktbx_month.Text + "/" + ktbx_year.Text;
        public string DateToEnFormat => ktbx_month.Text + "-" + ktbx_day.Text + "-" + ktbx_year.Text;
        private void ktbx_day_Enter(object sender, EventArgs e)
        {
            if(ktbx_day.Text == "jj")
            {
                ktbx_day.Text = string.Empty;
                ktbx_day.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ktbx_month_Enter(object sender, EventArgs e)
        {
            if (ktbx_month.Text =="mm")
            {
                ktbx_month.Text = string.Empty;
                ktbx_month.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ktbx_year_Enter(object sender, EventArgs e)
        {
            if(ktbx_year.Text == "aaaa")
            {
                ktbx_year.Text = string.Empty;
                ktbx_year.StateCommon.Content.Color1 = Color.Black;
            }
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
                string _month = string.IsNullOrEmpty(ktbx_month.Text) ? "" : (Convert.ToInt32(ktbx_month.Text) - 1).ToString();
                // string _month = string.IsNullOrEmpty(ktbx_month.Text) ? "" : monthString[Convert.ToInt32(ktbx_month.Text) - 1].ToString();
                string _year = string.IsNullOrEmpty(ktbx_year.Text) ? "" : ktbx_year.Text;

                //klbl_date_string.Text = _day + " " + _month + " " + _year;
            }
        }
    }
}
