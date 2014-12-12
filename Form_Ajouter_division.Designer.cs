namespace TPFinal
{
    partial class Form_Ajouter_Division
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
            this.LB_DateCreation = new System.Windows.Forms.Label();
            this.LB_NomDivision = new System.Windows.Forms.Label();
            this.TB_NomDivision = new System.Windows.Forms.TextBox();
            this.DTP_DateCreation = new System.Windows.Forms.DateTimePicker();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_DateCreation
            // 
            this.LB_DateCreation.AutoSize = true;
            this.LB_DateCreation.Location = new System.Drawing.Point(15, 49);
            this.LB_DateCreation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DateCreation.Name = "LB_DateCreation";
            this.LB_DateCreation.Size = new System.Drawing.Size(71, 13);
            this.LB_DateCreation.TabIndex = 1;
            this.LB_DateCreation.Text = "Date création";
            // 
            // LB_NomDivision
            // 
            this.LB_NomDivision.AutoSize = true;
            this.LB_NomDivision.Location = new System.Drawing.Point(15, 14);
            this.LB_NomDivision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NomDivision.Name = "LB_NomDivision";
            this.LB_NomDivision.Size = new System.Drawing.Size(67, 13);
            this.LB_NomDivision.TabIndex = 1;
            this.LB_NomDivision.Text = "Nom division";
            // 
            // TB_NomDivision
            // 
            this.TB_NomDivision.Location = new System.Drawing.Point(102, 14);
            this.TB_NomDivision.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NomDivision.Name = "TB_NomDivision";
            this.TB_NomDivision.Size = new System.Drawing.Size(173, 20);
            this.TB_NomDivision.TabIndex = 0;
            // 
            // DTP_DateCreation
            // 
            this.DTP_DateCreation.Location = new System.Drawing.Point(102, 45);
            this.DTP_DateCreation.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_DateCreation.Name = "DTP_DateCreation";
            this.DTP_DateCreation.Size = new System.Drawing.Size(173, 20);
            this.DTP_DateCreation.TabIndex = 1;
            this.DTP_DateCreation.ValueChanged += new System.EventHandler(this.DTP_DateCreation_ValueChanged);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ajouter.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Click;
            this.FB_Ajouter.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Over;
            this.FB_Ajouter.Location = new System.Drawing.Point(167, 74);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(42, 42);
            this.FB_Ajouter.TabIndex = 4;
            this.FB_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::TPFinal.Properties.Resources.ICON_Fermer_Click;
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(233, 76);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(40, 40);
            this.FB_Fermer.TabIndex = 5;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Cancel_MouseEnter);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(233, 74);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(40, 40);
            this.PB_Fermer_Gif.TabIndex = 6;
            this.PB_Fermer_Gif.TabStop = false;
            this.PB_Fermer_Gif.Visible = false;
            this.PB_Fermer_Gif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseDown);
            this.PB_Fermer_Gif.MouseLeave += new System.EventHandler(this.PB_Fermer_Gif_MouseLeave);
            // 
            // Form_Ajouter_Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 128);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.DTP_DateCreation);
            this.Controls.Add(this.TB_NomDivision);
            this.Controls.Add(this.LB_NomDivision);
            this.Controls.Add(this.LB_DateCreation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Ajouter_Division";
            this.Text = "Form_Ajouter_division";
            this.Load += new System.EventHandler(this.Form_Ajouter_Division_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_DateCreation;
        private System.Windows.Forms.Label LB_NomDivision;
        private System.Windows.Forms.TextBox TB_NomDivision;
        private System.Windows.Forms.DateTimePicker DTP_DateCreation;
        private FlashButton.FlashButton FB_Ajouter;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
    }
}