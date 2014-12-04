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
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.LB_DateCreation = new System.Windows.Forms.Label();
            this.LB_NomDivision = new System.Windows.Forms.Label();
            this.TB_NomDivision = new System.Windows.Forms.TextBox();
            this.DTP_DateCreation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(310, 115);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(117, 34);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(187, 115);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(117, 34);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // LB_DateCreation
            // 
            this.LB_DateCreation.AutoSize = true;
            this.LB_DateCreation.Location = new System.Drawing.Point(23, 75);
            this.LB_DateCreation.Name = "LB_DateCreation";
            this.LB_DateCreation.Size = new System.Drawing.Size(105, 20);
            this.LB_DateCreation.TabIndex = 1;
            this.LB_DateCreation.Text = "Date création";
            // 
            // LB_NomDivision
            // 
            this.LB_NomDivision.AutoSize = true;
            this.LB_NomDivision.Location = new System.Drawing.Point(23, 21);
            this.LB_NomDivision.Name = "LB_NomDivision";
            this.LB_NomDivision.Size = new System.Drawing.Size(97, 20);
            this.LB_NomDivision.TabIndex = 1;
            this.LB_NomDivision.Text = "Nom division";
            // 
            // TB_NomDivision
            // 
            this.TB_NomDivision.Location = new System.Drawing.Point(153, 21);
            this.TB_NomDivision.Name = "TB_NomDivision";
            this.TB_NomDivision.Size = new System.Drawing.Size(258, 26);
            this.TB_NomDivision.TabIndex = 2;
            // 
            // DTP_DateCreation
            // 
            this.DTP_DateCreation.Location = new System.Drawing.Point(153, 70);
            this.DTP_DateCreation.Name = "DTP_DateCreation";
            this.DTP_DateCreation.Size = new System.Drawing.Size(258, 26);
            this.DTP_DateCreation.TabIndex = 3;
            // 
            // Form_Ajouter_division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 161);
            this.Controls.Add(this.DTP_DateCreation);
            this.Controls.Add(this.TB_NomDivision);
            this.Controls.Add(this.LB_NomDivision);
            this.Controls.Add(this.LB_DateCreation);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "Form_Ajouter_division";
            this.Text = "Form_Ajouter_division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label LB_DateCreation;
        private System.Windows.Forms.Label LB_NomDivision;
        private System.Windows.Forms.TextBox TB_NomDivision;
        private System.Windows.Forms.DateTimePicker DTP_DateCreation;
    }
}