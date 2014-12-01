﻿namespace TPFinal
{
    partial class Form_Joueurs
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
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.LB_NomJoueur = new System.Windows.Forms.Label();
            this.LB_PrenomJoueur = new System.Windows.Forms.Label();
            this.LB_DateNaissance = new System.Windows.Forms.Label();
            this.LB_NumeroMaillot = new System.Windows.Forms.Label();
            this.LB_EquipeJoueur = new System.Windows.Forms.Label();
            this.LB_PositionJoueur = new System.Windows.Forms.Label();
            this.TB_NumJoueur = new System.Windows.Forms.TextBox();
            this.TB_NomJoueur = new System.Windows.Forms.TextBox();
            this.TB_PrenomJoueur = new System.Windows.Forms.TextBox();
            this.TB_NumMaillot = new System.Windows.Forms.TextBox();
            this.DTP_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.CB_EquipeJoueur = new System.Windows.Forms.ComboBox();
            this.CB_PosJoueur = new System.Windows.Forms.ComboBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Precedent = new System.Windows.Forms.Button();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.PB_Joueur = new System.Windows.Forms.PictureBox();
            this.TB_Url = new System.Windows.Forms.TextBox();
            this.LB_Url = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(33, 24);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(135, 20);
            this.LB_NumJoueur.TabIndex = 0;
            this.LB_NumJoueur.Text = "Numéro du joueur";
            // 
            // LB_NomJoueur
            // 
            this.LB_NomJoueur.AutoSize = true;
            this.LB_NomJoueur.Location = new System.Drawing.Point(33, 84);
            this.LB_NomJoueur.Name = "LB_NomJoueur";
            this.LB_NomJoueur.Size = new System.Drawing.Size(112, 20);
            this.LB_NomJoueur.TabIndex = 0;
            this.LB_NomJoueur.Text = "Nom du joueur";
            // 
            // LB_PrenomJoueur
            // 
            this.LB_PrenomJoueur.AutoSize = true;
            this.LB_PrenomJoueur.Location = new System.Drawing.Point(33, 144);
            this.LB_PrenomJoueur.Name = "LB_PrenomJoueur";
            this.LB_PrenomJoueur.Size = new System.Drawing.Size(134, 20);
            this.LB_PrenomJoueur.TabIndex = 0;
            this.LB_PrenomJoueur.Text = "Prénom du joueur";
            // 
            // LB_DateNaissance
            // 
            this.LB_DateNaissance.AutoSize = true;
            this.LB_DateNaissance.Location = new System.Drawing.Point(33, 204);
            this.LB_DateNaissance.Name = "LB_DateNaissance";
            this.LB_DateNaissance.Size = new System.Drawing.Size(142, 20);
            this.LB_DateNaissance.TabIndex = 0;
            this.LB_DateNaissance.Text = "Date de naissance";
            // 
            // LB_NumeroMaillot
            // 
            this.LB_NumeroMaillot.AutoSize = true;
            this.LB_NumeroMaillot.Location = new System.Drawing.Point(33, 264);
            this.LB_NumeroMaillot.Name = "LB_NumeroMaillot";
            this.LB_NumeroMaillot.Size = new System.Drawing.Size(136, 20);
            this.LB_NumeroMaillot.TabIndex = 0;
            this.LB_NumeroMaillot.Text = "Numéro du maillot";
            // 
            // LB_EquipeJoueur
            // 
            this.LB_EquipeJoueur.AutoSize = true;
            this.LB_EquipeJoueur.Location = new System.Drawing.Point(33, 324);
            this.LB_EquipeJoueur.Name = "LB_EquipeJoueur";
            this.LB_EquipeJoueur.Size = new System.Drawing.Size(129, 20);
            this.LB_EquipeJoueur.TabIndex = 0;
            this.LB_EquipeJoueur.Text = "Équipe du joueur";
            // 
            // LB_PositionJoueur
            // 
            this.LB_PositionJoueur.AutoSize = true;
            this.LB_PositionJoueur.Location = new System.Drawing.Point(33, 384);
            this.LB_PositionJoueur.Name = "LB_PositionJoueur";
            this.LB_PositionJoueur.Size = new System.Drawing.Size(135, 20);
            this.LB_PositionJoueur.TabIndex = 0;
            this.LB_PositionJoueur.Text = "Position du joueur";
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(237, 21);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(227, 26);
            this.TB_NumJoueur.TabIndex = 1;
            // 
            // TB_NomJoueur
            // 
            this.TB_NomJoueur.Location = new System.Drawing.Point(237, 81);
            this.TB_NomJoueur.Name = "TB_NomJoueur";
            this.TB_NomJoueur.ReadOnly = true;
            this.TB_NomJoueur.Size = new System.Drawing.Size(227, 26);
            this.TB_NomJoueur.TabIndex = 1;
            // 
            // TB_PrenomJoueur
            // 
            this.TB_PrenomJoueur.Location = new System.Drawing.Point(237, 141);
            this.TB_PrenomJoueur.Name = "TB_PrenomJoueur";
            this.TB_PrenomJoueur.ReadOnly = true;
            this.TB_PrenomJoueur.Size = new System.Drawing.Size(227, 26);
            this.TB_PrenomJoueur.TabIndex = 1;
            // 
            // TB_NumMaillot
            // 
            this.TB_NumMaillot.Location = new System.Drawing.Point(237, 261);
            this.TB_NumMaillot.Name = "TB_NumMaillot";
            this.TB_NumMaillot.ReadOnly = true;
            this.TB_NumMaillot.Size = new System.Drawing.Size(227, 26);
            this.TB_NumMaillot.TabIndex = 1;
            // 
            // DTP_DateNaissance
            // 
            this.DTP_DateNaissance.Enabled = false;
            this.DTP_DateNaissance.Location = new System.Drawing.Point(237, 199);
            this.DTP_DateNaissance.Name = "DTP_DateNaissance";
            this.DTP_DateNaissance.Size = new System.Drawing.Size(227, 26);
            this.DTP_DateNaissance.TabIndex = 2;
            // 
            // CB_EquipeJoueur
            // 
            this.CB_EquipeJoueur.Enabled = false;
            this.CB_EquipeJoueur.FormattingEnabled = true;
            this.CB_EquipeJoueur.Location = new System.Drawing.Point(237, 321);
            this.CB_EquipeJoueur.Name = "CB_EquipeJoueur";
            this.CB_EquipeJoueur.Size = new System.Drawing.Size(227, 28);
            this.CB_EquipeJoueur.TabIndex = 3;
            // 
            // CB_PosJoueur
            // 
            this.CB_PosJoueur.Enabled = false;
            this.CB_PosJoueur.FormattingEnabled = true;
            this.CB_PosJoueur.Items.AddRange(new object[] {
            "Avant",
            "Defenseur",
            "Gardien"});
            this.CB_PosJoueur.Location = new System.Drawing.Point(237, 381);
            this.CB_PosJoueur.Name = "CB_PosJoueur";
            this.CB_PosJoueur.Size = new System.Drawing.Size(227, 28);
            this.CB_PosJoueur.TabIndex = 3;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(532, 237);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(109, 33);
            this.BTN_Ajouter.TabIndex = 4;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(532, 276);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(109, 33);
            this.BTN_Modifier.TabIndex = 4;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Effacer
            // 
            this.BTN_Effacer.Location = new System.Drawing.Point(532, 315);
            this.BTN_Effacer.Name = "BTN_Effacer";
            this.BTN_Effacer.Size = new System.Drawing.Size(109, 33);
            this.BTN_Effacer.TabIndex = 4;
            this.BTN_Effacer.Text = "Effacer";
            this.BTN_Effacer.UseVisualStyleBackColor = true;
            this.BTN_Effacer.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(532, 492);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(109, 33);
            this.BTN_Fermer.TabIndex = 4;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.Location = new System.Drawing.Point(37, 492);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(109, 33);
            this.BTN_Precedent.TabIndex = 4;
            this.BTN_Precedent.Text = "Précédent";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(356, 492);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(109, 33);
            this.BTN_Suivant.TabIndex = 4;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(532, 384);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(109, 33);
            this.BTN_Debut.TabIndex = 4;
            this.BTN_Debut.Text = "Début";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(532, 423);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(109, 33);
            this.BTN_Fin.TabIndex = 4;
            this.BTN_Fin.Text = "Fin";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // PB_Joueur
            // 
            this.PB_Joueur.ErrorImage = global::TPFinal.Properties.Resources.no_picture;
            this.PB_Joueur.Location = new System.Drawing.Point(512, 24);
            this.PB_Joueur.Name = "PB_Joueur";
            this.PB_Joueur.Size = new System.Drawing.Size(150, 150);
            this.PB_Joueur.TabIndex = 5;
            this.PB_Joueur.TabStop = false;
            // 
            // TB_Url
            // 
            this.TB_Url.Location = new System.Drawing.Point(237, 441);
            this.TB_Url.Name = "TB_Url";
            this.TB_Url.ReadOnly = true;
            this.TB_Url.Size = new System.Drawing.Size(227, 26);
            this.TB_Url.TabIndex = 1;
            // 
            // LB_Url
            // 
            this.LB_Url.AutoSize = true;
            this.LB_Url.Location = new System.Drawing.Point(33, 444);
            this.LB_Url.Name = "LB_Url";
            this.LB_Url.Size = new System.Drawing.Size(137, 20);
            this.LB_Url.TabIndex = 0;
            this.LB_Url.Text = "URL image joueur";
            // 
            // Form_Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 543);
            this.Controls.Add(this.PB_Joueur);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Precedent);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.CB_PosJoueur);
            this.Controls.Add(this.CB_EquipeJoueur);
            this.Controls.Add(this.DTP_DateNaissance);
            this.Controls.Add(this.TB_NumMaillot);
            this.Controls.Add(this.TB_PrenomJoueur);
            this.Controls.Add(this.TB_NomJoueur);
            this.Controls.Add(this.TB_Url);
            this.Controls.Add(this.TB_NumJoueur);
            this.Controls.Add(this.LB_DateNaissance);
            this.Controls.Add(this.LB_PositionJoueur);
            this.Controls.Add(this.LB_PrenomJoueur);
            this.Controls.Add(this.LB_EquipeJoueur);
            this.Controls.Add(this.LB_NomJoueur);
            this.Controls.Add(this.LB_NumeroMaillot);
            this.Controls.Add(this.LB_Url);
            this.Controls.Add(this.LB_NumJoueur);
            this.Name = "Form_Joueurs";
            this.Text = "Form_Joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Joueurs_FormClosed);
            this.Load += new System.EventHandler(this.Form_Joueurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_NumJoueur;
        private System.Windows.Forms.Label LB_NomJoueur;
        private System.Windows.Forms.Label LB_PrenomJoueur;
        private System.Windows.Forms.Label LB_DateNaissance;
        private System.Windows.Forms.Label LB_NumeroMaillot;
        private System.Windows.Forms.Label LB_EquipeJoueur;
        private System.Windows.Forms.Label LB_PositionJoueur;
        private System.Windows.Forms.TextBox TB_NumJoueur;
        private System.Windows.Forms.TextBox TB_NomJoueur;
        private System.Windows.Forms.TextBox TB_PrenomJoueur;
        private System.Windows.Forms.TextBox TB_NumMaillot;
        private System.Windows.Forms.DateTimePicker DTP_DateNaissance;
        private System.Windows.Forms.ComboBox CB_EquipeJoueur;
        private System.Windows.Forms.ComboBox CB_PosJoueur;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Effacer;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Precedent;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.PictureBox PB_Joueur;
        private System.Windows.Forms.TextBox TB_Url;
        private System.Windows.Forms.Label LB_Url;
    }
}