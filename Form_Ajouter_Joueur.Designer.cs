namespace TPFinal
{
    partial class Form_Ajouter_Joueur
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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.CB_PosJoueur = new System.Windows.Forms.ComboBox();
            this.CB_EquipeJoueur = new System.Windows.Forms.ComboBox();
            this.DTP_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.TB_NumMaillot = new System.Windows.Forms.TextBox();
            this.TB_PrenomJoueur = new System.Windows.Forms.TextBox();
            this.TB_NomJoueur = new System.Windows.Forms.TextBox();
            this.LB_DateNaissance = new System.Windows.Forms.Label();
            this.LB_PositionJoueur = new System.Windows.Forms.Label();
            this.LB_PrenomJoueur = new System.Windows.Forms.Label();
            this.LB_EquipeJoueur = new System.Windows.Forms.Label();
            this.LB_NomJoueur = new System.Windows.Forms.Label();
            this.LB_NumeroMaillot = new System.Windows.Forms.Label();
            this.TB_Url = new System.Windows.Forms.TextBox();
            this.LB_Url = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(386, 445);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(110, 37);
            this.BTN_Fermer.TabIndex = 22;
            this.BTN_Fermer.Text = "Annuler";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // CB_PosJoueur
            // 
            this.CB_PosJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_PosJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_PosJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PosJoueur.FormattingEnabled = true;
            this.CB_PosJoueur.Items.AddRange(new object[] {
            "Avant",
            "Defenseur",
            "Gardien"});
            this.CB_PosJoueur.Location = new System.Drawing.Point(238, 328);
            this.CB_PosJoueur.Name = "CB_PosJoueur";
            this.CB_PosJoueur.Size = new System.Drawing.Size(228, 28);
            this.CB_PosJoueur.TabIndex = 18;
            this.CB_PosJoueur.SelectedIndexChanged += new System.EventHandler(this.CB_PosJoueur_SelectedIndexChanged);
            // 
            // CB_EquipeJoueur
            // 
            this.CB_EquipeJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_EquipeJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_EquipeJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EquipeJoueur.FormattingEnabled = true;
            this.CB_EquipeJoueur.Location = new System.Drawing.Point(238, 268);
            this.CB_EquipeJoueur.Name = "CB_EquipeJoueur";
            this.CB_EquipeJoueur.Size = new System.Drawing.Size(228, 28);
            this.CB_EquipeJoueur.TabIndex = 17;
            this.CB_EquipeJoueur.SelectedIndexChanged += new System.EventHandler(this.CB_EquipeJoueur_SelectedIndexChanged);
            // 
            // DTP_DateNaissance
            // 
            this.DTP_DateNaissance.Location = new System.Drawing.Point(238, 145);
            this.DTP_DateNaissance.Name = "DTP_DateNaissance";
            this.DTP_DateNaissance.Size = new System.Drawing.Size(228, 26);
            this.DTP_DateNaissance.TabIndex = 16;
            this.DTP_DateNaissance.ValueChanged += new System.EventHandler(this.DTP_DateNaissance_ValueChanged);
            // 
            // TB_NumMaillot
            // 
            this.TB_NumMaillot.Location = new System.Drawing.Point(238, 208);
            this.TB_NumMaillot.MaxLength = 2;
            this.TB_NumMaillot.Name = "TB_NumMaillot";
            this.TB_NumMaillot.Size = new System.Drawing.Size(228, 26);
            this.TB_NumMaillot.TabIndex = 15;
            this.TB_NumMaillot.TextChanged += new System.EventHandler(this.TB_NumMaillot_TextChanged);
            // 
            // TB_PrenomJoueur
            // 
            this.TB_PrenomJoueur.Location = new System.Drawing.Point(238, 88);
            this.TB_PrenomJoueur.Name = "TB_PrenomJoueur";
            this.TB_PrenomJoueur.Size = new System.Drawing.Size(228, 26);
            this.TB_PrenomJoueur.TabIndex = 14;
            this.TB_PrenomJoueur.TextChanged += new System.EventHandler(this.TB_PrenomJoueur_TextChanged);
            // 
            // TB_NomJoueur
            // 
            this.TB_NomJoueur.Location = new System.Drawing.Point(238, 28);
            this.TB_NomJoueur.Name = "TB_NomJoueur";
            this.TB_NomJoueur.Size = new System.Drawing.Size(228, 26);
            this.TB_NomJoueur.TabIndex = 13;
            this.TB_NomJoueur.TextChanged += new System.EventHandler(this.TB_NomJoueur_TextChanged);
            // 
            // LB_DateNaissance
            // 
            this.LB_DateNaissance.AutoSize = true;
            this.LB_DateNaissance.Location = new System.Drawing.Point(34, 149);
            this.LB_DateNaissance.Name = "LB_DateNaissance";
            this.LB_DateNaissance.Size = new System.Drawing.Size(142, 20);
            this.LB_DateNaissance.TabIndex = 10;
            this.LB_DateNaissance.Text = "Date de naissance";
            // 
            // LB_PositionJoueur
            // 
            this.LB_PositionJoueur.AutoSize = true;
            this.LB_PositionJoueur.Location = new System.Drawing.Point(34, 329);
            this.LB_PositionJoueur.Name = "LB_PositionJoueur";
            this.LB_PositionJoueur.Size = new System.Drawing.Size(135, 20);
            this.LB_PositionJoueur.TabIndex = 9;
            this.LB_PositionJoueur.Text = "Position du joueur";
            // 
            // LB_PrenomJoueur
            // 
            this.LB_PrenomJoueur.AutoSize = true;
            this.LB_PrenomJoueur.Location = new System.Drawing.Point(34, 89);
            this.LB_PrenomJoueur.Name = "LB_PrenomJoueur";
            this.LB_PrenomJoueur.Size = new System.Drawing.Size(134, 20);
            this.LB_PrenomJoueur.TabIndex = 8;
            this.LB_PrenomJoueur.Text = "Prénom du joueur";
            // 
            // LB_EquipeJoueur
            // 
            this.LB_EquipeJoueur.AutoSize = true;
            this.LB_EquipeJoueur.Location = new System.Drawing.Point(34, 269);
            this.LB_EquipeJoueur.Name = "LB_EquipeJoueur";
            this.LB_EquipeJoueur.Size = new System.Drawing.Size(129, 20);
            this.LB_EquipeJoueur.TabIndex = 7;
            this.LB_EquipeJoueur.Text = "Équipe du joueur";
            // 
            // LB_NomJoueur
            // 
            this.LB_NomJoueur.AutoSize = true;
            this.LB_NomJoueur.Location = new System.Drawing.Point(34, 29);
            this.LB_NomJoueur.Name = "LB_NomJoueur";
            this.LB_NomJoueur.Size = new System.Drawing.Size(112, 20);
            this.LB_NomJoueur.TabIndex = 6;
            this.LB_NomJoueur.Text = "Nom du joueur";
            // 
            // LB_NumeroMaillot
            // 
            this.LB_NumeroMaillot.AutoSize = true;
            this.LB_NumeroMaillot.Location = new System.Drawing.Point(34, 209);
            this.LB_NumeroMaillot.Name = "LB_NumeroMaillot";
            this.LB_NumeroMaillot.Size = new System.Drawing.Size(136, 20);
            this.LB_NumeroMaillot.TabIndex = 11;
            this.LB_NumeroMaillot.Text = "Numéro du maillot";
            // 
            // TB_Url
            // 
            this.TB_Url.Location = new System.Drawing.Point(238, 385);
            this.TB_Url.Name = "TB_Url";
            this.TB_Url.Size = new System.Drawing.Size(228, 26);
            this.TB_Url.TabIndex = 24;
            this.TB_Url.TextChanged += new System.EventHandler(this.TB_Url_TextChanged);
            // 
            // LB_Url
            // 
            this.LB_Url.AutoSize = true;
            this.LB_Url.Location = new System.Drawing.Point(34, 388);
            this.LB_Url.Name = "LB_Url";
            this.LB_Url.Size = new System.Drawing.Size(137, 20);
            this.LB_Url.TabIndex = 23;
            this.LB_Url.Text = "URL image joueur";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Enabled = false;
            this.BTN_Ajouter.Location = new System.Drawing.Point(260, 445);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(110, 37);
            this.BTN_Ajouter.TabIndex = 22;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // Form_Ajouter_Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 497);
            this.Controls.Add(this.TB_Url);
            this.Controls.Add(this.LB_Url);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.CB_PosJoueur);
            this.Controls.Add(this.CB_EquipeJoueur);
            this.Controls.Add(this.DTP_DateNaissance);
            this.Controls.Add(this.TB_NumMaillot);
            this.Controls.Add(this.TB_PrenomJoueur);
            this.Controls.Add(this.TB_NomJoueur);
            this.Controls.Add(this.LB_DateNaissance);
            this.Controls.Add(this.LB_PositionJoueur);
            this.Controls.Add(this.LB_PrenomJoueur);
            this.Controls.Add(this.LB_EquipeJoueur);
            this.Controls.Add(this.LB_NomJoueur);
            this.Controls.Add(this.LB_NumeroMaillot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Joueur";
            this.Text = "Form_Ajouter_Joueur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ajouter_Joueur_FormClosing);
            this.Load += new System.EventHandler(this.Form_Ajouter_Joueur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.ComboBox CB_PosJoueur;
        private System.Windows.Forms.ComboBox CB_EquipeJoueur;
        private System.Windows.Forms.DateTimePicker DTP_DateNaissance;
        private System.Windows.Forms.TextBox TB_NumMaillot;
        private System.Windows.Forms.TextBox TB_PrenomJoueur;
        private System.Windows.Forms.TextBox TB_NomJoueur;
        private System.Windows.Forms.Label LB_DateNaissance;
        private System.Windows.Forms.Label LB_PositionJoueur;
        private System.Windows.Forms.Label LB_PrenomJoueur;
        private System.Windows.Forms.Label LB_EquipeJoueur;
        private System.Windows.Forms.Label LB_NomJoueur;
        private System.Windows.Forms.Label LB_NumeroMaillot;
        private System.Windows.Forms.TextBox TB_Url;
        private System.Windows.Forms.Label LB_Url;
        public System.Windows.Forms.Button BTN_Ajouter;
    }
}