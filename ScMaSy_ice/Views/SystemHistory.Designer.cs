namespace ScMaSy_ice.Views
{
    partial class SystemHistory
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnl_main = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdgv_system_log = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).BeginInit();
            this.kpnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_system_log)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1000, 30);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 470);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1000, 30);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kpnl_main
            // 
            this.kpnl_main.Controls.Add(this.kdgv_system_log);
            this.kpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnl_main.Location = new System.Drawing.Point(0, 30);
            this.kpnl_main.Name = "kpnl_main";
            this.kpnl_main.Size = new System.Drawing.Size(1000, 440);
            this.kpnl_main.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_main.TabIndex = 2;
            // 
            // kdgv_system_log
            // 
            this.kdgv_system_log.AllowUserToAddRows = false;
            this.kdgv_system_log.AllowUserToDeleteRows = false;
            this.kdgv_system_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgv_system_log.ColumnHeadersHeight = 45;
            this.kdgv_system_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kdgv_system_log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.kdgv_system_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdgv_system_log.Location = new System.Drawing.Point(0, 0);
            this.kdgv_system_log.Name = "kdgv_system_log";
            this.kdgv_system_log.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kdgv_system_log.ReadOnly = true;
            this.kdgv_system_log.RowHeadersWidth = 40;
            this.kdgv_system_log.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kdgv_system_log.RowTemplate.Height = 40;
            this.kdgv_system_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgv_system_log.Size = new System.Drawing.Size(1000, 440);
            this.kdgv_system_log.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kdgv_system_log.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kdgv_system_log.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kdgv_system_log.StateCommon.HeaderRow.Content.Padding = new System.Windows.Forms.Padding(7);
            this.kdgv_system_log.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 27.24918F;
            this.Column1.HeaderText = "N°";
            this.Column1.MaxInputLength = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 77.5946F;
            this.Column2.HeaderText = "Utilisateur";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 77.5946F;
            this.Column3.HeaderText = "Action";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "Date et Heure";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 77.5946F;
            this.Column5.HeaderText = "Autres";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SystemHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.kpnl_main);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemHistory";
            this.Text = "SystemHistory";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_main)).EndInit();
            this.kpnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgv_system_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdgv_system_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}