namespace TPFinal
{
    partial class Form_Ajouter_Stats
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
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.TB_NbPasses = new System.Windows.Forms.TextBox();
            this.TB_NbButs = new System.Windows.Forms.TextBox();
            this.TB_NumeroMatch = new System.Windows.Forms.TextBox();
            this.CB_NumJoueur = new System.Windows.Forms.ComboBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LB_TempsPunition = new System.Windows.Forms.Label();
            this.LB_NbPasses = new System.Windows.Forms.Label();
            this.LB_NbButs = new System.Windows.Forms.Label();
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.LB_NumMatch = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(159, 264);
            this.TB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.Size = new System.Drawing.Size(180, 26);
            this.TB_TempsPunition.TabIndex = 13;
            this.TB_TempsPunition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(159, 208);
            this.TB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.Size = new System.Drawing.Size(180, 26);
            this.TB_NbPasses.TabIndex = 14;
            this.TB_NbPasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(159, 150);
            this.TB_NbButs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.Size = new System.Drawing.Size(180, 26);
            this.TB_NbButs.TabIndex = 15;
            this.TB_NbButs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // TB_NumeroMatch
            // 
            this.TB_NumeroMatch.Location = new System.Drawing.Point(159, 27);
            this.TB_NumeroMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NumeroMatch.Name = "TB_NumeroMatch";
            this.TB_NumeroMatch.ReadOnly = true;
            this.TB_NumeroMatch.Size = new System.Drawing.Size(180, 26);
            this.TB_NumeroMatch.TabIndex = 16;
            // 
            // CB_NumJoueur
            // 
            this.CB_NumJoueur.FormattingEnabled = true;
            this.CB_NumJoueur.Location = new System.Drawing.Point(159, 87);
            this.CB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_NumJoueur.Name = "CB_NumJoueur";
            this.CB_NumJoueur.Size = new System.Drawing.Size(180, 28);
            this.CB_NumJoueur.TabIndex = 12;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(250, 355);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(112, 35);
            this.BTN_Cancel.TabIndex = 11;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // LB_TempsPunition
            // 
            this.LB_TempsPunition.AutoSize = true;
            this.LB_TempsPunition.Location = new System.Drawing.Point(25, 267);
            this.LB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TempsPunition.Name = "LB_TempsPunition";
            this.LB_TempsPunition.Size = new System.Drawing.Size(118, 20);
            this.LB_TempsPunition.TabIndex = 6;
            this.LB_TempsPunition.Text = "Temps Punition";
            // 
            // LB_NbPasses
            // 
            this.LB_NbPasses.AutoSize = true;
            this.LB_NbPasses.Location = new System.Drawing.Point(25, 211);
            this.LB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPasses.Name = "LB_NbPasses";
            this.LB_NbPasses.Size = new System.Drawing.Size(85, 20);
            this.LB_NbPasses.TabIndex = 7;
            this.LB_NbPasses.Text = "Nb Passes";
            // 
            // LB_NbButs
            // 
            this.LB_NbButs.AutoSize = true;
            this.LB_NbButs.Location = new System.Drawing.Point(23, 155);
            this.LB_NbButs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbButs.Name = "LB_NbButs";
            this.LB_NbButs.Size = new System.Drawing.Size(66, 20);
            this.LB_NbButs.TabIndex = 8;
            this.LB_NbButs.Text = "Nb Buts";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(25, 92);
            this.LB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(113, 20);
            this.LB_NumJoueur.TabIndex = 9;
            this.LB_NumJoueur.Text = "Numéro joueur";
            // 
            // LB_NumMatch
            // 
            this.LB_NumMatch.AutoSize = true;
            this.LB_NumMatch.Location = new System.Drawing.Point(25, 27);
            this.LB_NumMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumMatch.Name = "LB_NumMatch";
            this.LB_NumMatch.Size = new System.Drawing.Size(113, 20);
            this.LB_NumMatch.TabIndex = 10;
            this.LB_NumMatch.Text = "Numero Match";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Location = new System.Drawing.Point(121, 355);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(112, 35);
            this.BTN_Ajouter.TabIndex = 5;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // Form_Ajouter_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 404);
            this.Controls.Add(this.TB_TempsPunition);
            this.Controls.Add(this.TB_NbPasses);
            this.Controls.Add(this.TB_NbButs);
            this.Controls.Add(this.TB_NumeroMatch);
            this.Controls.Add(this.CB_NumJoueur);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.LB_TempsPunition);
            this.Controls.Add(this.LB_NbPasses);
            this.Controls.Add(this.LB_NbButs);
            this.Controls.Add(this.LB_NumJoueur);
            this.Controls.Add(this.LB_NumMatch);
            this.Controls.Add(this.BTN_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Stats";
            this.Text = "Form_Ajouter_Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ajouter_Stats_FormClosing);
            this.Load += new System.EventHandler(this.Form_Ajouter_Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TempsPunition;
        private System.Windows.Forms.TextBox TB_NbPasses;
        private System.Windows.Forms.TextBox TB_NbButs;
        private System.Windows.Forms.TextBox TB_NumeroMatch;
        private System.Windows.Forms.ComboBox CB_NumJoueur;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LB_TempsPunition;
        private System.Windows.Forms.Label LB_NbPasses;
        private System.Windows.Forms.Label LB_NbButs;
        private System.Windows.Forms.Label LB_NumJoueur;
        private System.Windows.Forms.Label LB_NumMatch;
        public System.Windows.Forms.Button BTN_Ajouter;
    }
}