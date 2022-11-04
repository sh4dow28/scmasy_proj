namespace ScMaSy_ice.Views.CustomeControls
{
    partial class ChooseDate
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
            this.ktbx_month = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktbx_year = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktbx_day = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klbl_date_string = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // ktbx_month
            // 
            this.ktbx_month.Location = new System.Drawing.Point(55, 23);
            this.ktbx_month.MaxLength = 10;
            this.ktbx_month.Name = "ktbx_month";
            this.ktbx_month.Size = new System.Drawing.Size(50, 34);
            this.ktbx_month.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.ktbx_month.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ktbx_month.StateCommon.Content.Padding = new System.Windows.Forms.Padding(6);
            this.ktbx_month.TabIndex = 3;
            this.ktbx_month.Text = "01";
            this.ktbx_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktbx_day_KeyDown);
            this.ktbx_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktbx_day_KeyPress);
            this.ktbx_month.Leave += new System.EventHandler(this.ktbx_month_Leave);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(58, -2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(45, 22);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Mois";
            // 
            // ktbx_year
            // 
            this.ktbx_year.Location = new System.Drawing.Point(107, 23);
            this.ktbx_year.MaxLength = 4;
            this.ktbx_year.Name = "ktbx_year";
            this.ktbx_year.Size = new System.Drawing.Size(68, 34);
            this.ktbx_year.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.ktbx_year.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ktbx_year.StateCommon.Content.Padding = new System.Windows.Forms.Padding(6);
            this.ktbx_year.TabIndex = 5;
            this.ktbx_year.Text = "1999";
            this.ktbx_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktbx_day_KeyDown);
            this.ktbx_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktbx_day_KeyPress);
            this.ktbx_year.Leave += new System.EventHandler(this.ktbx_year_Leave);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(111, -2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 22);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Année";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, -2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 22);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Jour";
            // 
            // ktbx_day
            // 
            this.ktbx_day.Location = new System.Drawing.Point(3, 23);
            this.ktbx_day.MaxLength = 2;
            this.ktbx_day.Name = "ktbx_day";
            this.ktbx_day.Size = new System.Drawing.Size(50, 34);
            this.ktbx_day.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.ktbx_day.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ktbx_day.StateCommon.Content.Padding = new System.Windows.Forms.Padding(6);
            this.ktbx_day.TabIndex = 1;
            this.ktbx_day.Text = "02";
            this.ktbx_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktbx_day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktbx_day_KeyDown);
            this.ktbx_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktbx_day_KeyPress);
            this.ktbx_day.Leave += new System.EventHandler(this.ktbx_day_Leave);
            // 
            // klbl_date_string
            // 
            this.klbl_date_string.Location = new System.Drawing.Point(-1, 57);
            this.klbl_date_string.Name = "klbl_date_string";
            this.klbl_date_string.Size = new System.Drawing.Size(94, 17);
            this.klbl_date_string.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.klbl_date_string.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbl_date_string.TabIndex = 6;
            this.klbl_date_string.Values.Text = "01 Janvier 1999";
            // 
            // ChooseDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.klbl_date_string);
            this.Controls.Add(this.ktbx_year);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.ktbx_month);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.ktbx_day);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "ChooseDate";
            this.Size = new System.Drawing.Size(179, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_month;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_year;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbx_day;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klbl_date_string;
    }
}
