namespace TPFinal
{
    partial class Form_Preferences
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
            this.fb_Police = new FlashButton.FlashButton();
            this.fb_LignesPaires = new FlashButton.FlashButton();
            this.fb_LignesImpaires = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // fb_Police
            // 
            this.fb_Police.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fb_Police.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fb_Police.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fb_Police.ImageClick = null;
            this.fb_Police.ImageDisable = null;
            this.fb_Police.ImageNeutral = null;
            this.fb_Police.ImageOver = null;
            this.fb_Police.Location = new System.Drawing.Point(226, 14);
            this.fb_Police.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fb_Police.Name = "fb_Police";
            this.fb_Police.Size = new System.Drawing.Size(89, 87);
            this.fb_Police.TabIndex = 5;
            // 
            // fb_LignesPaires
            // 
            this.fb_LignesPaires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fb_LignesPaires.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fb_LignesPaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fb_LignesPaires.ImageClick = null;
            this.fb_LignesPaires.ImageDisable = null;
            this.fb_LignesPaires.ImageNeutral = null;
            this.fb_LignesPaires.ImageOver = null;
            this.fb_LignesPaires.Location = new System.Drawing.Point(119, 14);
            this.fb_LignesPaires.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fb_LignesPaires.Name = "fb_LignesPaires";
            this.fb_LignesPaires.Size = new System.Drawing.Size(89, 87);
            this.fb_LignesPaires.TabIndex = 3;
            // 
            // fb_LignesImpaires
            // 
            this.fb_LignesImpaires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fb_LignesImpaires.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fb_LignesImpaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fb_LignesImpaires.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fb_LignesImpaires.ImageClick = null;
            this.fb_LignesImpaires.ImageDisable = null;
            this.fb_LignesImpaires.ImageNeutral = null;
            this.fb_LignesImpaires.ImageOver = null;
            this.fb_LignesImpaires.Location = new System.Drawing.Point(13, 14);
            this.fb_LignesImpaires.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fb_LignesImpaires.Name = "fb_LignesImpaires";
            this.fb_LignesImpaires.Size = new System.Drawing.Size(89, 87);
            this.fb_LignesImpaires.TabIndex = 4;
            // 
            // Form_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 121);
            this.Controls.Add(this.fb_Police);
            this.Controls.Add(this.fb_LignesPaires);
            this.Controls.Add(this.fb_LignesImpaires);
            this.Name = "Form_Preferences";
            this.Text = "Préférences";
            this.ResumeLayout(false);

        }

        #endregion

        private FlashButton.FlashButton fb_Police;
        private FlashButton.FlashButton fb_LignesPaires;
        private FlashButton.FlashButton fb_LignesImpaires;
    }
}