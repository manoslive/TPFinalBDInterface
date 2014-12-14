namespace TPFinal
{
    partial class Form_Matchs
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
            this.LB_EquipeHome = new System.Windows.Forms.Label();
            this.LB_EquipeAway = new System.Windows.Forms.Label();
            this.DGV_Matchs = new System.Windows.Forms.DataGridView();
            this.CM_Match = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            this.LB_ScoreAway = new System.Windows.Forms.Label();
            this.LB_ScoreHome = new System.Windows.Forms.Label();
            this.LB_NbButsHome = new System.Windows.Forms.Label();
            this.LB_NbButsAway = new System.Windows.Forms.Label();
            this.TB_Receveur = new System.Windows.Forms.TextBox();
            this.TB_Visiteur = new System.Windows.Forms.TextBox();
            this.MS_Equipe = new System.Windows.Forms.MenuStrip();
            this.fonctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PB_Milieu = new System.Windows.Forms.PictureBox();
            this.FB_Statistiques = new FlashButton.FlashButton();
            this.FB_ModifierMatch = new FlashButton.FlashButton();
            this.FB_AjoutRencontre = new FlashButton.FlashButton();
            this.FB_Calendrier = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PB_Faceoff = new System.Windows.Forms.PictureBox();
            this.PB_EquipeHome = new System.Windows.Forms.PictureBox();
            this.PB_EquipeAway = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).BeginInit();
            this.CM_Match.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            this.MS_Equipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Milieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Faceoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_EquipeHome
            // 
            this.LB_EquipeHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_EquipeHome.AutoSize = true;
            this.LB_EquipeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EquipeHome.Location = new System.Drawing.Point(254, 42);
            this.LB_EquipeHome.Name = "LB_EquipeHome";
            this.LB_EquipeHome.Size = new System.Drawing.Size(169, 25);
            this.LB_EquipeHome.TabIndex = 0;
            this.LB_EquipeHome.Text = "Équipe receveur";
            // 
            // LB_EquipeAway
            // 
            this.LB_EquipeAway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_EquipeAway.AutoSize = true;
            this.LB_EquipeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EquipeAway.Location = new System.Drawing.Point(753, 42);
            this.LB_EquipeAway.Name = "LB_EquipeAway";
            this.LB_EquipeAway.Size = new System.Drawing.Size(154, 25);
            this.LB_EquipeAway.TabIndex = 0;
            this.LB_EquipeAway.Text = "Équipe visiteur";
            // 
            // DGV_Matchs
            // 
            this.DGV_Matchs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Matchs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Matchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Matchs.ContextMenuStrip = this.CM_Match;
            this.DGV_Matchs.Location = new System.Drawing.Point(12, 265);
            this.DGV_Matchs.MultiSelect = false;
            this.DGV_Matchs.Name = "DGV_Matchs";
            this.DGV_Matchs.ReadOnly = true;
            this.DGV_Matchs.RowHeadersVisible = false;
            this.DGV_Matchs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Matchs.RowTemplate.Height = 28;
            this.DGV_Matchs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Matchs.Size = new System.Drawing.Size(1144, 155);
            this.DGV_Matchs.TabIndex = 5;
            this.DGV_Matchs.SelectionChanged += new System.EventHandler(this.DGV_Matchs_SelectionChanged);
            // 
            // CM_Match
            // 
            this.CM_Match.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMatchToolStripMenuItem,
            this.modifierMatchToolStripMenuItem,
            this.ajouterStatsToolStripMenuItem,
            this.calendrierToolStripMenuItem});
            this.CM_Match.Name = "CM_Match";
            this.CM_Match.Size = new System.Drawing.Size(206, 124);
            // 
            // ajouterMatchToolStripMenuItem
            // 
            this.ajouterMatchToolStripMenuItem.Name = "ajouterMatchToolStripMenuItem";
            this.ajouterMatchToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.ajouterMatchToolStripMenuItem.Text = "Ajouter match";
            this.ajouterMatchToolStripMenuItem.Click += new System.EventHandler(this.ajouterMatchToolStripMenuItem_Click);
            // 
            // modifierMatchToolStripMenuItem
            // 
            this.modifierMatchToolStripMenuItem.Name = "modifierMatchToolStripMenuItem";
            this.modifierMatchToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.modifierMatchToolStripMenuItem.Text = "Modifier match";
            this.modifierMatchToolStripMenuItem.Click += new System.EventHandler(this.modifierMatchToolStripMenuItem_Click);
            // 
            // ajouterStatsToolStripMenuItem
            // 
            this.ajouterStatsToolStripMenuItem.Name = "ajouterStatsToolStripMenuItem";
            this.ajouterStatsToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.ajouterStatsToolStripMenuItem.Text = "Ajouter stats";
            this.ajouterStatsToolStripMenuItem.Click += new System.EventHandler(this.ajouterStatsToolStripMenuItem_Click);
            // 
            // calendrierToolStripMenuItem
            // 
            this.calendrierToolStripMenuItem.Name = "calendrierToolStripMenuItem";
            this.calendrierToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.calendrierToolStripMenuItem.Text = "Calendrier";
            this.calendrierToolStripMenuItem.Click += new System.EventHandler(this.calendrierToolStripMenuItem_Click);
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Joueurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.ContextMenuStrip = this.CM_Match;
            this.DGV_Joueurs.Location = new System.Drawing.Point(12, 498);
            this.DGV_Joueurs.MultiSelect = false;
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.ReadOnly = true;
            this.DGV_Joueurs.RowHeadersVisible = false;
            this.DGV_Joueurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Joueurs.RowTemplate.Height = 28;
            this.DGV_Joueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Joueurs.Size = new System.Drawing.Size(1143, 155);
            this.DGV_Joueurs.TabIndex = 5;
            this.DGV_Joueurs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Joueurs_CellMouseDoubleClick);
            // 
            // LB_ScoreAway
            // 
            this.LB_ScoreAway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_ScoreAway.AutoSize = true;
            this.LB_ScoreAway.Location = new System.Drawing.Point(795, 143);
            this.LB_ScoreAway.Name = "LB_ScoreAway";
            this.LB_ScoreAway.Size = new System.Drawing.Size(84, 20);
            this.LB_ScoreAway.TabIndex = 7;
            this.LB_ScoreAway.Text = "Score final";
            // 
            // LB_ScoreHome
            // 
            this.LB_ScoreHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_ScoreHome.AutoSize = true;
            this.LB_ScoreHome.Location = new System.Drawing.Point(298, 143);
            this.LB_ScoreHome.Name = "LB_ScoreHome";
            this.LB_ScoreHome.Size = new System.Drawing.Size(84, 20);
            this.LB_ScoreHome.TabIndex = 7;
            this.LB_ScoreHome.Text = "Score final";
            // 
            // LB_NbButsHome
            // 
            this.LB_NbButsHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_NbButsHome.AutoSize = true;
            this.LB_NbButsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NbButsHome.Location = new System.Drawing.Point(321, 177);
            this.LB_NbButsHome.Name = "LB_NbButsHome";
            this.LB_NbButsHome.Size = new System.Drawing.Size(36, 37);
            this.LB_NbButsHome.TabIndex = 8;
            this.LB_NbButsHome.Text = "#";
            // 
            // LB_NbButsAway
            // 
            this.LB_NbButsAway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_NbButsAway.AutoSize = true;
            this.LB_NbButsAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NbButsAway.Location = new System.Drawing.Point(826, 177);
            this.LB_NbButsAway.Name = "LB_NbButsAway";
            this.LB_NbButsAway.Size = new System.Drawing.Size(36, 37);
            this.LB_NbButsAway.TabIndex = 8;
            this.LB_NbButsAway.Text = "#";
            // 
            // TB_Receveur
            // 
            this.TB_Receveur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Receveur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Receveur.Location = new System.Drawing.Point(258, 85);
            this.TB_Receveur.Name = "TB_Receveur";
            this.TB_Receveur.ReadOnly = true;
            this.TB_Receveur.Size = new System.Drawing.Size(165, 19);
            this.TB_Receveur.TabIndex = 9;
            this.TB_Receveur.Text = "Home";
            this.TB_Receveur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Visiteur
            // 
            this.TB_Visiteur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_Visiteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Visiteur.Location = new System.Drawing.Point(753, 85);
            this.TB_Visiteur.Name = "TB_Visiteur";
            this.TB_Visiteur.ReadOnly = true;
            this.TB_Visiteur.Size = new System.Drawing.Size(165, 19);
            this.TB_Visiteur.TabIndex = 9;
            this.TB_Visiteur.Text = "Away";
            this.TB_Visiteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MS_Equipe
            // 
            this.MS_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonctionsToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MS_Equipe.Location = new System.Drawing.Point(0, 0);
            this.MS_Equipe.Name = "MS_Equipe";
            this.MS_Equipe.Size = new System.Drawing.Size(1168, 33);
            this.MS_Equipe.TabIndex = 14;
            this.MS_Equipe.Text = "menuStrip1";
            // 
            // fonctionsToolStripMenuItem
            // 
            this.fonctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchsToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.calendrierToolStripMenuItem1,
            this.quitterToolStripMenuItem1});
            this.fonctionsToolStripMenuItem.Name = "fonctionsToolStripMenuItem";
            this.fonctionsToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.fonctionsToolStripMenuItem.Text = "Fonctions";
            // 
            // matchsToolStripMenuItem
            // 
            this.matchsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.matchsToolStripMenuItem.Name = "matchsToolStripMenuItem";
            this.matchsToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.matchsToolStripMenuItem.Text = "Matchs";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1});
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.statistiqueToolStripMenuItem.Text = "Statistiques";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.ajouterToolStripMenuItem1.Text = "Ajouter...";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // calendrierToolStripMenuItem1
            // 
            this.calendrierToolStripMenuItem1.Name = "calendrierToolStripMenuItem1";
            this.calendrierToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.calendrierToolStripMenuItem1.Size = new System.Drawing.Size(278, 30);
            this.calendrierToolStripMenuItem1.Text = "Calendrier...";
            this.calendrierToolStripMenuItem1.Click += new System.EventHandler(this.calendrierToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(278, 30);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.paramètresToolStripMenuItem.Text = "Paramètres...";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 29);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // PB_Milieu
            // 
            this.PB_Milieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Milieu.BackColor = System.Drawing.Color.Transparent;
            this.PB_Milieu.BackgroundImage = global::TPFinal.Properties.Resources.LigneMilieu;
            this.PB_Milieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Milieu.Location = new System.Drawing.Point(154, 335);
            this.PB_Milieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Milieu.Name = "PB_Milieu";
            this.PB_Milieu.Size = new System.Drawing.Size(864, 248);
            this.PB_Milieu.TabIndex = 19;
            this.PB_Milieu.TabStop = false;
            // 
            // FB_Statistiques
            // 
            this.FB_Statistiques.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FB_Statistiques.BackColor = System.Drawing.Color.Transparent;
            this.FB_Statistiques.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Statistiques.ImageClick = global::TPFinal.Properties.Resources.ICON_Stats_Click;
            this.FB_Statistiques.ImageDisable = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.ImageOver = global::TPFinal.Properties.Resources.ICON_Stats_Over;
            this.FB_Statistiques.Location = new System.Drawing.Point(1102, 431);
            this.FB_Statistiques.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Statistiques.Name = "FB_Statistiques";
            this.FB_Statistiques.Size = new System.Drawing.Size(54, 55);
            this.FB_Statistiques.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FB_Statistiques, "Statistiques du joueur sélectionné...");
            this.FB_Statistiques.Click += new System.EventHandler(this.BTN_AjoutStats_Click_1);
            // 
            // FB_ModifierMatch
            // 
            this.FB_ModifierMatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FB_ModifierMatch.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierMatch.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Modifier;
            this.FB_ModifierMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierMatch.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Modifier_Click;
            this.FB_ModifierMatch.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Modifier;
            this.FB_ModifierMatch.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Modifier;
            this.FB_ModifierMatch.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Modifier_Over;
            this.FB_ModifierMatch.Location = new System.Drawing.Point(84, 426);
            this.FB_ModifierMatch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_ModifierMatch.Name = "FB_ModifierMatch";
            this.FB_ModifierMatch.Size = new System.Drawing.Size(60, 62);
            this.FB_ModifierMatch.TabIndex = 17;
            this.toolTip1.SetToolTip(this.FB_ModifierMatch, "Modifier un match...");
            this.FB_ModifierMatch.Click += new System.EventHandler(this.BTN_ModifierMatch_Click);
            // 
            // FB_AjoutRencontre
            // 
            this.FB_AjoutRencontre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FB_AjoutRencontre.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjoutRencontre.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_AjoutRencontre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjoutRencontre.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Click;
            this.FB_AjoutRencontre.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_AjoutRencontre.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_AjoutRencontre.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Over;
            this.FB_AjoutRencontre.Location = new System.Drawing.Point(12, 426);
            this.FB_AjoutRencontre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_AjoutRencontre.Name = "FB_AjoutRencontre";
            this.FB_AjoutRencontre.Size = new System.Drawing.Size(60, 62);
            this.FB_AjoutRencontre.TabIndex = 16;
            this.toolTip1.SetToolTip(this.FB_AjoutRencontre, "Ajouter un match...");
            this.FB_AjoutRencontre.Click += new System.EventHandler(this.BTN_AjoutRencontre_Click);
            // 
            // FB_Calendrier
            // 
            this.FB_Calendrier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FB_Calendrier.BackColor = System.Drawing.Color.Transparent;
            this.FB_Calendrier.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Calendrier;
            this.FB_Calendrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Calendrier.ImageClick = global::TPFinal.Properties.Resources.ICON_Calendrier_Click;
            this.FB_Calendrier.ImageDisable = global::TPFinal.Properties.Resources.ICON_Calendrier;
            this.FB_Calendrier.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Calendrier;
            this.FB_Calendrier.ImageOver = global::TPFinal.Properties.Resources.ICON_Calendrier_Over;
            this.FB_Calendrier.Location = new System.Drawing.Point(1029, 426);
            this.FB_Calendrier.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Calendrier.Name = "FB_Calendrier";
            this.FB_Calendrier.Size = new System.Drawing.Size(60, 62);
            this.FB_Calendrier.TabIndex = 15;
            this.toolTip1.SetToolTip(this.FB_Calendrier, "Afficher un autre match...");
            this.FB_Calendrier.Click += new System.EventHandler(this.BTN_Calendrier_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(1096, 662);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(60, 62);
            this.PB_Fermer_Gif.TabIndex = 11;
            this.PB_Fermer_Gif.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_Fermer_Gif, "Quitter");
            this.PB_Fermer_Gif.Visible = false;
            this.PB_Fermer_Gif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseDown);
            this.PB_Fermer_Gif.MouseLeave += new System.EventHandler(this.PB_Fermer_Gif_MouseLeave);
            this.PB_Fermer_Gif.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseUp);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Fermer.BackColor = System.Drawing.Color.Transparent;
            this.FB_Fermer.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::TPFinal.Properties.Resources.ICON_Fermer_Click;
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(1096, 657);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(60, 62);
            this.FB_Fermer.TabIndex = 10;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // PB_Faceoff
            // 
            this.PB_Faceoff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_Faceoff.Image = global::TPFinal.Properties.Resources.hockey_face_off;
            this.PB_Faceoff.Location = new System.Drawing.Point(450, 42);
            this.PB_Faceoff.Name = "PB_Faceoff";
            this.PB_Faceoff.Size = new System.Drawing.Size(297, 186);
            this.PB_Faceoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Faceoff.TabIndex = 6;
            this.PB_Faceoff.TabStop = false;
            // 
            // PB_EquipeHome
            // 
            this.PB_EquipeHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_EquipeHome.Location = new System.Drawing.Point(12, 42);
            this.PB_EquipeHome.Name = "PB_EquipeHome";
            this.PB_EquipeHome.Size = new System.Drawing.Size(224, 206);
            this.PB_EquipeHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_EquipeHome.TabIndex = 1;
            this.PB_EquipeHome.TabStop = false;
            // 
            // PB_EquipeAway
            // 
            this.PB_EquipeAway.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PB_EquipeAway.Location = new System.Drawing.Point(932, 42);
            this.PB_EquipeAway.Name = "PB_EquipeAway";
            this.PB_EquipeAway.Size = new System.Drawing.Size(224, 206);
            this.PB_EquipeAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_EquipeAway.TabIndex = 1;
            this.PB_EquipeAway.TabStop = false;
            // 
            // Form_Matchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 743);
            this.ContextMenuStrip = this.CM_Match;
            this.Controls.Add(this.PB_Milieu);
            this.Controls.Add(this.FB_Statistiques);
            this.Controls.Add(this.FB_ModifierMatch);
            this.Controls.Add(this.FB_AjoutRencontre);
            this.Controls.Add(this.FB_Calendrier);
            this.Controls.Add(this.MS_Equipe);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.TB_Visiteur);
            this.Controls.Add(this.TB_Receveur);
            this.Controls.Add(this.LB_NbButsAway);
            this.Controls.Add(this.LB_NbButsHome);
            this.Controls.Add(this.LB_ScoreHome);
            this.Controls.Add(this.LB_ScoreAway);
            this.Controls.Add(this.PB_Faceoff);
            this.Controls.Add(this.DGV_Joueurs);
            this.Controls.Add(this.DGV_Matchs);
            this.Controls.Add(this.PB_EquipeHome);
            this.Controls.Add(this.PB_EquipeAway);
            this.Controls.Add(this.LB_EquipeAway);
            this.Controls.Add(this.LB_EquipeHome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1774, 1170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1182, 773);
            this.Name = "Form_Matchs";
            this.Text = "Form_Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Matchs_FormClosed);
            this.Load += new System.EventHandler(this.Form_Matchs_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Matchs_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).EndInit();
            this.CM_Match.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            this.MS_Equipe.ResumeLayout(false);
            this.MS_Equipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Milieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Faceoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_EquipeHome;
        private System.Windows.Forms.Label LB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeHome;
        private System.Windows.Forms.DataGridView DGV_Matchs;
        private System.Windows.Forms.DataGridView DGV_Joueurs;
        private System.Windows.Forms.PictureBox PB_Faceoff;
        private System.Windows.Forms.Label LB_ScoreAway;
        private System.Windows.Forms.Label LB_ScoreHome;
        private System.Windows.Forms.Label LB_NbButsHome;
        private System.Windows.Forms.Label LB_NbButsAway;
        private System.Windows.Forms.TextBox TB_Receveur;
        private System.Windows.Forms.TextBox TB_Visiteur;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.ContextMenuStrip CM_Match;
        private System.Windows.Forms.ToolStripMenuItem ajouterMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendrierToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MS_Equipe;
        private System.Windows.Forms.ToolStripMenuItem fonctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matchsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendrierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private FlashButton.FlashButton FB_Calendrier;
        private FlashButton.FlashButton FB_AjoutRencontre;
        private FlashButton.FlashButton FB_ModifierMatch;
        private FlashButton.FlashButton FB_Statistiques;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PB_Milieu;

    }
}