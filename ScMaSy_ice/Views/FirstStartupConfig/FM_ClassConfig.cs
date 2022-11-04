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
    public partial class FM_ClassConfig : KryptonForm
    {
        Form form1;
        List<KryptonCheckBox> MaternelleClass = new List<KryptonCheckBox>();
        List<KryptonCheckBox> PrimaireClass = new List<KryptonCheckBox>();
        List<KryptonCheckBox> CollegeClass = new List<KryptonCheckBox>();
        List<KryptonCheckBox> LyceeClass = new List<KryptonCheckBox>();
        public FM_ClassConfig(List<string> sections, Form form)
        {
            InitializeComponent();

            InitializeClassList();

            if (sections != null)
            {
                foreach(string section in sections)
                {
                    if (section == "MA") 
                    { 
                        section_maternelle.Checked = true; 
                        foreach(KryptonCheckBox checkBox in MaternelleClass) { checkBox.Checked = true; }
                    }
                    if (section == "PR") 
                    { 
                        section_primaire.Checked = true;
                        foreach (KryptonCheckBox checkBox in PrimaireClass) { checkBox.Checked = true; }
                    }
                    if (section == "CO") 
                    { 
                        section_college.Checked = true;
                        foreach (KryptonCheckBox checkBox in CollegeClass) { checkBox.Checked = true; }
                    }
                    if (section == "LY") 
                    { 
                        section_lycee.Checked = true;
                        foreach (KryptonCheckBox checkBox in LyceeClass) { checkBox.Checked = true; }
                    }
                }
            }
            
            form1 = form;
            

        }

        private void kbtn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment arrêter la configuration ?", "ScMaSy.Pre-config", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ComeBack(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void kryptonLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlFunctions.ReleaseCapture();
            ControlFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void InitializeClassList()
        {
            // Classe de la maternelle
            MaternelleClass.Add(kcb_mat1);
            MaternelleClass.Add(kcb_mat2);
            // Classe du primaire
            PrimaireClass.Add(kcb_ci);
            PrimaireClass.Add(kcb_ci1);
            PrimaireClass.Add(kcb_ci2);
            PrimaireClass.Add(kcb_cp);
            PrimaireClass.Add(kcb_cp1);
            PrimaireClass.Add(kcb_cp2);
            PrimaireClass.Add(kcb_ce1);
            PrimaireClass.Add(kcb_ce2);
            PrimaireClass.Add(kcb_cm1);
            PrimaireClass.Add(kcb_cm2);
            // Classe du college
            CollegeClass.Add(kcb_6iem);
            CollegeClass.Add(kcb_5iem);
            CollegeClass.Add(kcb_4iem);
            CollegeClass.Add(kcb_3iem);
            // Classe du lycee
            LyceeClass.Add(kcb_2nd);
            LyceeClass.Add(kcb_1iere);
            LyceeClass.Add(kcb_tle);
        }
    }
}
