namespace ScMaSy_ice.Views
{
    partial class FM_AddOrUpdateTeacher
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtn_exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klabel_frm_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbx_frm_icon = new System.Windows.Forms.PictureBox();
            this.klbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_frm_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(103)))));
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 3);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(3, 444);
            this.pnl_left.TabIndex = 24;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(103)))));
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(497, 3);
            this.pnl_top.TabIndex = 21;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 447);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(497, 3);
            this.pnl_bottom.TabIndex = 23;
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(497, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(3, 450);
            this.pnl_right.TabIndex = 22;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtn_exit);
            this.kryptonPanel1.Controls.Add(this.klabel_frm_title);
            this.kryptonPanel1.Controls.Add(this.pbx_frm_icon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.kryptonPanel1.Size = new System.Drawing.Size(494, 35);
            this.kryptonPanel1.TabIndex = 25;
            this.kryptonPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.klabel_frm_title_MouseDown);
            // 
            // kbtn_exit
            // 
            this.kbtn_exit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kbtn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.kbtn_exit.Location = new System.Drawing.Point(459, 0);
            this.kbtn_exit.Name = "kbtn_exit";
            this.kbtn_exit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kbtn_exit.Size = new System.Drawing.Size(35, 35);
            this.kbtn_exit.TabIndex = 6;
            this.kbtn_exit.TabStop = false;
            this.kbtn_exit.Values.Text = "kryptonButton1";
            this.kbtn_exit.Click += new System.EventHandler(this.CloseForm);
            // 
            // klabel_frm_title
            // 
            this.klabel_frm_title.Location = new System.Drawing.Point(54, 8);
            this.klabel_frm_title.Name = "klabel_frm_title";
            this.klabel_frm_title.Size = new System.Drawing.Size(129, 20);
            this.klabel_frm_title.TabIndex = 5;
            this.klabel_frm_title.Values.Text = "ScMaSy - Enseignants";
            this.klabel_frm_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.klabel_frm_title_MouseDown);
            // 
            // pbx_frm_icon
            // 
            this.pbx_frm_icon.BackColor = System.Drawing.Color.Transparent;
            this.pbx_frm_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbx_frm_icon.Image = global::ScMaSy_ice.Properties.Resources.books_school_32_x_32_;
            this.pbx_frm_icon.Location = new System.Drawing.Point(15, 0);
            this.pbx_frm_icon.Name = "pbx_frm_icon";
            this.pbx_frm_icon.Padding = new System.Windows.Forms.Padding(3);
            this.pbx_frm_icon.Size = new System.Drawing.Size(33, 35);
            this.pbx_frm_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_frm_icon.TabIndex = 4;
            this.pbx_frm_icon.TabStop = false;
            // 
            // klbl_title
            // 
            this.klbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.klbl_title.Location = new System.Drawing.Point(3, 38);
            this.klbl_title.Name = "klbl_title";
            this.klbl_title.Size = new System.Drawing.Size(494, 28);
            this.klbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbl_title.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klbl_title.TabIndex = 26;
            this.klbl_title.Values.Text = "Modifier les informations d\'un enseignant";
            // 
            // FM_AddOrUpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.klbl_title);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_AddOrUpdateTeacher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FM_AddOrUpdateTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_frm_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_right;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_exit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klabel_frm_title;
        private System.Windows.Forms.PictureBox pbx_frm_icon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klbl_title;
    }
}