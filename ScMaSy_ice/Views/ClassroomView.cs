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

namespace ScMaSy_ice.Views
{
    public partial class ClassroomView : KryptonForm
    {
        public ClassroomView()
        {
            InitializeComponent();
            fakeFilling();
            
        }

        private void kbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addClass(object sender, EventArgs e)
        {
            FM_AddOrEditClassroomView fm_AddOrUpdateClassroom = new FM_AddOrEditClassroomView();
            fm_AddOrUpdateClassroom.ShowDialog();
        }

        private void fakeFilling()
        {
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-001", "CI", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-002", "CP", "Primaire", "5000", "3500", "35000", "-", "-", "Actif");
            kDataGridViewClassroom.Rows.Add("CL-003", "6ieme", "Premier Cycle", "7000", "5000", "60000", "1500", "Mr COUMONTER", "Actif");
        }

        private void search(object sender, EventArgs e)
        {

        }
    }
}
