namespace TPFinal
{
    partial class Form_Statistiques
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
            this.DGV_Stats = new System.Windows.Forms.DataGridView();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.LB_TempsPunition = new System.Windows.Forms.Label();
            this.LB_NbPoints = new System.Windows.Forms.Label();
            this.LB_NbPasses = new System.Windows.Forms.Label();
            this.LB_NbButs = new System.Windows.Forms.Label();
            this.LB_Equipe = new System.Windows.Forms.Label();
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.TB_NbPoints = new System.Windows.Forms.TextBox();
            this.TB_NbPasses = new System.Windows.Forms.TextBox();
            this.TB_NbButs = new System.Windows.Forms.TextBox();
            this.TB_NumJoueur = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.CB_Equipes = new System.Windows.Forms.ComboBox();
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_Precedent = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.LB_NumMatch = new System.Windows.Forms.Label();
            this.TB_NumMatch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Stats
            // 
            this.DGV_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stats.Location = new System.Drawing.Point(9, 609);
            this.DGV_Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Stats.Name = "DGV_Stats";
            this.DGV_Stats.Size = new System.Drawing.Size(217, 35);
            this.DGV_Stats.TabIndex = 28;
            this.DGV_Stats.Visible = false;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(250, 609);
            this.BTN_Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(112, 35);
            this.BTN_Ok.TabIndex = 27;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // LB_TempsPunition
            // 
            this.LB_TempsPunition.AutoSize = true;
            this.LB_TempsPunition.Location = new System.Drawing.Point(8, 460);
            this.LB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TempsPunition.Name = "LB_TempsPunition";
            this.LB_TempsPunition.Size = new System.Drawing.Size(139, 20);
            this.LB_TempsPunition.TabIndex = 13;
            this.LB_TempsPunition.Text = "Temps de punition";
            // 
            // LB_NbPoints
            // 
            this.LB_NbPoints.AutoSize = true;
            this.LB_NbPoints.Location = new System.Drawing.Point(8, 407);
            this.LB_NbPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPoints.Name = "LB_NbPoints";
            this.LB_NbPoints.Size = new System.Drawing.Size(163, 20);
            this.LB_NbPoints.TabIndex = 14;
            this.LB_NbPoints.Text = "Nombres points totals";
            // 
            // LB_NbPasses
            // 
            this.LB_NbPasses.AutoSize = true;
            this.LB_NbPasses.Location = new System.Drawing.Point(8, 354);
            this.LB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPasses.Name = "LB_NbPasses";
            this.LB_NbPasses.Size = new System.Drawing.Size(150, 20);
            this.LB_NbPasses.TabIndex = 15;
            this.LB_NbPasses.Text = "Nombres de passes";
            // 
            // LB_NbButs
            // 
            this.LB_NbButs.AutoSize = true;
            this.LB_NbButs.Location = new System.Drawing.Point(8, 300);
            this.LB_NbButs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbButs.Name = "LB_NbButs";
            this.LB_NbButs.Size = new System.Drawing.Size(130, 20);
            this.LB_NbButs.TabIndex = 16;
            this.LB_NbButs.Text = "Nombres de buts";
            // 
            // LB_Equipe
            // 
            this.LB_Equipe.AutoSize = true;
            this.LB_Equipe.Location = new System.Drawing.Point(8, 245);
            this.LB_Equipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Equipe.Name = "LB_Equipe";
            this.LB_Equipe.Size = new System.Drawing.Size(112, 20);
            this.LB_Equipe.TabIndex = 17;
            this.LB_Equipe.Text = "Équipe Joueur";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(8, 75);
            this.LB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(118, 20);
            this.LB_NumJoueur.TabIndex = 18;
            this.LB_NumJoueur.Text = "Numero Joueur";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(8, 135);
            this.LB_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(42, 20);
            this.LB_Nom.TabIndex = 11;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(8, 189);
            this.LB_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(64, 20);
            this.LB_Prenom.TabIndex = 19;
            this.LB_Prenom.Text = "Prénom";
            // 
            // TB_NbPoints
            // 
            this.TB_NbPoints.Location = new System.Drawing.Point(191, 407);
            this.TB_NbPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPoints.Name = "TB_NbPoints";
            this.TB_NbPoints.ReadOnly = true;
            this.TB_NbPoints.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPoints.TabIndex = 25;
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(191, 354);
            this.TB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.ReadOnly = true;
            this.TB_NbPasses.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPasses.TabIndex = 24;
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(191, 300);
            this.TB_NbButs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.ReadOnly = true;
            this.TB_NbButs.Size = new System.Drawing.Size(170, 26);
            this.TB_NbButs.TabIndex = 23;
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(191, 75);
            this.TB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(170, 26);
            this.TB_NumJoueur.TabIndex = 12;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(191, 135);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(170, 26);
            this.TB_Nom.TabIndex = 20;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(191, 189);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.ReadOnly = true;
            this.TB_Prenom.Size = new System.Drawing.Size(170, 26);
            this.TB_Prenom.TabIndex = 21;
            // 
            // CB_Equipes
            // 
            this.CB_Equipes.FormattingEnabled = true;
            this.CB_Equipes.Location = new System.Drawing.Point(191, 242);
            this.CB_Equipes.Name = "CB_Equipes";
            this.CB_Equipes.Size = new System.Drawing.Size(170, 28);
            this.CB_Equipes.TabIndex = 29;
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(191, 457);
            this.TB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.ReadOnly = true;
            this.TB_TempsPunition.Size = new System.Drawing.Size(170, 26);
            this.TB_TempsPunition.TabIndex = 26;
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(128, 557);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(109, 33);
            this.BTN_Suivant.TabIndex = 30;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(127, 518);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(109, 33);
            this.BTN_Fin.TabIndex = 31;
            this.BTN_Fin.Text = "Fin";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(12, 518);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(109, 33);
            this.BTN_Debut.TabIndex = 32;
            this.BTN_Debut.Text = "Début";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.Location = new System.Drawing.Point(13, 557);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(109, 33);
            this.BTN_Precedent.TabIndex = 33;
            this.BTN_Precedent.Text = "Précédent";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(445, 411);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(109, 33);
            this.BTN_Ajouter.TabIndex = 31;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Effacer
            // 
            this.BTN_Effacer.Location = new System.Drawing.Point(445, 489);
            this.BTN_Effacer.Name = "BTN_Effacer";
            this.BTN_Effacer.Size = new System.Drawing.Size(109, 33);
            this.BTN_Effacer.TabIndex = 34;
            this.BTN_Effacer.Text = "Effacer";
            this.BTN_Effacer.UseVisualStyleBackColor = true;
            this.BTN_Effacer.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(445, 450);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(109, 33);
            this.BTN_Modifier.TabIndex = 35;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // LB_NumMatch
            // 
            this.LB_NumMatch.AutoSize = true;
            this.LB_NumMatch.Location = new System.Drawing.Point(5, 24);
            this.LB_NumMatch.Name = "LB_NumMatch";
            this.LB_NumMatch.Size = new System.Drawing.Size(113, 20);
            this.LB_NumMatch.TabIndex = 36;
            this.LB_NumMatch.Text = "Numéro match";
            // 
            // TB_NumMatch
            // 
            this.TB_NumMatch.Location = new System.Drawing.Point(192, 21);
            this.TB_NumMatch.Name = "TB_NumMatch";
            this.TB_NumMatch.Size = new System.Drawing.Size(170, 26);
            this.TB_NumMatch.TabIndex = 37;
            // 
            // Form_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 662);
            this.Controls.Add(this.TB_NumMatch);
            this.Controls.Add(this.LB_NumMatch);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Precedent);
            this.Controls.Add(this.CB_Equipes);
            this.Controls.Add(this.DGV_Stats);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.LB_TempsPunition);
            this.Controls.Add(this.LB_NbPoints);
            this.Controls.Add(this.LB_NbPasses);
            this.Controls.Add(this.LB_NbButs);
            this.Controls.Add(this.LB_Equipe);
            this.Controls.Add(this.LB_NumJoueur);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.TB_TempsPunition);
            this.Controls.Add(this.TB_NbPoints);
            this.Controls.Add(this.TB_NbPasses);
            this.Controls.Add(this.TB_NbButs);
            this.Controls.Add(this.TB_NumJoueur);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_Prenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Statistiques";
            this.Text = "Form_Statistiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Statistiques_FormClosing);
            this.Load += new System.EventHandler(this.Form_Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Stats;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label LB_TempsPunition;
        private System.Windows.Forms.Label LB_NbPoints;
        private System.Windows.Forms.Label LB_NbPasses;
        private System.Windows.Forms.Label LB_NbButs;
        private System.Windows.Forms.Label LB_Equipe;
        private System.Windows.Forms.Label LB_NumJoueur;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.TextBox TB_NbPoints;
        private System.Windows.Forms.TextBox TB_NbPasses;
        private System.Windows.Forms.TextBox TB_NbButs;
        private System.Windows.Forms.TextBox TB_NumJoueur;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.ComboBox CB_Equipes;
        private System.Windows.Forms.TextBox TB_TempsPunition;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_Precedent;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Effacer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Label LB_NumMatch;
        private System.Windows.Forms.TextBox TB_NumMatch;

    }
}