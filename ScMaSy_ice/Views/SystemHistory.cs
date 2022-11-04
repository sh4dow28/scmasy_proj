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
    public partial class SystemHistory : Form
    {
        public SystemHistory()
        {
            InitializeComponent();
            kdgv_system_log.Rows.Add("1", "foukou kouf", "Inscription d'un apprenant", "08/08/2022 22:08");
            kdgv_system_log.Rows.Add("2", "foukou kouf", "Inscription d'un apprenant", "08/08/2022 22:08");
            kdgv_system_log.Rows.Add("3", "foukou kouf", "Inscription d'un apprenant", "08/08/2022 22:08");
        }
    }
}
