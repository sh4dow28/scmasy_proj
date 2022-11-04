using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
namespace ScMaSy_ice.Components
{

    static class ControlFunctions
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static void OnlyNumeric(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public static bool CheckDate(string dateString)
        {
            if (!string.IsNullOrEmpty(dateString) && !dateString.Contains("#"))
            {
                int errors = 0;
                string[] splitString = dateString.Split('/');
                int day = int.Parse(splitString[0]);
                int month = int.Parse(splitString[1]);
                int year = int.Parse(splitString[2]);
                //MessageBox.Show(dateString);
                if (day > 31 || day < 1) { errors++; }
                if (month > 12 || month < 1) { errors++; }
                if (splitString[2].Length < 4) { errors++; }

                if (errors == 0) { return true; } else { return false; }
            }
            else
            {
                return false;
            }
            
        }
        public static void CorrectDateText(KryptonMaskedTextBox dateTextBox)
        {
            string[] splitString = dateTextBox.Text.Split('/');
            string day = splitString[0].Trim();
            string month = splitString[1].Trim();
            string year = splitString[2].Trim();

            if (month.Length == 1) { month = "0" + month; }
            if (day.Length == 1) { day = "0" + day; }
            if (year.Length == 2) { year = "20" + year; }

            dateTextBox.Text = day + "/" + month + "/" + year;
        }
        public static bool CheckIfContainNumner(string initialString)
        {
            int nbNumber = 0;
            string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (string number in numbers)
            {
                if (initialString.Contains(number))
                {
                    nbNumber += 1;
                }
            }

            if (nbNumber == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string Capitalize(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value.Replace(value[0].ToString(), value[0].ToString().ToUpper());
            }return "";
        }
    }
}
