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
            this.PN_CouleurPolice = new System.Windows.Forms.Panel();
            this.FB_CouleurForm = new FlashButton.FlashButton();
            this.FB_CouleurPoliceForm = new FlashButton.FlashButton();
            this.FB_PoliceForm = new FlashButton.FlashButton();
            this.PN_Police = new System.Windows.Forms.Panel();
            this.PN_CouleurForm = new System.Windows.Forms.Panel();
            this.PN_DGVPolice = new System.Windows.Forms.Panel();
            this.PN_DGVCouleurPolice = new System.Windows.Forms.Panel();
            this.PN_CouleurPolice.SuspendLayout();
            this.PN_Police.SuspendLayout();
            this.PN_CouleurForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_CouleurPolice
            // 
            this.PN_CouleurPolice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_CouleurPolice.Controls.Add(this.FB_CouleurPoliceForm);
            this.PN_CouleurPolice.Location = new System.Drawing.Point(118, 14);
            this.PN_CouleurPolice.Name = "PN_CouleurPolice";
            this.PN_CouleurPolice.Size = new System.Drawing.Size(99, 99);
            this.PN_CouleurPolice.TabIndex = 7;
            // 
            // FB_CouleurForm
            // 
            this.FB_CouleurForm.BackgroundImage = global::TPFinal.Properties.Resources.ModifierCouleurForm;
            this.FB_CouleurForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CouleurForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_CouleurForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_CouleurForm.ImageClick = global::TPFinal.Properties.Resources.ModifierCouleurForm_Click;
            this.FB_CouleurForm.ImageDisable = global::TPFinal.Properties.Resources.ModifierCouleurForm;
            this.FB_CouleurForm.ImageNeutral = global::TPFinal.Properties.Resources.ModifierCouleurForm;
            this.FB_CouleurForm.ImageOver = global::TPFinal.Properties.Resources.ModifierCouleurForm_Over;
            this.FB_CouleurForm.Location = new System.Drawing.Point(4, 5);
            this.FB_CouleurForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_CouleurForm.Name = "FB_CouleurForm";
            this.FB_CouleurForm.Size = new System.Drawing.Size(89, 87);
            this.FB_CouleurForm.TabIndex = 5;
            this.FB_CouleurForm.Click += new System.EventHandler(this.FB_CouleurForm_Click);
            // 
            // FB_CouleurPoliceForm
            // 
            this.FB_CouleurPoliceForm.BackgroundImage = global::TPFinal.Properties.Resources.ModifierCouleurPolice;
            this.FB_CouleurPoliceForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CouleurPoliceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_CouleurPoliceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_CouleurPoliceForm.ImageClick = global::TPFinal.Properties.Resources.ModifierCouleurPolice_Click;
            this.FB_CouleurPoliceForm.ImageDisable = global::TPFinal.Properties.Resources.ModifierCouleurPolice;
            this.FB_CouleurPoliceForm.ImageNeutral = global::TPFinal.Properties.Resources.ModifierCouleurPolice;
            this.FB_CouleurPoliceForm.ImageOver = global::TPFinal.Properties.Resources.ModifierCouleurPolice_Over;
            this.FB_CouleurPoliceForm.Location = new System.Drawing.Point(4, 5);
            this.FB_CouleurPoliceForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_CouleurPoliceForm.Name = "FB_CouleurPoliceForm";
            this.FB_CouleurPoliceForm.Size = new System.Drawing.Size(89, 87);
            this.FB_CouleurPoliceForm.TabIndex = 3;
            this.FB_CouleurPoliceForm.Click += new System.EventHandler(this.FB_CouleurPoliceForm_Click);
            // 
            // FB_PoliceForm
            // 
            this.FB_PoliceForm.BackColor = System.Drawing.SystemColors.Control;
            this.FB_PoliceForm.BackgroundImage = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PoliceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_PoliceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_PoliceForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FB_PoliceForm.ImageClick = global::TPFinal.Properties.Resources.ModifierPolice_Click;
            this.FB_PoliceForm.ImageDisable = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.ImageNeutral = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.ImageOver = global::TPFinal.Properties.Resources.ModifierPolice_Over;
            this.FB_PoliceForm.Location = new System.Drawing.Point(4, 5);
            this.FB_PoliceForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PoliceForm.Name = "FB_PoliceForm";
            this.FB_PoliceForm.Size = new System.Drawing.Size(89, 87);
            this.FB_PoliceForm.TabIndex = 4;
            this.FB_PoliceForm.Click += new System.EventHandler(this.FB_PoliceForm_Click);
            // 
            // PN_Police
            // 
            this.PN_Police.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Police.Controls.Add(this.FB_PoliceForm);
            this.PN_Police.Location = new System.Drawing.Point(13, 14);
            this.PN_Police.Name = "PN_Police";
            this.PN_Police.Size = new System.Drawing.Size(99, 99);
            this.PN_Police.TabIndex = 8;
            // 
            // PN_CouleurForm
            // 
            this.PN_CouleurForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_CouleurForm.Controls.Add(this.FB_CouleurForm);
            this.PN_CouleurForm.Location = new System.Drawing.Point(223, 14);
            this.PN_CouleurForm.Name = "PN_CouleurForm";
            this.PN_CouleurForm.Size = new System.Drawing.Size(99, 99);
            this.PN_CouleurForm.TabIndex = 9;
            // 
            // PN_DGVPolice
            // 
            this.PN_DGVPolice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_DGVPolice.Location = new System.Drawing.Point(328, 14);
            this.PN_DGVPolice.Name = "PN_DGVPolice";
            this.PN_DGVPolice.Size = new System.Drawing.Size(99, 99);
            this.PN_DGVPolice.TabIndex = 10;
            // 
            // PN_DGVCouleurPolice
            // 
            this.PN_DGVCouleurPolice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_DGVCouleurPolice.Location = new System.Drawing.Point(433, 14);
            this.PN_DGVCouleurPolice.Name = "PN_DGVCouleurPolice";
            this.PN_DGVCouleurPolice.Size = new System.Drawing.Size(99, 99);
            this.PN_DGVCouleurPolice.TabIndex = 11;
            // 
            // Form_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 127);
            this.Controls.Add(this.PN_DGVCouleurPolice);
            this.Controls.Add(this.PN_DGVPolice);
            this.Controls.Add(this.PN_CouleurForm);
            this.Controls.Add(this.PN_Police);
            this.Controls.Add(this.PN_CouleurPolice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Preferences";
            this.Text = "Préférences";
            this.PN_CouleurPolice.ResumeLayout(false);
            this.PN_Police.ResumeLayout(false);
            this.PN_CouleurForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlashButton.FlashButton FB_CouleurPoliceForm;
        private FlashButton.FlashButton FB_PoliceForm;
        private FlashButton.FlashButton FB_CouleurForm;
        private System.Windows.Forms.Panel PN_CouleurPolice;
        private System.Windows.Forms.Panel PN_Police;
        private System.Windows.Forms.Panel PN_CouleurForm;
        private System.Windows.Forms.Panel PN_DGVPolice;
        private System.Windows.Forms.Panel PN_DGVCouleurPolice;
    }
}