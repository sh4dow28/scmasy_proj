namespace ScMaSy_ice.Views
{
    partial class FM_RelationBetweenClassroom
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtn_exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpnl_classlist = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcbx_secondclass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kcbx_firstclass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdgv_list = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.col_begenning_classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_next_classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kbtn_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_classlist)).BeginInit();
            this.kpnl_classlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbx_secondclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbx_firstclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kbtn_exit);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonPanel1.Size = new System.Drawing.Size(717, 35);
            this.kryptonPanel1.TabIndex = 3;
            this.kryptonPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonLabel1_MouseDown);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(44, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(204, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "ScMaSy - Configuration des Classes";
            this.kryptonLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonLabel1_MouseDown);
            // 
            // kbtn_exit
            // 
            this.kbtn_exit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.kbtn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.kbtn_exit.Location = new System.Drawing.Point(682, 0);
            this.kbtn_exit.Name = "kbtn_exit";
            this.kbtn_exit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kbtn_exit.Size = new System.Drawing.Size(35, 35);
            this.kbtn_exit.TabIndex = 1;
            this.kbtn_exit.TabStop = false;
            this.kbtn_exit.Values.Text = "kryptonButton1";
            this.kbtn_exit.Click += new System.EventHandler(this.kbtn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ScMaSy_ice.Properties.Resources.books_school_32_x_32_;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 394);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonPanel2.Size = new System.Drawing.Size(717, 5);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(0, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(717, 29);
            this.kryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Relation entre les classes";
            // 
            // kpnl_classlist
            // 
            this.kpnl_classlist.Controls.Add(this.kbtn_cancel);
            this.kpnl_classlist.Controls.Add(this.kbtn_save);
            this.kpnl_classlist.Controls.Add(this.kcbx_secondclass);
            this.kpnl_classlist.Controls.Add(this.kcbx_firstclass);
            this.kpnl_classlist.Controls.Add(this.kryptonLabel4);
            this.kpnl_classlist.Controls.Add(this.kryptonLabel3);
            this.kpnl_classlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.kpnl_classlist.Location = new System.Drawing.Point(0, 64);
            this.kpnl_classlist.Name = "kpnl_classlist";
            this.kpnl_classlist.Padding = new System.Windows.Forms.Padding(15);
            this.kpnl_classlist.Size = new System.Drawing.Size(350, 330);
            this.kpnl_classlist.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_classlist.TabIndex = 8;
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Enregistrer et Continuer";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Enregistrer et Fermer";
            // 
            // kcbx_secondclass
            // 
            this.kcbx_secondclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbx_secondclass.DropDownWidth = 165;
            this.kcbx_secondclass.Items.AddRange(new object[] {
            "CI",
            "CP",
            "CE1",
            "CE2",
            "CM1"});
            this.kcbx_secondclass.Location = new System.Drawing.Point(152, 142);
            this.kcbx_secondclass.Name = "kcbx_secondclass";
            this.kcbx_secondclass.Size = new System.Drawing.Size(165, 27);
            this.kcbx_secondclass.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbx_secondclass.TabIndex = 3;
            // 
            // kcbx_firstclass
            // 
            this.kcbx_firstclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbx_firstclass.DropDownWidth = 165;
            this.kcbx_firstclass.Items.AddRange(new object[] {
            "CI",
            "CP",
            "CE1",
            "CE2",
            "CM1",
            "CM2"});
            this.kcbx_firstclass.Location = new System.Drawing.Point(152, 54);
            this.kcbx_firstclass.Name = "kcbx_firstclass";
            this.kcbx_firstclass.Size = new System.Drawing.Size(165, 27);
            this.kcbx_firstclass.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbx_firstclass.TabIndex = 2;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(18, 145);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(119, 20);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Classe Suivante :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(18, 56);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(131, 20);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Classe de Départ :";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kdgv_list);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(350, 64);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(367, 330);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 9;
            // 
            // kdgv_list
            // 
            this.kdgv_list.AllowUserToAddRows = false;
            this.kdgv_list.AllowUserToDeleteRows = false;
            this.kdgv_list.AllowUserToResizeColumns = false;
            this.kdgv_list.AllowUserToResizeRows = false;
            this.kdgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgv_list.ColumnHeadersHeight = 40;
            this.kdgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kdgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_begenning_classroom,
            this.col_next_classroom});
            this.kdgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdgv_list.Location = new System.Drawing.Point(0, 0);
            this.kdgv_list.MultiSelect = false;
            this.kdgv_list.Name = "kdgv_list";
            this.kdgv_list.ReadOnly = true;
            this.kdgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kdgv_list.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.kdgv_list.RowTemplate.Height = 35;
            this.kdgv_list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kdgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgv_list.Size = new System.Drawing.Size(367, 330);
            this.kdgv_list.TabIndex = 0;
            // 
            // col_begenning_classroom
            // 
            this.col_begenning_classroom.HeaderText = "Classe de Départ";
            this.col_begenning_classroom.Name = "col_begenning_classroom";
            this.col_begenning_classroom.ReadOnly = true;
            // 
            // col_next_classroom
            // 
            this.col_next_classroom.HeaderText = "Classe Suivante";
            this.col_next_classroom.Name = "col_next_classroom";
            this.col_next_classroom.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::ScMaSy_ice.Properties.Resources.icons8_edit_property_15px;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::ScMaSy_ice.Properties.Resources.icons8_delete_12px;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kbtn_save
            // 
            this.kbtn_save.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_save.Location = new System.Drawing.Point(197, 257);
            this.kbtn_save.Name = "kbtn_save";
            this.kbtn_save.Size = new System.Drawing.Size(120, 40);
            this.kbtn_save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtn_save.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_save.TabIndex = 4;
            this.kbtn_save.Values.Text = "Enregistrer";
            this.kbtn_save.Click += new System.EventHandler(this.kbtn_save_Click);
            // 
            // kbtn_cancel
            // 
            this.kbtn_cancel.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_cancel.Location = new System.Drawing.Point(44, 257);
            this.kbtn_cancel.Name = "kbtn_cancel";
            this.kbtn_cancel.Size = new System.Drawing.Size(120, 40);
            this.kbtn_cancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtn_cancel.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_cancel.TabIndex = 5;
            this.kbtn_cancel.Values.Text = "Quitter";
            this.kbtn_cancel.Click += new System.EventHandler(this.kbtn_cancel_Click);
            // 
            // FM_RelationBetweenClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 399);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kpnl_classlist);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_RelationBetweenClassroom";
            this.ShowInTaskbar = false;
            this.Text = "FM_RelationBetweenClassroom";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_classlist)).EndInit();
            this.kpnl_classlist.ResumeLayout(false);
            this.kpnl_classlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbx_secondclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbx_firstclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_classlist;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdgv_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbx_secondclass;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbx_firstclass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_begenning_classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_next_classroom;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_save;
    }
}