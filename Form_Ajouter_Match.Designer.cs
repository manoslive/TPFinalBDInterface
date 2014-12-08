namespace TPFinal
{
    partial class Form_Ajouter_Match
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
            this.CB_EquipeHome = new System.Windows.Forms.ComboBox();
            this.CB_EquipeAway = new System.Windows.Forms.ComboBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.TB_NumeroMatch = new System.Windows.Forms.TextBox();
            this.LB_LieuMatch = new System.Windows.Forms.Label();
            this.LB_DateMatch = new System.Windows.Forms.Label();
            this.DTP_DateRencontre = new System.Windows.Forms.DateTimePicker();
            this.LB_EquipeAway = new System.Windows.Forms.Label();
            this.LB_EquipeHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.LB_Scorevisiteur = new System.Windows.Forms.Label();
            this.LB_ScoreReceveur = new System.Windows.Forms.Label();
            this.TB_ScoreVisiteur = new System.Windows.Forms.TextBox();
            this.TB_ScoreReceveur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB_EquipeHome
            // 
            this.CB_EquipeHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EquipeHome.FormattingEnabled = true;
            this.CB_EquipeHome.Location = new System.Drawing.Point(174, 31);
            this.CB_EquipeHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_EquipeHome.Name = "CB_EquipeHome";
            this.CB_EquipeHome.Size = new System.Drawing.Size(196, 28);
            this.CB_EquipeHome.TabIndex = 0;
            this.CB_EquipeHome.SelectedIndexChanged += new System.EventHandler(this.CB_EquipeHome_SelectedIndexChanged);
            // 
            // CB_EquipeAway
            // 
            this.CB_EquipeAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EquipeAway.FormattingEnabled = true;
            this.CB_EquipeAway.Location = new System.Drawing.Point(174, 97);
            this.CB_EquipeAway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_EquipeAway.Name = "CB_EquipeAway";
            this.CB_EquipeAway.Size = new System.Drawing.Size(196, 28);
            this.CB_EquipeAway.TabIndex = 1;
            this.CB_EquipeAway.SelectedIndexChanged += new System.EventHandler(this.CB_EquipeAway_SelectedIndexChanged);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(289, 416);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(112, 35);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // TB_Lieu
            // 
            this.TB_Lieu.Location = new System.Drawing.Point(174, 209);
            this.TB_Lieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Lieu.MaxLength = 40;
            this.TB_Lieu.Name = "TB_Lieu";
            this.TB_Lieu.Size = new System.Drawing.Size(196, 26);
            this.TB_Lieu.TabIndex = 3;
            this.TB_Lieu.TextChanged += new System.EventHandler(this.TB_Lieu_TextChanged);
            // 
            // TB_NumeroMatch
            // 
            this.TB_NumeroMatch.Enabled = false;
            this.TB_NumeroMatch.Location = new System.Drawing.Point(116, -94);
            this.TB_NumeroMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NumeroMatch.Name = "TB_NumeroMatch";
            this.TB_NumeroMatch.Size = new System.Drawing.Size(196, 26);
            this.TB_NumeroMatch.TabIndex = 17;
            // 
            // LB_LieuMatch
            // 
            this.LB_LieuMatch.AutoSize = true;
            this.LB_LieuMatch.Location = new System.Drawing.Point(25, 214);
            this.LB_LieuMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_LieuMatch.Name = "LB_LieuMatch";
            this.LB_LieuMatch.Size = new System.Drawing.Size(109, 20);
            this.LB_LieuMatch.TabIndex = 24;
            this.LB_LieuMatch.Text = "Lieu du match";
            // 
            // LB_DateMatch
            // 
            this.LB_DateMatch.AutoSize = true;
            this.LB_DateMatch.Location = new System.Drawing.Point(25, 156);
            this.LB_DateMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_DateMatch.Name = "LB_DateMatch";
            this.LB_DateMatch.Size = new System.Drawing.Size(92, 20);
            this.LB_DateMatch.TabIndex = 22;
            this.LB_DateMatch.Text = "Date match";
            // 
            // DTP_DateRencontre
            // 
            this.DTP_DateRencontre.Location = new System.Drawing.Point(174, 156);
            this.DTP_DateRencontre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_DateRencontre.Name = "DTP_DateRencontre";
            this.DTP_DateRencontre.Size = new System.Drawing.Size(196, 26);
            this.DTP_DateRencontre.TabIndex = 2;
            this.DTP_DateRencontre.ValueChanged += new System.EventHandler(this.DTP_DateRencontre_ValueChanged);
            // 
            // LB_EquipeAway
            // 
            this.LB_EquipeAway.AutoSize = true;
            this.LB_EquipeAway.Location = new System.Drawing.Point(25, 102);
            this.LB_EquipeAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_EquipeAway.Name = "LB_EquipeAway";
            this.LB_EquipeAway.Size = new System.Drawing.Size(116, 20);
            this.LB_EquipeAway.TabIndex = 20;
            this.LB_EquipeAway.Text = "Équipe Visiteur";
            // 
            // LB_EquipeHome
            // 
            this.LB_EquipeHome.AutoSize = true;
            this.LB_EquipeHome.Location = new System.Drawing.Point(25, 36);
            this.LB_EquipeHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_EquipeHome.Name = "LB_EquipeHome";
            this.LB_EquipeHome.Size = new System.Drawing.Size(133, 20);
            this.LB_EquipeHome.TabIndex = 18;
            this.LB_EquipeHome.Text = "Équipe à domicile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-33, -94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero du Match";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Enabled = false;
            this.BTN_Ajouter.Location = new System.Drawing.Point(155, 416);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(112, 35);
            this.BTN_Ajouter.TabIndex = 4;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // LB_Scorevisiteur
            // 
            this.LB_Scorevisiteur.AutoSize = true;
            this.LB_Scorevisiteur.Location = new System.Drawing.Point(25, 262);
            this.LB_Scorevisiteur.Name = "LB_Scorevisiteur";
            this.LB_Scorevisiteur.Size = new System.Drawing.Size(104, 20);
            this.LB_Scorevisiteur.TabIndex = 25;
            this.LB_Scorevisiteur.Text = "Score visiteur";
            // 
            // LB_ScoreReceveur
            // 
            this.LB_ScoreReceveur.AutoSize = true;
            this.LB_ScoreReceveur.Location = new System.Drawing.Point(25, 316);
            this.LB_ScoreReceveur.Name = "LB_ScoreReceveur";
            this.LB_ScoreReceveur.Size = new System.Drawing.Size(116, 20);
            this.LB_ScoreReceveur.TabIndex = 25;
            this.LB_ScoreReceveur.Text = "Score receveur";
            // 
            // TB_ScoreVisiteur
            // 
            this.TB_ScoreVisiteur.Location = new System.Drawing.Point(174, 259);
            this.TB_ScoreVisiteur.Name = "TB_ScoreVisiteur";
            this.TB_ScoreVisiteur.Size = new System.Drawing.Size(196, 26);
            this.TB_ScoreVisiteur.TabIndex = 26;
            this.TB_ScoreVisiteur.TextChanged += new System.EventHandler(this.TB_ScoreVisiteur_TextChanged);
            // 
            // TB_ScoreReceveur
            // 
            this.TB_ScoreReceveur.Location = new System.Drawing.Point(174, 313);
            this.TB_ScoreReceveur.Name = "TB_ScoreReceveur";
            this.TB_ScoreReceveur.Size = new System.Drawing.Size(196, 26);
            this.TB_ScoreReceveur.TabIndex = 26;
            this.TB_ScoreReceveur.TextChanged += new System.EventHandler(this.TB_ScoreReceveur_TextChanged);
            // 
            // Form_Ajouter_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 465);
            this.Controls.Add(this.TB_ScoreReceveur);
            this.Controls.Add(this.TB_ScoreVisiteur);
            this.Controls.Add(this.LB_ScoreReceveur);
            this.Controls.Add(this.LB_Scorevisiteur);
            this.Controls.Add(this.CB_EquipeHome);
            this.Controls.Add(this.CB_EquipeAway);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.TB_Lieu);
            this.Controls.Add(this.TB_NumeroMatch);
            this.Controls.Add(this.LB_LieuMatch);
            this.Controls.Add(this.LB_DateMatch);
            this.Controls.Add(this.DTP_DateRencontre);
            this.Controls.Add(this.LB_EquipeAway);
            this.Controls.Add(this.LB_EquipeHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Match";
            this.Text = "Form_Ajouter_Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Ajouter_Match_FormClosed);
            this.Load += new System.EventHandler(this.Form_Ajouter_Match_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_EquipeHome;
        private System.Windows.Forms.ComboBox CB_EquipeAway;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_Lieu;
        private System.Windows.Forms.TextBox TB_NumeroMatch;
        private System.Windows.Forms.Label LB_LieuMatch;
        private System.Windows.Forms.Label LB_DateMatch;
        private System.Windows.Forms.DateTimePicker DTP_DateRencontre;
        private System.Windows.Forms.Label LB_EquipeAway;
        private System.Windows.Forms.Label LB_EquipeHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label LB_Scorevisiteur;
        private System.Windows.Forms.Label LB_ScoreReceveur;
        private System.Windows.Forms.TextBox TB_ScoreVisiteur;
        private System.Windows.Forms.TextBox TB_ScoreReceveur;
    }
}