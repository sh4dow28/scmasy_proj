namespace ScMaSy_ice.Views
{
    partial class UserGroupConfig
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
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.kpnl_main = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtn_addgroup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdgv_studentlist = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nbuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).BeginInit();
            this.kpnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_studentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(3, 497);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(994, 3);
            this.pnl_bottom.TabIndex = 7;
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(3, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(994, 3);
            this.pnl_top.TabIndex = 6;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(997, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(3, 500);
            this.pnl_right.TabIndex = 5;
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(3, 500);
            this.pnl_left.TabIndex = 4;
            // 
            // kpnl_main
            // 
            this.kpnl_main.Controls.Add(this.kryptonPanel2);
            this.kpnl_main.Controls.Add(this.kryptonPanel1);
            this.kpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnl_main.Location = new System.Drawing.Point(3, 3);
            this.kpnl_main.Name = "kpnl_main";
            this.kpnl_main.Size = new System.Drawing.Size(994, 494);
            this.kpnl_main.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_main.TabIndex = 8;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtn_addgroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(994, 90);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtn_addgroup
            // 
            this.kbtn_addgroup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_addgroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.kbtn_addgroup.Location = new System.Drawing.Point(0, 0);
            this.kbtn_addgroup.Name = "kbtn_addgroup";
            this.kbtn_addgroup.Size = new System.Drawing.Size(134, 90);
            this.kbtn_addgroup.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_addgroup.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_addgroup.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_addgroup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.kbtn_addgroup.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtn_addgroup.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kbtn_addgroup.TabIndex = 2;
            this.kbtn_addgroup.Values.Image = global::ScMaSy_ice.Properties.Resources.icons8_add_48px;
            this.kbtn_addgroup.Values.Text = "Nouveau Groupe";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kdgv_studentlist);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 90);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(994, 404);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kdgv_studentlist
            // 
            this.kdgv_studentlist.AllowUserToAddRows = false;
            this.kdgv_studentlist.AllowUserToDeleteRows = false;
            this.kdgv_studentlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgv_studentlist.ColumnHeadersHeight = 45;
            this.kdgv_studentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kdgv_studentlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_groupname,
            this.col_nbuser});
            this.kdgv_studentlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdgv_studentlist.Location = new System.Drawing.Point(0, 0);
            this.kdgv_studentlist.MultiSelect = false;
            this.kdgv_studentlist.Name = "kdgv_studentlist";
            this.kdgv_studentlist.ReadOnly = true;
            this.kdgv_studentlist.RowHeadersWidth = 40;
            this.kdgv_studentlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kdgv_studentlist.RowTemplate.Height = 35;
            this.kdgv_studentlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgv_studentlist.Size = new System.Drawing.Size(994, 404);
            this.kdgv_studentlist.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kdgv_studentlist.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kdgv_studentlist.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.FillWeight = 20F;
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_groupname
            // 
            this.col_groupname.HeaderText = "Nom du Groupe";
            this.col_groupname.Name = "col_groupname";
            this.col_groupname.ReadOnly = true;
            // 
            // col_nbuser
            // 
            this.col_nbuser.FillWeight = 70F;
            this.col_nbuser.HeaderText = "Nombre de Membres";
            this.col_nbuser.Name = "col_nbuser";
            this.col_nbuser.ReadOnly = true;
            // 
            // UserGroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.kpnl_main);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserGroupConfig";
            this.Text = "UserGroupConfig";
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).EndInit();
            this.kpnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_studentlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_addgroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdgv_studentlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nbuser;
    }
}