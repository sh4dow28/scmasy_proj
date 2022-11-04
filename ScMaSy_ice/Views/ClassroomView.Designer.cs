namespace ScMaSy_ice.Views
{
    partial class ClassroomView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassroomView));
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuMonthCalendar1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuMonthCalendar();
            this.ribbon_container = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_new = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kDataGridViewClassroom = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_classroom_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_registration_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_re_registration_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_teacher_hourly_wage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_senior_tech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpnl_main = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ktbx_searche = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtn_seach = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_container)).BeginInit();
            this.ribbon_container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kDataGridViewClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).BeginInit();
            this.kpnl_main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon_container
            // 
            this.ribbon_container.Controls.Add(this.panel3);
            this.ribbon_container.Controls.Add(this.panel2);
            this.ribbon_container.Controls.Add(this.panel1);
            this.ribbon_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbon_container.Location = new System.Drawing.Point(0, 0);
            this.ribbon_container.Name = "ribbon_container";
            this.ribbon_container.Size = new System.Drawing.Size(1001, 74);
            this.ribbon_container.StateCommon.Color1 = System.Drawing.Color.White;
            this.ribbon_container.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Controls.Add(this.kryptonButton4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 74);
            this.panel2.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonButton1.Location = new System.Drawing.Point(0, 37);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(136, 37);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_print_32px;
            this.kryptonButton1.Values.Text = "Imprimer";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonButton4.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(136, 37);
            this.kryptonButton4.TabIndex = 0;
            this.kryptonButton4.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_delete_32px_2;
            this.kryptonButton4.Values.Text = "Supprimer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.kryptonButton3);
            this.panel1.Controls.Add(this.kryptonButton2);
            this.panel1.Controls.Add(this.kbtn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 74);
            this.panel1.TabIndex = 0;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonButton3.Location = new System.Drawing.Point(156, 0);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(78, 74);
            this.kryptonButton3.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton3.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton3.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton3.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton3.TabIndex = 5;
            this.kryptonButton3.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_update_32px;
            this.kryptonButton3.Values.Text = "Actualiser";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonButton2.Location = new System.Drawing.Point(78, 0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(78, 74);
            this.kryptonButton2.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.TabIndex = 4;
            this.kryptonButton2.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_edit_32px;
            this.kryptonButton2.Values.Text = "Modifier";
            // 
            // kbtn_new
            // 
            this.kbtn_new.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_new.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_new.Location = new System.Drawing.Point(0, 0);
            this.kbtn_new.Name = "kbtn_new";
            this.kbtn_new.Size = new System.Drawing.Size(78, 74);
            this.kbtn_new.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_new.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kbtn_new.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_new.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_new.TabIndex = 3;
            this.kbtn_new.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtn_new.Values.Image")));
            this.kbtn_new.Values.Text = "Nouveau";
            this.kbtn_new.Click += new System.EventHandler(this.addClass);
            // 
            // kDataGridViewClassroom
            // 
            this.kDataGridViewClassroom.AllowUserToAddRows = false;
            this.kDataGridViewClassroom.AllowUserToDeleteRows = false;
            this.kDataGridViewClassroom.AllowUserToResizeColumns = false;
            this.kDataGridViewClassroom.AllowUserToResizeRows = false;
            this.kDataGridViewClassroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kDataGridViewClassroom.ColumnHeadersHeight = 40;
            this.kDataGridViewClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kDataGridViewClassroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_code,
            this.col_label,
            this.col_classroom_section,
            this.col_registration_fees,
            this.col_re_registration_fees,
            this.col_tuition,
            this.col_teacher_hourly_wage,
            this.col_senior_tech,
            this.col_status});
            this.kDataGridViewClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kDataGridViewClassroom.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.kDataGridViewClassroom.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.kDataGridViewClassroom.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kDataGridViewClassroom.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kDataGridViewClassroom.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kDataGridViewClassroom.Location = new System.Drawing.Point(0, 0);
            this.kDataGridViewClassroom.MultiSelect = false;
            this.kDataGridViewClassroom.Name = "kDataGridViewClassroom";
            this.kDataGridViewClassroom.ReadOnly = true;
            this.kDataGridViewClassroom.RowHeadersWidth = 30;
            this.kDataGridViewClassroom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kDataGridViewClassroom.RowTemplate.Height = 30;
            this.kDataGridViewClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kDataGridViewClassroom.Size = new System.Drawing.Size(1001, 439);
            this.kDataGridViewClassroom.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.kDataGridViewClassroom.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kDataGridViewClassroom.StateCommon.HeaderRow.Content.Padding = new System.Windows.Forms.Padding(2);
            this.kDataGridViewClassroom.TabIndex = 0;
            // 
            // col_code
            // 
            this.col_code.FillWeight = 30F;
            this.col_code.HeaderText = "Code";
            this.col_code.MaxInputLength = 10;
            this.col_code.Name = "col_code";
            this.col_code.ReadOnly = true;
            this.col_code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_label
            // 
            this.col_label.FillWeight = 40F;
            this.col_label.HeaderText = "Intitulé";
            this.col_label.MaxInputLength = 5;
            this.col_label.Name = "col_label";
            this.col_label.ReadOnly = true;
            this.col_label.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_classroom_section
            // 
            this.col_classroom_section.FillWeight = 61.10406F;
            this.col_classroom_section.HeaderText = "Cycle";
            this.col_classroom_section.MaxInputLength = 32;
            this.col_classroom_section.Name = "col_classroom_section";
            this.col_classroom_section.ReadOnly = true;
            this.col_classroom_section.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col_registration_fees
            // 
            this.col_registration_fees.FillWeight = 61.10406F;
            this.col_registration_fees.HeaderText = "Frais d\'inscription";
            this.col_registration_fees.Name = "col_registration_fees";
            this.col_registration_fees.ReadOnly = true;
            this.col_registration_fees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_re_registration_fees
            // 
            this.col_re_registration_fees.FillWeight = 61.10406F;
            this.col_re_registration_fees.HeaderText = "Frais de Ré-inscription";
            this.col_re_registration_fees.Name = "col_re_registration_fees";
            this.col_re_registration_fees.ReadOnly = true;
            this.col_re_registration_fees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_tuition
            // 
            this.col_tuition.FillWeight = 61.10406F;
            this.col_tuition.HeaderText = "Frais de Scolarité";
            this.col_tuition.Name = "col_tuition";
            this.col_tuition.ReadOnly = true;
            this.col_tuition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_teacher_hourly_wage
            // 
            this.col_teacher_hourly_wage.FillWeight = 80F;
            this.col_teacher_hourly_wage.HeaderText = "Taux Horaire Professeur";
            this.col_teacher_hourly_wage.Name = "col_teacher_hourly_wage";
            this.col_teacher_hourly_wage.ReadOnly = true;
            this.col_teacher_hourly_wage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_senior_tech
            // 
            this.col_senior_tech.FillWeight = 61.10406F;
            this.col_senior_tech.HeaderText = "Professeur Principal";
            this.col_senior_tech.Name = "col_senior_tech";
            this.col_senior_tech.ReadOnly = true;
            this.col_senior_tech.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_status
            // 
            this.col_status.FillWeight = 61.10406F;
            this.col_status.HeaderText = "Statut";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kpnl_main
            // 
            this.kpnl_main.Controls.Add(this.kDataGridViewClassroom);
            this.kpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnl_main.Location = new System.Drawing.Point(0, 74);
            this.kpnl_main.Name = "kpnl_main";
            this.kpnl_main.Size = new System.Drawing.Size(1001, 439);
            this.kpnl_main.TabIndex = 5;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kbtn_seach);
            this.panel3.Controls.Add(this.ktbx_searche);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(371, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 74);
            this.panel3.TabIndex = 2;
            // 
            // ktbx_searche
            // 
            this.ktbx_searche.Location = new System.Drawing.Point(56, 22);
            this.ktbx_searche.MaxLength = 30;
            this.ktbx_searche.Name = "ktbx_searche";
            this.ktbx_searche.Size = new System.Drawing.Size(273, 35);
            this.ktbx_searche.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ktbx_searche.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.ktbx_searche.TabIndex = 0;
            this.ktbx_searche.Text = "Recherche...";
            // 
            // kbtn_seach
            // 
            this.kbtn_seach.Location = new System.Drawing.Point(328, 22);
            this.kbtn_seach.Name = "kbtn_seach";
            this.kbtn_seach.Size = new System.Drawing.Size(39, 35);
            this.kbtn_seach.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_seach.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_seach.TabIndex = 3;
            this.kbtn_seach.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_search_28px;
            this.kbtn_seach.Values.Text = "";
            this.kbtn_seach.Click += new System.EventHandler(this.search);
            // 
            // ClassroomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 513);
            this.Controls.Add(this.kpnl_main);
            this.Controls.Add(this.ribbon_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassroomView";
            this.Text = "SectionView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon_container)).EndInit();
            this.ribbon_container.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kDataGridViewClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).EndInit();
            this.kpnl_main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuMonthCalendar kryptonContextMenuMonthCalendar1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel ribbon_container;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kDataGridViewClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_classroom_section;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_registration_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_re_registration_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_teacher_hourly_wage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_senior_tech;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_new;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_seach;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_searche;
    }
}