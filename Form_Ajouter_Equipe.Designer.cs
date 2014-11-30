namespace TPFinal
{
    partial class Form_Ajouter_Equipe
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
            this.LB_Equipe = new System.Windows.Forms.Label();
            this.LB_DateCreation = new System.Windows.Forms.Label();
            this.LB_Division = new System.Windows.Forms.Label();
            this.LB_Ville = new System.Windows.Forms.Label();
            this.TB_Equipe = new System.Windows.Forms.TextBox();
            this.DTP_Creation = new System.Windows.Forms.DateTimePicker();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.TB_Ville = new System.Windows.Forms.TextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.BTN_ChargerImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Equipe
            // 
            this.LB_Equipe.AutoSize = true;
            this.LB_Equipe.Location = new System.Drawing.Point(12, 21);
            this.LB_Equipe.Name = "LB_Equipe";
            this.LB_Equipe.Size = new System.Drawing.Size(94, 20);
            this.LB_Equipe.TabIndex = 0;
            this.LB_Equipe.Text = "Nom équipe";
            // 
            // LB_DateCreation
            // 
            this.LB_DateCreation.AutoSize = true;
            this.LB_DateCreation.Location = new System.Drawing.Point(12, 118);
            this.LB_DateCreation.Name = "LB_DateCreation";
            this.LB_DateCreation.Size = new System.Drawing.Size(127, 20);
            this.LB_DateCreation.TabIndex = 0;
            this.LB_DateCreation.Text = "Date de création";
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(12, 214);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 0;
            this.LB_Division.Text = "Division";
            this.LB_Division.Click += new System.EventHandler(this.label3_Click);
            // 
            // LB_Ville
            // 
            this.LB_Ville.AutoSize = true;
            this.LB_Ville.Location = new System.Drawing.Point(12, 315);
            this.LB_Ville.Name = "LB_Ville";
            this.LB_Ville.Size = new System.Drawing.Size(38, 20);
            this.LB_Ville.TabIndex = 0;
            this.LB_Ville.Text = "Ville";
            // 
            // TB_Equipe
            // 
            this.TB_Equipe.Location = new System.Drawing.Point(16, 56);
            this.TB_Equipe.Name = "TB_Equipe";
            this.TB_Equipe.Size = new System.Drawing.Size(200, 26);
            this.TB_Equipe.TabIndex = 1;
            // 
            // DTP_Creation
            // 
            this.DTP_Creation.Location = new System.Drawing.Point(16, 155);
            this.DTP_Creation.Name = "DTP_Creation";
            this.DTP_Creation.Size = new System.Drawing.Size(200, 26);
            this.DTP_Creation.TabIndex = 2;
            // 
            // CB_Division
            // 
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Est",
            "Ouest"});
            this.CB_Division.Location = new System.Drawing.Point(16, 252);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(200, 28);
            this.CB_Division.TabIndex = 3;
            // 
            // TB_Ville
            // 
            this.TB_Ville.Location = new System.Drawing.Point(16, 352);
            this.TB_Ville.Name = "TB_Ville";
            this.TB_Ville.Size = new System.Drawing.Size(200, 26);
            this.TB_Ville.TabIndex = 4;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(383, 442);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(102, 33);
            this.BTN_Ok.TabIndex = 5;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(261, 442);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(102, 33);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.Location = new System.Drawing.Point(289, 21);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(183, 160);
            this.PB_Equipe.TabIndex = 6;
            this.PB_Equipe.TabStop = false;
            // 
            // BTN_ChargerImage
            // 
            this.BTN_ChargerImage.Location = new System.Drawing.Point(289, 214);
            this.BTN_ChargerImage.Name = "BTN_ChargerImage";
            this.BTN_ChargerImage.Size = new System.Drawing.Size(183, 39);
            this.BTN_ChargerImage.TabIndex = 7;
            this.BTN_ChargerImage.Text = "Charger image";
            this.BTN_ChargerImage.UseVisualStyleBackColor = true;
            // 
            // Form_Ajouter_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 487);
            this.Controls.Add(this.BTN_ChargerImage);
            this.Controls.Add(this.PB_Equipe);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.TB_Ville);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.DTP_Creation);
            this.Controls.Add(this.TB_Equipe);
            this.Controls.Add(this.LB_Ville);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.LB_DateCreation);
            this.Controls.Add(this.LB_Equipe);
            this.Name = "Form_Ajouter_Equipe";
            this.Text = "Form_Ajouter_Equipe";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Equipe;
        private System.Windows.Forms.Label LB_DateCreation;
        private System.Windows.Forms.Label LB_Division;
        private System.Windows.Forms.Label LB_Ville;
        private System.Windows.Forms.TextBox TB_Equipe;
        private System.Windows.Forms.DateTimePicker DTP_Creation;
        private System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.TextBox TB_Ville;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.Button BTN_ChargerImage;
    }
}