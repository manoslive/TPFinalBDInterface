namespace TPFinal
{
    partial class Form_Equipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Equipes));
            this.DGV_Equipes = new System.Windows.Forms.DataGridView();
            this.CM_EquipeDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.LB_Division = new System.Windows.Forms.Label();
            this.toolTip_Equipe = new System.Windows.Forms.ToolTip(this.components);
            this.FB_SupprimerEquipe = new FlashButton.FlashButton();
            this.FB_Matchs = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_ModifierEquipe = new FlashButton.FlashButton();
            this.FB_AjouterEquipe = new FlashButton.FlashButton();
            this.FB_Classement = new FlashButton.FlashButton();
            this.FB_Top3 = new FlashButton.FlashButton();
            this.MS_Equipe = new System.Windows.Forms.MenuStrip();
            this.fonctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.équipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.top3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CM_Equipe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_Division = new FlashButton.FlashButton();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.FB_Statistiques = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            this.CM_EquipeDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.MS_Equipe.SuspendLayout();
            this.CM_Equipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Equipes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.ContextMenuStrip = this.CM_EquipeDGV;
            this.DGV_Equipes.Location = new System.Drawing.Point(22, 43);
            this.DGV_Equipes.MultiSelect = false;
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.ReadOnly = true;
            this.DGV_Equipes.RowHeadersVisible = false;
            this.DGV_Equipes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Equipes.RowTemplate.Height = 28;
            this.DGV_Equipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Equipes.Size = new System.Drawing.Size(586, 248);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Equipes_CellMouseDoubleClick);
            this.DGV_Equipes.SelectionChanged += new System.EventHandler(this.DGV_Equipes_SelectionChanged);
            // 
            // CM_EquipeDGV
            // 
            this.CM_EquipeDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierMatchToolStripMenuItem,
            this.supprimerMatchToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.CM_EquipeDGV.Name = "contextMenuStrip1";
            this.CM_EquipeDGV.Size = new System.Drawing.Size(222, 124);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter match";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierMatchToolStripMenuItem
            // 
            this.modifierMatchToolStripMenuItem.Name = "modifierMatchToolStripMenuItem";
            this.modifierMatchToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.modifierMatchToolStripMenuItem.Text = "Modifier match";
            this.modifierMatchToolStripMenuItem.Click += new System.EventHandler(this.modifierMatchToolStripMenuItem_Click);
            // 
            // supprimerMatchToolStripMenuItem
            // 
            this.supprimerMatchToolStripMenuItem.Name = "supprimerMatchToolStripMenuItem";
            this.supprimerMatchToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.supprimerMatchToolStripMenuItem.Text = "Supprimer match";
            this.supprimerMatchToolStripMenuItem.Click += new System.EventHandler(this.supprimerMatchToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // CB_Division
            // 
            this.CB_Division.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Toutes"});
            this.CB_Division.Location = new System.Drawing.Point(454, 338);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(152, 28);
            this.CB_Division.TabIndex = 7;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // LB_Division
            // 
            this.LB_Division.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(453, 315);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 4;
            this.LB_Division.Text = "Division";
            // 
            // FB_SupprimerEquipe
            // 
            this.FB_SupprimerEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_SupprimerEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_SupprimerEquipe.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_SupprimerEquipe.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Click;
            this.FB_SupprimerEquipe.ImageDisable = null;
            this.FB_SupprimerEquipe.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerEquipe.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Over;
            this.FB_SupprimerEquipe.Location = new System.Drawing.Point(704, 237);
            this.FB_SupprimerEquipe.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_SupprimerEquipe.Name = "FB_SupprimerEquipe";
            this.FB_SupprimerEquipe.Size = new System.Drawing.Size(69, 71);
            this.FB_SupprimerEquipe.TabIndex = 2;
            this.toolTip_Equipe.SetToolTip(this.FB_SupprimerEquipe, "Supprimer une équipe");
            this.FB_SupprimerEquipe.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // FB_Matchs
            // 
            this.FB_Matchs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Matchs.BackColor = System.Drawing.Color.Transparent;
            this.FB_Matchs.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Match_Over;
            this.FB_Matchs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Matchs.ImageClick = global::TPFinal.Properties.Resources.ICON_Match_Click;
            this.FB_Matchs.ImageDisable = null;
            this.FB_Matchs.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Match_Over;
            this.FB_Matchs.ImageOver = global::TPFinal.Properties.Resources.ICON_Match;
            this.FB_Matchs.Location = new System.Drawing.Point(22, 315);
            this.FB_Matchs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Matchs.Name = "FB_Matchs";
            this.FB_Matchs.Size = new System.Drawing.Size(54, 55);
            this.FB_Matchs.TabIndex = 15;
            this.toolTip_Equipe.SetToolTip(this.FB_Matchs, "Matchs");
            this.FB_Matchs.Click += new System.EventHandler(this.BTN_Matchs_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Fermer_Gif.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(704, 308);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(69, 63);
            this.PB_Fermer_Gif.TabIndex = 12;
            this.PB_Fermer_Gif.TabStop = false;
            this.toolTip_Equipe.SetToolTip(this.PB_Fermer_Gif, "Fermer");
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
            this.FB_Fermer.ImageDisable = null;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(704, 311);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(69, 63);
            this.FB_Fermer.TabIndex = 11;
            this.toolTip_Equipe.SetToolTip(this.FB_Fermer, "Supprimer une équipe");
            this.FB_Fermer.Click += new System.EventHandler(this.BTN_Ok_Click);
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // FB_ModifierEquipe
            // 
            this.FB_ModifierEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_ModifierEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierEquipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.BackgroundImage")));
            this.FB_ModifierEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierEquipe.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageClick")));
            this.FB_ModifierEquipe.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageDisable")));
            this.FB_ModifierEquipe.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageNeutral")));
            this.FB_ModifierEquipe.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageOver")));
            this.FB_ModifierEquipe.Location = new System.Drawing.Point(740, 169);
            this.FB_ModifierEquipe.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_ModifierEquipe.Name = "FB_ModifierEquipe";
            this.FB_ModifierEquipe.Size = new System.Drawing.Size(69, 71);
            this.FB_ModifierEquipe.TabIndex = 1;
            this.toolTip_Equipe.SetToolTip(this.FB_ModifierEquipe, "Modifier une équipe");
            this.FB_ModifierEquipe.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // FB_AjouterEquipe
            // 
            this.FB_AjouterEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_AjouterEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterEquipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.BackgroundImage")));
            this.FB_AjouterEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjouterEquipe.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageClick")));
            this.FB_AjouterEquipe.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageDisable")));
            this.FB_AjouterEquipe.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageNeutral")));
            this.FB_AjouterEquipe.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageOver")));
            this.FB_AjouterEquipe.Location = new System.Drawing.Point(670, 169);
            this.FB_AjouterEquipe.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_AjouterEquipe.Name = "FB_AjouterEquipe";
            this.FB_AjouterEquipe.Size = new System.Drawing.Size(69, 71);
            this.FB_AjouterEquipe.TabIndex = 0;
            this.toolTip_Equipe.SetToolTip(this.FB_AjouterEquipe, "Ajouter une équipe");
            this.FB_AjouterEquipe.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // FB_Classement
            // 
            this.FB_Classement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Classement.BackColor = System.Drawing.Color.Transparent;
            this.FB_Classement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Classement.BackgroundImage")));
            this.FB_Classement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Classement.ImageClick = global::TPFinal.Properties.Resources.ICON_Classement_Click;
            this.FB_Classement.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Classement.ImageDisable")));
            this.FB_Classement.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Classement.ImageNeutral")));
            this.FB_Classement.ImageOver = global::TPFinal.Properties.Resources.ICON_Classement_Over;
            this.FB_Classement.Location = new System.Drawing.Point(184, 315);
            this.FB_Classement.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Classement.Name = "FB_Classement";
            this.FB_Classement.Size = new System.Drawing.Size(54, 55);
            this.FB_Classement.TabIndex = 5;
            this.toolTip_Equipe.SetToolTip(this.FB_Classement, "Classement");
            this.FB_Classement.Click += new System.EventHandler(this.BTN_Classement_Click);
            // 
            // FB_Top3
            // 
            this.FB_Top3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Top3.BackColor = System.Drawing.Color.Transparent;
            this.FB_Top3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Top3.BackgroundImage")));
            this.FB_Top3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Top3.ImageClick = global::TPFinal.Properties.Resources.ICON_Top3_Click;
            this.FB_Top3.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Top3.ImageDisable")));
            this.FB_Top3.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Top3.ImageNeutral")));
            this.FB_Top3.ImageOver = global::TPFinal.Properties.Resources.ICON_Top3_Over;
            this.FB_Top3.Location = new System.Drawing.Point(266, 315);
            this.FB_Top3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Top3.Name = "FB_Top3";
            this.FB_Top3.Size = new System.Drawing.Size(54, 55);
            this.FB_Top3.TabIndex = 6;
            this.toolTip_Equipe.SetToolTip(this.FB_Top3, "Top 3");
            this.FB_Top3.Click += new System.EventHandler(this.BTN_Top5_Click);
            // 
            // MS_Equipe
            // 
            this.MS_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonctionsToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MS_Equipe.Location = new System.Drawing.Point(0, 0);
            this.MS_Equipe.Name = "MS_Equipe";
            this.MS_Equipe.Size = new System.Drawing.Size(832, 33);
            this.MS_Equipe.TabIndex = 13;
            this.MS_Equipe.Text = "menuStrip1";
            // 
            // fonctionsToolStripMenuItem
            // 
            this.fonctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.équipesToolStripMenuItem,
            this.matchToolStripMenuItem1,
            this.divisionsToolStripMenuItem,
            this.classementToolStripMenuItem1,
            this.top3ToolStripMenuItem1,
            this.joueursToolStripMenuItem,
            this.quitterToolStripMenuItem2});
            this.fonctionsToolStripMenuItem.Name = "fonctionsToolStripMenuItem";
            this.fonctionsToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.fonctionsToolStripMenuItem.Text = "Fonctions...";
            // 
            // équipesToolStripMenuItem
            // 
            this.équipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.équipesToolStripMenuItem.Name = "équipesToolStripMenuItem";
            this.équipesToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.équipesToolStripMenuItem.Text = "Équipes...";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
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
            // matchToolStripMenuItem1
            // 
            this.matchToolStripMenuItem1.Name = "matchToolStripMenuItem1";
            this.matchToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.matchToolStripMenuItem1.Text = "Matchs";
            this.matchToolStripMenuItem1.Click += new System.EventHandler(this.matchToolStripMenuItem1_Click);
            // 
            // divisionsToolStripMenuItem
            // 
            this.divisionsToolStripMenuItem.Name = "divisionsToolStripMenuItem";
            this.divisionsToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.divisionsToolStripMenuItem.Text = "Divisions";
            this.divisionsToolStripMenuItem.Click += new System.EventHandler(this.divisionsToolStripMenuItem_Click);
            // 
            // classementToolStripMenuItem1
            // 
            this.classementToolStripMenuItem1.Name = "classementToolStripMenuItem1";
            this.classementToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.classementToolStripMenuItem1.Text = "Classement";
            this.classementToolStripMenuItem1.Click += new System.EventHandler(this.classementToolStripMenuItem1_Click);
            // 
            // top3ToolStripMenuItem1
            // 
            this.top3ToolStripMenuItem1.Name = "top3ToolStripMenuItem1";
            this.top3ToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.top3ToolStripMenuItem1.Text = "Top3";
            this.top3ToolStripMenuItem1.Click += new System.EventHandler(this.top3ToolStripMenuItem1_Click);
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.joueursToolStripMenuItem.Text = "Joueurs";
            this.joueursToolStripMenuItem.Click += new System.EventHandler(this.joueursToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem2
            // 
            this.quitterToolStripMenuItem2.Name = "quitterToolStripMenuItem2";
            this.quitterToolStripMenuItem2.Size = new System.Drawing.Size(174, 30);
            this.quitterToolStripMenuItem2.Text = "Quitter";
            this.quitterToolStripMenuItem2.Click += new System.EventHandler(this.quitterToolStripMenuItem2_Click);
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
            // CM_Equipe
            // 
            this.CM_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.classementToolStripMenuItem,
            this.top3ToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.CM_Equipe.Name = "CM_Equipe";
            this.CM_Equipe.Size = new System.Drawing.Size(175, 154);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.matchToolStripMenuItem.Text = "Match";
            this.matchToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.divisionToolStripMenuItem.Text = "Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.classementToolStripMenuItem.Text = "Classement";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // top3ToolStripMenuItem
            // 
            this.top3ToolStripMenuItem.Name = "top3ToolStripMenuItem";
            this.top3ToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.top3ToolStripMenuItem.Text = "Top3";
            this.top3ToolStripMenuItem.Click += new System.EventHandler(this.top3ToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(174, 30);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // FB_Division
            // 
            this.FB_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Division.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Division_Click;
            this.FB_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Division.ImageClick = global::TPFinal.Properties.Resources.ICON_Division_Click;
            this.FB_Division.ImageDisable = null;
            this.FB_Division.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Division_Click;
            this.FB_Division.ImageOver = global::TPFinal.Properties.Resources.ICON_Division;
            this.FB_Division.Location = new System.Drawing.Point(106, 315);
            this.FB_Division.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Division.Name = "FB_Division";
            this.FB_Division.Size = new System.Drawing.Size(54, 55);
            this.FB_Division.TabIndex = 14;
            this.FB_Division.Click += new System.EventHandler(this.BTN_Divisions_Click);
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Equipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Equipe.Location = new System.Drawing.Point(672, 43);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(140, 118);
            this.PB_Equipe.TabIndex = 2;
            this.PB_Equipe.TabStop = false;
            // 
            // FB_Statistiques
            // 
            this.FB_Statistiques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FB_Statistiques.BackColor = System.Drawing.Color.Transparent;
            this.FB_Statistiques.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Statistiques.ImageClick = global::TPFinal.Properties.Resources.ICON_Stats_Click;
            this.FB_Statistiques.ImageDisable = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Stats;
            this.FB_Statistiques.ImageOver = global::TPFinal.Properties.Resources.ICON_Stats_Over;
            this.FB_Statistiques.Location = new System.Drawing.Point(355, 315);
            this.FB_Statistiques.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Statistiques.Name = "FB_Statistiques";
            this.FB_Statistiques.Size = new System.Drawing.Size(54, 55);
            this.FB_Statistiques.TabIndex = 6;
            this.toolTip_Equipe.SetToolTip(this.FB_Statistiques, "Statistique joueur");
            this.FB_Statistiques.Click += new System.EventHandler(this.FB_Statistiques_Click);
            // 
            // Form_Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 389);
            this.ContextMenuStrip = this.CM_Equipe;
            this.Controls.Add(this.FB_Matchs);
            this.Controls.Add(this.FB_Division);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_SupprimerEquipe);
            this.Controls.Add(this.FB_ModifierEquipe);
            this.Controls.Add(this.FB_AjouterEquipe);
            this.Controls.Add(this.FB_Classement);
            this.Controls.Add(this.FB_Statistiques);
            this.Controls.Add(this.FB_Top3);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.PB_Equipe);
            this.Controls.Add(this.DGV_Equipes);
            this.Controls.Add(this.MS_Equipe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.MS_Equipe;
            this.MinimumSize = new System.Drawing.Size(846, 419);
            this.Name = "Form_Equipes";
            this.Text = "Form_Equipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipes_FormClosing);
            this.Load += new System.EventHandler(this.Form_Equipe_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Equipes_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Equipes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            this.CM_EquipeDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.MS_Equipe.ResumeLayout(false);
            this.MS_Equipe.PerformLayout();
            this.CM_Equipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.PictureBox PB_Equipe;
        public System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.Label LB_Division;
        private FlashButton.FlashButton FB_Top3;
        private FlashButton.FlashButton FB_Classement;
        private System.Windows.Forms.ToolTip toolTip_Equipe;
        private FlashButton.FlashButton FB_AjouterEquipe;
        private FlashButton.FlashButton FB_ModifierEquipe;
        private FlashButton.FlashButton FB_SupprimerEquipe;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private System.Windows.Forms.MenuStrip MS_Equipe;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip CM_EquipeDGV;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_Equipe;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fonctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem équipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem divisionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem top3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem2;
        private FlashButton.FlashButton FB_Division;
        private FlashButton.FlashButton FB_Matchs;
        private FlashButton.FlashButton FB_Statistiques;
    }
}