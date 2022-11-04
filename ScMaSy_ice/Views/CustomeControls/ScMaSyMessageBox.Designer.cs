namespace ScMaSy_ice.Views.CustomeControls
{
    partial class ScMaSyMessageBox
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
            this.kpnl_top = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnl_bottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtn_close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpnl_center = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_top)).BeginInit();
            this.kpnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_bottom)).BeginInit();
            this.kpnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_center)).BeginInit();
            this.kpnl_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnl_top
            // 
            this.kpnl_top.Controls.Add(this.kryptonLabel1);
            this.kpnl_top.Controls.Add(this.kbtn_close);
            this.kpnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnl_top.Location = new System.Drawing.Point(0, 0);
            this.kpnl_top.Name = "kpnl_top";
            this.kpnl_top.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.kpnl_top.Size = new System.Drawing.Size(380, 40);
            this.kpnl_top.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_top.TabIndex = 0;
            // 
            // kpnl_bottom
            // 
            this.kpnl_bottom.Controls.Add(this.kryptonButton4);
            this.kpnl_bottom.Controls.Add(this.kryptonButton3);
            this.kpnl_bottom.Controls.Add(this.kryptonButton2);
            this.kpnl_bottom.Controls.Add(this.kryptonButton1);
            this.kpnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnl_bottom.Location = new System.Drawing.Point(0, 160);
            this.kpnl_bottom.Name = "kpnl_bottom";
            this.kpnl_bottom.Padding = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.kpnl_bottom.Size = new System.Drawing.Size(380, 60);
            this.kpnl_bottom.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_bottom.TabIndex = 1;
            // 
            // kbtn_close
            // 
            this.kbtn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.kbtn_close.Location = new System.Drawing.Point(340, 0);
            this.kbtn_close.Name = "kbtn_close";
            this.kbtn_close.Size = new System.Drawing.Size(40, 40);
            this.kbtn_close.TabIndex = 0;
            this.kbtn_close.Values.Text = "kryptonButton1";
            this.kbtn_close.Click += new System.EventHandler(this.CloseBox);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 40);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kpnl_center
            // 
            this.kpnl_center.Controls.Add(this.label1);
            this.kpnl_center.Controls.Add(this.pictureBox1);
            this.kpnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnl_center.Location = new System.Drawing.Point(0, 40);
            this.kpnl_center.Name = "kpnl_center";
            this.kpnl_center.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.kpnl_center.Size = new System.Drawing.Size(380, 120);
            this.kpnl_center.StateCommon.Color1 = System.Drawing.Color.White;
            this.kpnl_center.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ScMaSy_ice.Properties.Resources.icons8_help_32px;
            this.pictureBox1.Location = new System.Drawing.Point(25, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.MaximumSize = new System.Drawing.Size(248, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(235, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ceci est un message d\'information de ScMaSyCeci est un message d\'information de S" +
    "cMaSyCeci est un message d\'information de ScMaSy";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton1.Location = new System.Drawing.Point(280, 15);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 30);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "no";
            this.kryptonButton1.Visible = false;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton2.Location = new System.Drawing.Point(190, 15);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 30);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "yes";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton3.Location = new System.Drawing.Point(100, 15);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(90, 30);
            this.kryptonButton3.TabIndex = 2;
            this.kryptonButton3.Values.Text = "cancel";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton4.Location = new System.Drawing.Point(10, 15);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(90, 30);
            this.kryptonButton4.TabIndex = 3;
            this.kryptonButton4.Values.Text = "ok";
            // 
            // ScMaSyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.kpnl_center);
            this.Controls.Add(this.kpnl_bottom);
            this.Controls.Add(this.kpnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScMaSyMessageBox";
            this.Text = "ScMaSyMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_top)).EndInit();
            this.kpnl_top.ResumeLayout(false);
            this.kpnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_bottom)).EndInit();
            this.kpnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnl_center)).EndInit();
            this.kpnl_center.ResumeLayout(false);
            this.kpnl_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_top;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_close;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_bottom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnl_center;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}