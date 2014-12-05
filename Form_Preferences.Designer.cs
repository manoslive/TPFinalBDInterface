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
            this.FB_CouleurPoliceForm = new FlashButton.FlashButton();
            this.FB_CouleurForm = new FlashButton.FlashButton();
            this.FB_PoliceForm = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // FB_CouleurPoliceForm
            // 
            this.FB_CouleurPoliceForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CouleurPoliceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_CouleurPoliceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_CouleurPoliceForm.ImageClick = null;
            this.FB_CouleurPoliceForm.ImageDisable = null;
            this.FB_CouleurPoliceForm.ImageNeutral = null;
            this.FB_CouleurPoliceForm.ImageOver = null;
            this.FB_CouleurPoliceForm.Location = new System.Drawing.Point(119, 14);
            this.FB_CouleurPoliceForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_CouleurPoliceForm.Name = "FB_CouleurPoliceForm";
            this.FB_CouleurPoliceForm.Size = new System.Drawing.Size(89, 87);
            this.FB_CouleurPoliceForm.TabIndex = 3;
            // 
            // FB_CouleurForm
            // 
            this.FB_CouleurForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CouleurForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_CouleurForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_CouleurForm.ImageClick = null;
            this.FB_CouleurForm.ImageDisable = null;
            this.FB_CouleurForm.ImageNeutral = null;
            this.FB_CouleurForm.ImageOver = null;
            this.FB_CouleurForm.Location = new System.Drawing.Point(226, 14);
            this.FB_CouleurForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_CouleurForm.Name = "FB_CouleurForm";
            this.FB_CouleurForm.Size = new System.Drawing.Size(89, 87);
            this.FB_CouleurForm.TabIndex = 5;
            // 
            // FB_PoliceForm
            // 
            this.FB_PoliceForm.BackColor = System.Drawing.Color.Transparent;
            this.FB_PoliceForm.BackgroundImage = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_PoliceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FB_PoliceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FB_PoliceForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FB_PoliceForm.ImageClick = global::TPFinal.Properties.Resources.ModifierPolice_Click;
            this.FB_PoliceForm.ImageDisable = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.ImageNeutral = global::TPFinal.Properties.Resources.ModifierPolice;
            this.FB_PoliceForm.ImageOver = global::TPFinal.Properties.Resources.ModifierPolice_Over;
            this.FB_PoliceForm.Location = new System.Drawing.Point(13, 14);
            this.FB_PoliceForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_PoliceForm.Name = "FB_PoliceForm";
            this.FB_PoliceForm.Size = new System.Drawing.Size(89, 87);
            this.FB_PoliceForm.TabIndex = 4;
            // 
            // Form_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 121);
            this.Controls.Add(this.FB_CouleurForm);
            this.Controls.Add(this.FB_CouleurPoliceForm);
            this.Controls.Add(this.FB_PoliceForm);
            this.Name = "Form_Preferences";
            this.Text = "Préférences";
            this.ResumeLayout(false);

        }

        #endregion

        private FlashButton.FlashButton FB_CouleurPoliceForm;
        private FlashButton.FlashButton FB_PoliceForm;
        private FlashButton.FlashButton FB_CouleurForm;
    }
}