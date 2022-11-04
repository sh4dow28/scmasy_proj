namespace ScMaSy_ice.Views.CustomeControls
{
    partial class wDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ktbx_day = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktbx_month = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktbx_year = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // ktbx_day
            // 
            this.ktbx_day.Location = new System.Drawing.Point(3, 1);
            this.ktbx_day.Name = "ktbx_day";
            this.ktbx_day.Size = new System.Drawing.Size(50, 33);
            this.ktbx_day.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.ktbx_day.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbx_day.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.ktbx_day.TabIndex = 0;
            this.ktbx_day.Text = "jj";
            this.ktbx_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_day.Enter += new System.EventHandler(this.ktbx_day_Enter);
            this.ktbx_day.Leave += new System.EventHandler(this.ktbx_day_Leave);
            // 
            // ktbx_month
            // 
            this.ktbx_month.Location = new System.Drawing.Point(53, 1);
            this.ktbx_month.Name = "ktbx_month";
            this.ktbx_month.Size = new System.Drawing.Size(50, 33);
            this.ktbx_month.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbx_month.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.ktbx_month.TabIndex = 1;
            this.ktbx_month.Text = "mm";
            this.ktbx_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_month.Enter += new System.EventHandler(this.ktbx_month_Enter);
            // 
            // ktbx_year
            // 
            this.ktbx_year.Location = new System.Drawing.Point(103, 1);
            this.ktbx_year.Name = "ktbx_year";
            this.ktbx_year.Size = new System.Drawing.Size(70, 33);
            this.ktbx_year.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbx_year.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.ktbx_year.TabIndex = 2;
            this.ktbx_year.Text = "aaaa";
            this.ktbx_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_year.Enter += new System.EventHandler(this.ktbx_year_Enter);
            // 
            // wDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ktbx_year);
            this.Controls.Add(this.ktbx_month);
            this.Controls.Add(this.ktbx_day);
            this.Name = "wDate";
            this.Size = new System.Drawing.Size(175, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_day;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_month;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_year;
    }
}
