using ComponentFactory.Krypton.Toolkit;
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

namespace ScMaSy_ice.Views.FirstStartupConfig
{
    public partial class FM_ClassSectionConfig : KryptonForm
    {
        List<string> sections = new List<string>();
        public FM_ClassSectionConfig()
        {
            InitializeComponent();
            section_maternelle.Checked = true;
            section_primaire.Checked = true;
            section_college.Checked = true;
            section_lycee.Checked = true;
        }

        private void kbtn_close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment arrêter la configuration ?", "ScMaSy.Pre-config", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kbtn_next_Click(object sender, EventArgs e)
        {
            sections.Clear();
            if(section_maternelle.Checked == true) { sections.Add("MA"); }
            if (section_primaire.Checked == true) { sections.Add("PR"); }
            if (section_college.Checked == true) { sections.Add("CO"); }
            if (section_lycee.Checked == true) { sections.Add("LY"); }
            FM_ClassConfig _ClassConfigFM = new FM_ClassConfig(sections, this);
            _ClassConfigFM.Show();
            this.Hide();
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
