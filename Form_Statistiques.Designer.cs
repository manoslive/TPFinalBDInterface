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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Statistiques));
            this.DGV_Stats = new System.Windows.Forms.DataGridView();
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
            this.LB_NumMatch = new System.Windows.Forms.Label();
            this.TB_NumMatch = new System.Windows.Forms.TextBox();
            this.FB_SupprimerStat = new FlashButton.FlashButton();
            this.FB_ModifierStat = new FlashButton.FlashButton();
            this.FB_AjouterStat = new FlashButton.FlashButton();
            this.FB_Precedent = new FlashButton.FlashButton();
            this.FB_Suivant = new FlashButton.FlashButton();
            this.FB_Fin = new FlashButton.FlashButton();
            this.FB_Debut = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Stats
            // 
            this.DGV_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stats.Location = new System.Drawing.Point(6, 396);
            this.DGV_Stats.Name = "DGV_Stats";
            this.DGV_Stats.Size = new System.Drawing.Size(145, 23);
            this.DGV_Stats.TabIndex = 28;
            this.DGV_Stats.Visible = false;
            // 
            // LB_TempsPunition
            // 
            this.LB_TempsPunition.AutoSize = true;
            this.LB_TempsPunition.Location = new System.Drawing.Point(5, 299);
            this.LB_TempsPunition.Name = "LB_TempsPunition";
            this.LB_TempsPunition.Size = new System.Drawing.Size(94, 13);
            this.LB_TempsPunition.TabIndex = 13;
            this.LB_TempsPunition.Text = "Temps de punition";
            // 
            // LB_NbPoints
            // 
            this.LB_NbPoints.AutoSize = true;
            this.LB_NbPoints.Location = new System.Drawing.Point(5, 265);
            this.LB_NbPoints.Name = "LB_NbPoints";
            this.LB_NbPoints.Size = new System.Drawing.Size(108, 13);
            this.LB_NbPoints.TabIndex = 14;
            this.LB_NbPoints.Text = "Nombres points totals";
            // 
            // LB_NbPasses
            // 
            this.LB_NbPasses.AutoSize = true;
            this.LB_NbPasses.Location = new System.Drawing.Point(5, 230);
            this.LB_NbPasses.Name = "LB_NbPasses";
            this.LB_NbPasses.Size = new System.Drawing.Size(100, 13);
            this.LB_NbPasses.TabIndex = 15;
            this.LB_NbPasses.Text = "Nombres de passes";
            // 
            // LB_NbButs
            // 
            this.LB_NbButs.AutoSize = true;
            this.LB_NbButs.Location = new System.Drawing.Point(5, 195);
            this.LB_NbButs.Name = "LB_NbButs";
            this.LB_NbButs.Size = new System.Drawing.Size(87, 13);
            this.LB_NbButs.TabIndex = 16;
            this.LB_NbButs.Text = "Nombres de buts";
            // 
            // LB_Equipe
            // 
            this.LB_Equipe.AutoSize = true;
            this.LB_Equipe.Location = new System.Drawing.Point(5, 159);
            this.LB_Equipe.Name = "LB_Equipe";
            this.LB_Equipe.Size = new System.Drawing.Size(75, 13);
            this.LB_Equipe.TabIndex = 17;
            this.LB_Equipe.Text = "Équipe Joueur";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(5, 49);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(79, 13);
            this.LB_NumJoueur.TabIndex = 18;
            this.LB_NumJoueur.Text = "Numero Joueur";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(5, 88);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(29, 13);
            this.LB_Nom.TabIndex = 11;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(5, 123);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(43, 13);
            this.LB_Prenom.TabIndex = 19;
            this.LB_Prenom.Text = "Prénom";
            // 
            // TB_NbPoints
            // 
            this.TB_NbPoints.Location = new System.Drawing.Point(127, 265);
            this.TB_NbPoints.Name = "TB_NbPoints";
            this.TB_NbPoints.ReadOnly = true;
            this.TB_NbPoints.Size = new System.Drawing.Size(115, 20);
            this.TB_NbPoints.TabIndex = 25;
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(127, 230);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.ReadOnly = true;
            this.TB_NbPasses.Size = new System.Drawing.Size(115, 20);
            this.TB_NbPasses.TabIndex = 24;
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(127, 195);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.ReadOnly = true;
            this.TB_NbButs.Size = new System.Drawing.Size(115, 20);
            this.TB_NbButs.TabIndex = 23;
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(127, 49);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(115, 20);
            this.TB_NumJoueur.TabIndex = 12;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(127, 88);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(115, 20);
            this.TB_Nom.TabIndex = 20;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(127, 123);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.ReadOnly = true;
            this.TB_Prenom.Size = new System.Drawing.Size(115, 20);
            this.TB_Prenom.TabIndex = 21;
            // 
            // CB_Equipes
            // 
            this.CB_Equipes.FormattingEnabled = true;
            this.CB_Equipes.Location = new System.Drawing.Point(127, 157);
            this.CB_Equipes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Equipes.Name = "CB_Equipes";
            this.CB_Equipes.Size = new System.Drawing.Size(115, 21);
            this.CB_Equipes.TabIndex = 29;
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(127, 297);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.ReadOnly = true;
            this.TB_TempsPunition.Size = new System.Drawing.Size(115, 20);
            this.TB_TempsPunition.TabIndex = 26;
            // 
            // LB_NumMatch
            // 
            this.LB_NumMatch.AutoSize = true;
            this.LB_NumMatch.Location = new System.Drawing.Point(3, 16);
            this.LB_NumMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NumMatch.Name = "LB_NumMatch";
            this.LB_NumMatch.Size = new System.Drawing.Size(76, 13);
            this.LB_NumMatch.TabIndex = 36;
            this.LB_NumMatch.Text = "Numéro match";
            // 
            // TB_NumMatch
            // 
            this.TB_NumMatch.Location = new System.Drawing.Point(128, 14);
            this.TB_NumMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_NumMatch.Name = "TB_NumMatch";
            this.TB_NumMatch.Size = new System.Drawing.Size(115, 20);
            this.TB_NumMatch.TabIndex = 37;
            // 
            // FB_SupprimerStat
            // 
            this.FB_SupprimerStat.BackColor = System.Drawing.Color.Transparent;
            this.FB_SupprimerStat.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_SupprimerStat.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Click;
            this.FB_SupprimerStat.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerStat.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerStat.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Over;
            this.FB_SupprimerStat.Location = new System.Drawing.Point(297, 135);
            this.FB_SupprimerStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_SupprimerStat.Name = "FB_SupprimerStat";
            this.FB_SupprimerStat.Size = new System.Drawing.Size(46, 46);
            this.FB_SupprimerStat.TabIndex = 40;
            this.FB_SupprimerStat.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // FB_ModifierStat
            // 
            this.FB_ModifierStat.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierStat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_ModifierStat.BackgroundImage")));
            this.FB_ModifierStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierStat.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_ModifierStat.ImageClick")));
            this.FB_ModifierStat.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_ModifierStat.ImageDisable")));
            this.FB_ModifierStat.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_ModifierStat.ImageNeutral")));
            this.FB_ModifierStat.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_ModifierStat.ImageOver")));
            this.FB_ModifierStat.Location = new System.Drawing.Point(297, 79);
            this.FB_ModifierStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_ModifierStat.Name = "FB_ModifierStat";
            this.FB_ModifierStat.Size = new System.Drawing.Size(46, 46);
            this.FB_ModifierStat.TabIndex = 39;
            this.FB_ModifierStat.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // FB_AjouterStat
            // 
            this.FB_AjouterStat.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterStat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_AjouterStat.BackgroundImage")));
            this.FB_AjouterStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjouterStat.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_AjouterStat.ImageClick")));
            this.FB_AjouterStat.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_AjouterStat.ImageDisable")));
            this.FB_AjouterStat.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_AjouterStat.ImageNeutral")));
            this.FB_AjouterStat.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_AjouterStat.ImageOver")));
            this.FB_AjouterStat.Location = new System.Drawing.Point(297, 23);
            this.FB_AjouterStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_AjouterStat.Name = "FB_AjouterStat";
            this.FB_AjouterStat.Size = new System.Drawing.Size(46, 46);
            this.FB_AjouterStat.TabIndex = 38;
            this.FB_AjouterStat.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // FB_Precedent
            // 
            this.FB_Precedent.BackColor = System.Drawing.Color.Transparent;
            this.FB_Precedent.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Precedent;
            this.FB_Precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Precedent.ImageClick = global::TPFinal.Properties.Resources.ICON_Precedent_Click;
            this.FB_Precedent.ImageDisable = global::TPFinal.Properties.Resources.ICON_Puck;
            this.FB_Precedent.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Precedent;
            this.FB_Precedent.ImageOver = global::TPFinal.Properties.Resources.ICON_Precedent_Over;
            this.FB_Precedent.Location = new System.Drawing.Point(76, 336);
            this.FB_Precedent.Name = "FB_Precedent";
            this.FB_Precedent.Size = new System.Drawing.Size(40, 40);
            this.FB_Precedent.TabIndex = 44;
            this.FB_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // FB_Suivant
            // 
            this.FB_Suivant.BackColor = System.Drawing.Color.Transparent;
            this.FB_Suivant.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Suivant;
            this.FB_Suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Suivant.ImageClick = global::TPFinal.Properties.Resources.ICON_Suivant_Click;
            this.FB_Suivant.ImageDisable = global::TPFinal.Properties.Resources.ICON_Puck;
            this.FB_Suivant.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Suivant;
            this.FB_Suivant.ImageOver = global::TPFinal.Properties.Resources.ICON_Suivant_Over;
            this.FB_Suivant.Location = new System.Drawing.Point(140, 336);
            this.FB_Suivant.Name = "FB_Suivant";
            this.FB_Suivant.Size = new System.Drawing.Size(40, 40);
            this.FB_Suivant.TabIndex = 43;
            this.FB_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // FB_Fin
            // 
            this.FB_Fin.BackColor = System.Drawing.Color.Transparent;
            this.FB_Fin.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fin;
            this.FB_Fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fin.ImageClick = global::TPFinal.Properties.Resources.ICON_Fin_Click;
            this.FB_Fin.ImageDisable = global::TPFinal.Properties.Resources.ICON_Puck;
            this.FB_Fin.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fin;
            this.FB_Fin.ImageOver = global::TPFinal.Properties.Resources.ICON_Fin_Over;
            this.FB_Fin.Location = new System.Drawing.Point(186, 336);
            this.FB_Fin.Name = "FB_Fin";
            this.FB_Fin.Size = new System.Drawing.Size(40, 40);
            this.FB_Fin.TabIndex = 42;
            this.FB_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // FB_Debut
            // 
            this.FB_Debut.BackColor = System.Drawing.Color.Transparent;
            this.FB_Debut.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Debut;
            this.FB_Debut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Debut.ImageClick = global::TPFinal.Properties.Resources.ICON_Debut_Click;
            this.FB_Debut.ImageDisable = global::TPFinal.Properties.Resources.ICON_Puck;
            this.FB_Debut.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Debut;
            this.FB_Debut.ImageOver = global::TPFinal.Properties.Resources.ICON_Debut_Over;
            this.FB_Debut.Location = new System.Drawing.Point(30, 336);
            this.FB_Debut.Name = "FB_Debut";
            this.FB_Debut.Size = new System.Drawing.Size(40, 40);
            this.FB_Debut.TabIndex = 41;
            this.FB_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(297, 336);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(46, 41);
            this.PB_Fermer_Gif.TabIndex = 46;
            this.PB_Fermer_Gif.TabStop = false;
            this.PB_Fermer_Gif.Visible = false;
            this.PB_Fermer_Gif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseDown);
            this.PB_Fermer_Gif.MouseLeave += new System.EventHandler(this.PB_Fermer_Gif_MouseLeave);
            this.PB_Fermer_Gif.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseUp);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackColor = System.Drawing.Color.Transparent;
            this.FB_Fermer.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::TPFinal.Properties.Resources.ICON_Fermer_Click;
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(297, 336);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(46, 41);
            this.FB_Fermer.TabIndex = 45;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // Form_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 382);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_Precedent);
            this.Controls.Add(this.FB_Suivant);
            this.Controls.Add(this.FB_Fin);
            this.Controls.Add(this.FB_Debut);
            this.Controls.Add(this.FB_SupprimerStat);
            this.Controls.Add(this.FB_ModifierStat);
            this.Controls.Add(this.FB_AjouterStat);
            this.Controls.Add(this.TB_NumMatch);
            this.Controls.Add(this.LB_NumMatch);
            this.Controls.Add(this.CB_Equipes);
            this.Controls.Add(this.DGV_Stats);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Statistiques";
            this.Text = "Form_Statistiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Statistiques_FormClosing);
            this.Load += new System.EventHandler(this.Form_Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Stats;
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
        private System.Windows.Forms.Label LB_NumMatch;
        private System.Windows.Forms.TextBox TB_NumMatch;
        private FlashButton.FlashButton FB_SupprimerStat;
        private FlashButton.FlashButton FB_ModifierStat;
        private FlashButton.FlashButton FB_AjouterStat;
        private FlashButton.FlashButton FB_Precedent;
        private FlashButton.FlashButton FB_Suivant;
        private FlashButton.FlashButton FB_Fin;
        private FlashButton.FlashButton FB_Debut;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;

    }
}