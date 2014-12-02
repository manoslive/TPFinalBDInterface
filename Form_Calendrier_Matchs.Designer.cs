namespace TPFinal
{
    partial class Form_Calendrier_Matchs
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
            this.Calendrier_Match = new System.Windows.Forms.MonthCalendar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV_CalendierMatch = new System.Windows.Forms.DataGridView();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CalendierMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendrier_Match
            // 
            this.Calendrier_Match.Location = new System.Drawing.Point(371, 12);
            this.Calendrier_Match.Name = "Calendrier_Match";
            this.Calendrier_Match.TabIndex = 0;
            this.Calendrier_Match.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendrier_Match_DateChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TPFinal.Properties.Resources.canada_hockey;
            this.pictureBox2.Location = new System.Drawing.Point(83, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPFinal.Properties.Resources.Hockey_croise;
            this.pictureBox1.Location = new System.Drawing.Point(763, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DGV_CalendierMatch
            // 
            this.DGV_CalendierMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CalendierMatch.Location = new System.Drawing.Point(12, 270);
            this.DGV_CalendierMatch.MultiSelect = false;
            this.DGV_CalendierMatch.Name = "DGV_CalendierMatch";
            this.DGV_CalendierMatch.ReadOnly = true;
            this.DGV_CalendierMatch.RowHeadersVisible = false;
            this.DGV_CalendierMatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_CalendierMatch.RowTemplate.Height = 28;
            this.DGV_CalendierMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CalendierMatch.Size = new System.Drawing.Size(1000, 239);
            this.DGV_CalendierMatch.TabIndex = 6;
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Fermer.Location = new System.Drawing.Point(910, 532);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(102, 36);
            this.BTN_Fermer.TabIndex = 7;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // Form_Calendrier_Matchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.DGV_CalendierMatch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calendrier_Match);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Calendrier_Matchs";
            this.Text = "Form_Calendrier_Match";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Calendrier_Matchs_FormClosing);
            this.Load += new System.EventHandler(this.Form_Calendrier_Matchs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CalendierMatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendrier_Match;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DGV_CalendierMatch;
        private System.Windows.Forms.Button BTN_Fermer;
    }
}