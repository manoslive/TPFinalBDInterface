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
            this.components = new System.ComponentModel.Container();
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
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.LB_NumMatch = new System.Windows.Forms.Label();
            this.TB_NumMatch = new System.Windows.Forms.TextBox();
            this.TB_Equipe = new System.Windows.Forms.TextBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_Precedent = new FlashButton.FlashButton();
            this.FB_Suivant = new FlashButton.FlashButton();
            this.FB_Fin = new FlashButton.FlashButton();
            this.FB_Debut = new FlashButton.FlashButton();
            this.FB_SupprimerStat = new FlashButton.FlashButton();
            this.FB_ModifierStat = new FlashButton.FlashButton();
            this.FB_AjouterStat = new FlashButton.FlashButton();
            this.CM_Stats = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dernierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dernierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.CM_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Stats
            // 
            this.DGV_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stats.Location = new System.Drawing.Point(9, 609);
            this.DGV_Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Stats.Name = "DGV_Stats";
            this.DGV_Stats.Size = new System.Drawing.Size(218, 35);
            this.DGV_Stats.TabIndex = 28;
            this.DGV_Stats.Visible = false;
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
            this.LB_NbPoints.Location = new System.Drawing.Point(8, 408);
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
            this.TB_NbPoints.Location = new System.Drawing.Point(190, 408);
            this.TB_NbPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPoints.Name = "TB_NbPoints";
            this.TB_NbPoints.ReadOnly = true;
            this.TB_NbPoints.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPoints.TabIndex = 25;
            this.TB_NbPoints.TabStop = false;
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(190, 354);
            this.TB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.ReadOnly = true;
            this.TB_NbPasses.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPasses.TabIndex = 24;
            this.TB_NbPasses.TabStop = false;
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(190, 300);
            this.TB_NbButs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.ReadOnly = true;
            this.TB_NbButs.Size = new System.Drawing.Size(170, 26);
            this.TB_NbButs.TabIndex = 23;
            this.TB_NbButs.TabStop = false;
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(190, 75);
            this.TB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(170, 26);
            this.TB_NumJoueur.TabIndex = 12;
            this.TB_NumJoueur.TabStop = false;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(190, 135);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(170, 26);
            this.TB_Nom.TabIndex = 20;
            this.TB_Nom.TabStop = false;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(190, 189);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.ReadOnly = true;
            this.TB_Prenom.Size = new System.Drawing.Size(170, 26);
            this.TB_Prenom.TabIndex = 21;
            this.TB_Prenom.TabStop = false;
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(190, 457);
            this.TB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.ReadOnly = true;
            this.TB_TempsPunition.Size = new System.Drawing.Size(170, 26);
            this.TB_TempsPunition.TabIndex = 26;
            this.TB_TempsPunition.TabStop = false;
            // 
            // LB_NumMatch
            // 
            this.LB_NumMatch.AutoSize = true;
            this.LB_NumMatch.Location = new System.Drawing.Point(4, 25);
            this.LB_NumMatch.Name = "LB_NumMatch";
            this.LB_NumMatch.Size = new System.Drawing.Size(113, 20);
            this.LB_NumMatch.TabIndex = 36;
            this.LB_NumMatch.Text = "Numéro match";
            // 
            // TB_NumMatch
            // 
            this.TB_NumMatch.Location = new System.Drawing.Point(192, 22);
            this.TB_NumMatch.Name = "TB_NumMatch";
            this.TB_NumMatch.ReadOnly = true;
            this.TB_NumMatch.Size = new System.Drawing.Size(170, 26);
            this.TB_NumMatch.TabIndex = 37;
            this.TB_NumMatch.TabStop = false;
            // 
            // TB_Equipe
            // 
            this.TB_Equipe.Location = new System.Drawing.Point(190, 242);
            this.TB_Equipe.Name = "TB_Equipe";
            this.TB_Equipe.ReadOnly = true;
            this.TB_Equipe.Size = new System.Drawing.Size(170, 26);
            this.TB_Equipe.TabIndex = 47;
            this.TB_Equipe.TabStop = false;
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(446, 517);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(69, 63);
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
            this.FB_Fermer.Location = new System.Drawing.Point(446, 517);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(69, 63);
            this.FB_Fermer.TabIndex = 45;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
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
            this.FB_Precedent.Location = new System.Drawing.Point(114, 517);
            this.FB_Precedent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Precedent.Name = "FB_Precedent";
            this.FB_Precedent.Size = new System.Drawing.Size(60, 62);
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
            this.FB_Suivant.Location = new System.Drawing.Point(210, 517);
            this.FB_Suivant.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Suivant.Name = "FB_Suivant";
            this.FB_Suivant.Size = new System.Drawing.Size(60, 62);
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
            this.FB_Fin.Location = new System.Drawing.Point(279, 517);
            this.FB_Fin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fin.Name = "FB_Fin";
            this.FB_Fin.Size = new System.Drawing.Size(60, 62);
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
            this.FB_Debut.Location = new System.Drawing.Point(45, 517);
            this.FB_Debut.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Debut.Name = "FB_Debut";
            this.FB_Debut.Size = new System.Drawing.Size(60, 62);
            this.FB_Debut.TabIndex = 41;
            this.FB_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
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
            this.FB_SupprimerStat.Location = new System.Drawing.Point(446, 208);
            this.FB_SupprimerStat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_SupprimerStat.Name = "FB_SupprimerStat";
            this.FB_SupprimerStat.Size = new System.Drawing.Size(69, 71);
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
            this.FB_ModifierStat.Location = new System.Drawing.Point(446, 122);
            this.FB_ModifierStat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_ModifierStat.Name = "FB_ModifierStat";
            this.FB_ModifierStat.Size = new System.Drawing.Size(69, 71);
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
            this.FB_AjouterStat.Location = new System.Drawing.Point(446, 35);
            this.FB_AjouterStat.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_AjouterStat.Name = "FB_AjouterStat";
            this.FB_AjouterStat.Size = new System.Drawing.Size(69, 71);
            this.FB_AjouterStat.TabIndex = 38;
            this.FB_AjouterStat.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // CM_Stats
            // 
            this.CM_Stats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.premierToolStripMenuItem,
            this.dernierToolStripMenuItem,
            this.premierToolStripMenuItem1,
            this.dernierToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.CM_Stats.Name = "CM_Stats";
            this.CM_Stats.Size = new System.Drawing.Size(168, 244);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // premierToolStripMenuItem
            // 
            this.premierToolStripMenuItem.Name = "premierToolStripMenuItem";
            this.premierToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.premierToolStripMenuItem.Text = "Suivant";
            this.premierToolStripMenuItem.Click += new System.EventHandler(this.premierToolStripMenuItem_Click);
            // 
            // dernierToolStripMenuItem
            // 
            this.dernierToolStripMenuItem.Name = "dernierToolStripMenuItem";
            this.dernierToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.dernierToolStripMenuItem.Text = "Précédent";
            this.dernierToolStripMenuItem.Click += new System.EventHandler(this.dernierToolStripMenuItem_Click);
            // 
            // premierToolStripMenuItem1
            // 
            this.premierToolStripMenuItem1.Name = "premierToolStripMenuItem1";
            this.premierToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.premierToolStripMenuItem1.Text = "Premier";
            this.premierToolStripMenuItem1.Click += new System.EventHandler(this.premierToolStripMenuItem1_Click);
            // 
            // dernierToolStripMenuItem1
            // 
            this.dernierToolStripMenuItem1.Name = "dernierToolStripMenuItem1";
            this.dernierToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.dernierToolStripMenuItem1.Text = "Dernier";
            this.dernierToolStripMenuItem1.Click += new System.EventHandler(this.dernierToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 588);
            this.ContextMenuStrip = this.CM_Stats;
            this.Controls.Add(this.TB_Equipe);
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
            this.Name = "Form_Statistiques";
            this.Text = "Form_Statistiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Statistiques_FormClosing);
            this.Load += new System.EventHandler(this.Form_Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.CM_Stats.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TB_Equipe;
        private System.Windows.Forms.ContextMenuStrip CM_Stats;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dernierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dernierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;

    }
}