namespace ScMaSy_ice.Views
{
    partial class UsersView
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.kpnl_main = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdgv_user_list = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kpnl_top_menu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtn_seach = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbx_search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kbtn_help = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_showuser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kbtn_print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtn_refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtn_create = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fisrtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).BeginInit();
            this.kpnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_user_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_top_menu)).BeginInit();
            this.kpnl_top_menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(3, 513);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(998, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(3, 513);
            this.pnl_right.TabIndex = 1;
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(3, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(995, 3);
            this.pnl_top.TabIndex = 2;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(3, 510);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(995, 3);
            this.pnl_bottom.TabIndex = 3;
            // 
            // pnl_center
            // 
            this.pnl_center.Controls.Add(this.kpnl_main);
            this.pnl_center.Controls.Add(this.kpnl_top_menu);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(3, 3);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(995, 507);
            this.pnl_center.TabIndex = 4;
            // 
            // kpnl_main
            // 
            this.kpnl_main.Controls.Add(this.kdgv_user_list);
            this.kpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnl_main.Location = new System.Drawing.Point(0, 80);
            this.kpnl_main.Name = "kpnl_main";
            this.kpnl_main.Size = new System.Drawing.Size(995, 427);
            this.kpnl_main.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_main.TabIndex = 1;
            // 
            // kdgv_user_list
            // 
            this.kdgv_user_list.AllowUserToAddRows = false;
            this.kdgv_user_list.AllowUserToDeleteRows = false;
            this.kdgv_user_list.AllowUserToOrderColumns = true;
            this.kdgv_user_list.AllowUserToResizeColumns = false;
            this.kdgv_user_list.AllowUserToResizeRows = false;
            this.kdgv_user_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgv_user_list.ColumnHeadersHeight = 45;
            this.kdgv_user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kdgv_user_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_code,
            this.col_lastname,
            this.col_fisrtname,
            this.col_username,
            this.col_group,
            this.col_status});
            this.kdgv_user_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdgv_user_list.Location = new System.Drawing.Point(0, 0);
            this.kdgv_user_list.Name = "kdgv_user_list";
            this.kdgv_user_list.ReadOnly = true;
            this.kdgv_user_list.RowHeadersWidth = 40;
            this.kdgv_user_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kdgv_user_list.RowTemplate.Height = 35;
            this.kdgv_user_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgv_user_list.Size = new System.Drawing.Size(995, 427);
            this.kdgv_user_list.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kdgv_user_list.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kdgv_user_list.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.kdgv_user_list.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kdgv_user_list.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kdgv_user_list.TabIndex = 0;
            // 
            // kpnl_top_menu
            // 
            this.kpnl_top_menu.Controls.Add(this.kbtn_seach);
            this.kpnl_top_menu.Controls.Add(this.ktbx_search);
            this.kpnl_top_menu.Controls.Add(this.panel3);
            this.kpnl_top_menu.Controls.Add(this.panel2);
            this.kpnl_top_menu.Controls.Add(this.panel1);
            this.kpnl_top_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnl_top_menu.Location = new System.Drawing.Point(0, 0);
            this.kpnl_top_menu.Name = "kpnl_top_menu";
            this.kpnl_top_menu.Size = new System.Drawing.Size(995, 80);
            this.kpnl_top_menu.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_top_menu.TabIndex = 0;
            // 
            // kbtn_seach
            // 
            this.kbtn_seach.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_seach.Location = new System.Drawing.Point(941, 24);
            this.kbtn_seach.Name = "kbtn_seach";
            this.kbtn_seach.Size = new System.Drawing.Size(39, 35);
            this.kbtn_seach.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_seach.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_seach.TabIndex = 7;
            this.kbtn_seach.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_search_28px;
            this.kbtn_seach.Values.Text = "";
            // 
            // ktbx_search
            // 
            this.ktbx_search.Location = new System.Drawing.Point(668, 24);
            this.ktbx_search.MaxLength = 30;
            this.ktbx_search.Name = "ktbx_search";
            this.ktbx_search.Size = new System.Drawing.Size(273, 35);
            this.ktbx_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ktbx_search.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.ktbx_search.TabIndex = 6;
            this.ktbx_search.Text = "Recherche...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kbtn_help);
            this.panel3.Controls.Add(this.kbtn_showuser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(420, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 80);
            this.panel3.TabIndex = 2;
            // 
            // kbtn_help
            // 
            this.kbtn_help.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_help.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_help.Location = new System.Drawing.Point(91, 0);
            this.kbtn_help.Name = "kbtn_help";
            this.kbtn_help.Size = new System.Drawing.Size(91, 80);
            this.kbtn_help.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_help.StateCommon.Border.Width = 0;
            this.kbtn_help.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_help.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_help.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_help.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_help.TabIndex = 4;
            this.kbtn_help.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_help_32px;
            this.kbtn_help.Values.Text = "Aide";
            // 
            // kbtn_showuser
            // 
            this.kbtn_showuser.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_showuser.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_showuser.Location = new System.Drawing.Point(0, 0);
            this.kbtn_showuser.Name = "kbtn_showuser";
            this.kbtn_showuser.Size = new System.Drawing.Size(91, 80);
            this.kbtn_showuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_showuser.StateCommon.Border.Width = 0;
            this.kbtn_showuser.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_showuser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_showuser.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_showuser.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_showuser.TabIndex = 3;
            this.kbtn_showuser.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_eye_32px;
            this.kbtn_showuser.Values.Text = "Afficher";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kbtn_print);
            this.panel2.Controls.Add(this.kbtn_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 80);
            this.panel2.TabIndex = 1;
            // 
            // kbtn_print
            // 
            this.kbtn_print.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_print.Dock = System.Windows.Forms.DockStyle.Top;
            this.kbtn_print.Location = new System.Drawing.Point(0, 37);
            this.kbtn_print.Name = "kbtn_print";
            this.kbtn_print.Size = new System.Drawing.Size(168, 43);
            this.kbtn_print.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_print.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kbtn_print.TabIndex = 3;
            this.kbtn_print.Values.Image = global::ScMaSy_ice.Properties.Resources.print_printer_printing_15491;
            this.kbtn_print.Values.Text = "Imprimer";
            this.kbtn_print.Click += new System.EventHandler(this.printUserList);
            // 
            // kbtn_delete
            // 
            this.kbtn_delete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.kbtn_delete.Location = new System.Drawing.Point(0, 0);
            this.kbtn_delete.Name = "kbtn_delete";
            this.kbtn_delete.Size = new System.Drawing.Size(168, 37);
            this.kbtn_delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_delete.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kbtn_delete.TabIndex = 1;
            this.kbtn_delete.Values.Image = global::ScMaSy_ice.Properties.Resources.cross_delete_remove_icon_197138;
            this.kbtn_delete.Values.Text = "Supprimer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kbtn_refresh);
            this.panel1.Controls.Add(this.kbtn_edit);
            this.panel1.Controls.Add(this.kbtn_create);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 80);
            this.panel1.TabIndex = 0;
            // 
            // kbtn_refresh
            // 
            this.kbtn_refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_refresh.Location = new System.Drawing.Point(160, 0);
            this.kbtn_refresh.Name = "kbtn_refresh";
            this.kbtn_refresh.Size = new System.Drawing.Size(91, 80);
            this.kbtn_refresh.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_refresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_refresh.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_refresh.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_refresh.TabIndex = 2;
            this.kbtn_refresh.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_update_32px;
            this.kbtn_refresh.Values.Text = "Actualiser";
            this.kbtn_refresh.Click += new System.EventHandler(this.refreshUserList);
            // 
            // kbtn_edit
            // 
            this.kbtn_edit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_edit.Location = new System.Drawing.Point(80, 0);
            this.kbtn_edit.Name = "kbtn_edit";
            this.kbtn_edit.Size = new System.Drawing.Size(80, 80);
            this.kbtn_edit.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_edit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_edit.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_edit.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_edit.TabIndex = 1;
            this.kbtn_edit.Values.Image = global::ScMaSy_ice.Properties.Resources.businessregistration_signpen_negocio_inscripcio_2358__1_;
            this.kbtn_edit.Values.Text = "Modifier";
            this.kbtn_edit.Click += new System.EventHandler(this.openEditUserFm);
            // 
            // kbtn_create
            // 
            this.kbtn_create.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_create.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_create.Location = new System.Drawing.Point(0, 0);
            this.kbtn_create.Name = "kbtn_create";
            this.kbtn_create.Size = new System.Drawing.Size(80, 80);
            this.kbtn_create.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_create.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.kbtn_create.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_create.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_create.TabIndex = 0;
            this.kbtn_create.Values.Image = global::ScMaSy_ice.Properties.Resources.add_insert_1193;
            this.kbtn_create.Values.Text = "Créer";
            this.kbtn_create.Click += new System.EventHandler(this.openCreateUserFm);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // col_code
            // 
            this.col_code.FillWeight = 70F;
            this.col_code.HeaderText = "Code";
            this.col_code.Name = "col_code";
            this.col_code.ReadOnly = true;
            // 
            // col_lastname
            // 
            this.col_lastname.HeaderText = "Nom(s)";
            this.col_lastname.Name = "col_lastname";
            this.col_lastname.ReadOnly = true;
            // 
            // col_fisrtname
            // 
            this.col_fisrtname.HeaderText = "Prénom(s)";
            this.col_fisrtname.Name = "col_fisrtname";
            this.col_fisrtname.ReadOnly = true;
            // 
            // col_username
            // 
            this.col_username.HeaderText = "Nom d\'utilisateur";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            // 
            // col_group
            // 
            this.col_group.HeaderText = "Groupe";
            this.col_group.Name = "col_group";
            this.col_group.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Statut";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 513);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersView";
            this.Text = "UsersView";
            this.pnl_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).EndInit();
            this.kpnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_user_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_top_menu)).EndInit();
            this.kpnl_top_menu.ResumeLayout(false);
            this.kpnl_top_menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_center;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdgv_user_list;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_top_menu;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_create;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_delete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_print;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_refresh;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_seach;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_search;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_showuser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_help;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fisrtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
    }
}