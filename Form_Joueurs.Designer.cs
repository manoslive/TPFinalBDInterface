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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Joueurs));
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
            this.TB_Url = new System.Windows.Forms.TextBox();
            this.LB_Url = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FB_Precedent = new FlashButton.FlashButton();
            this.FB_Suivant = new FlashButton.FlashButton();
            this.FB_Fin = new FlashButton.FlashButton();
            this.FB_Debut = new FlashButton.FlashButton();
            this.FB_SupprimerJoueur = new FlashButton.FlashButton();
            this.FB_ModifierJoueur = new FlashButton.FlashButton();
            this.FB_AjouterJoueur = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PB_Joueur = new System.Windows.Forms.PictureBox();
            this.CM_Joueur = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dernierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dernierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).BeginInit();
            this.CM_Joueur.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(33, 25);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(135, 20);
            this.LB_NumJoueur.TabIndex = 0;
            this.LB_NumJoueur.Text = "Numéro du joueur";
            // 
            // LB_NomJoueur
            // 
            this.LB_NomJoueur.AutoSize = true;
            this.LB_NomJoueur.Location = new System.Drawing.Point(33, 85);
            this.LB_NomJoueur.Name = "LB_NomJoueur";
            this.LB_NomJoueur.Size = new System.Drawing.Size(112, 20);
            this.LB_NomJoueur.TabIndex = 0;
            this.LB_NomJoueur.Text = "Nom du joueur";
            // 
            // LB_PrenomJoueur
            // 
            this.LB_PrenomJoueur.AutoSize = true;
            this.LB_PrenomJoueur.Location = new System.Drawing.Point(33, 145);
            this.LB_PrenomJoueur.Name = "LB_PrenomJoueur";
            this.LB_PrenomJoueur.Size = new System.Drawing.Size(134, 20);
            this.LB_PrenomJoueur.TabIndex = 0;
            this.LB_PrenomJoueur.Text = "Prénom du joueur";
            // 
            // LB_DateNaissance
            // 
            this.LB_DateNaissance.AutoSize = true;
            this.LB_DateNaissance.Location = new System.Drawing.Point(33, 205);
            this.LB_DateNaissance.Name = "LB_DateNaissance";
            this.LB_DateNaissance.Size = new System.Drawing.Size(142, 20);
            this.LB_DateNaissance.TabIndex = 0;
            this.LB_DateNaissance.Text = "Date de naissance";
            // 
            // LB_NumeroMaillot
            // 
            this.LB_NumeroMaillot.AutoSize = true;
            this.LB_NumeroMaillot.Location = new System.Drawing.Point(33, 265);
            this.LB_NumeroMaillot.Name = "LB_NumeroMaillot";
            this.LB_NumeroMaillot.Size = new System.Drawing.Size(136, 20);
            this.LB_NumeroMaillot.TabIndex = 0;
            this.LB_NumeroMaillot.Text = "Numéro du maillot";
            // 
            // LB_EquipeJoueur
            // 
            this.LB_EquipeJoueur.AutoSize = true;
            this.LB_EquipeJoueur.Location = new System.Drawing.Point(33, 325);
            this.LB_EquipeJoueur.Name = "LB_EquipeJoueur";
            this.LB_EquipeJoueur.Size = new System.Drawing.Size(129, 20);
            this.LB_EquipeJoueur.TabIndex = 0;
            this.LB_EquipeJoueur.Text = "Équipe du joueur";
            // 
            // LB_PositionJoueur
            // 
            this.LB_PositionJoueur.AutoSize = true;
            this.LB_PositionJoueur.Location = new System.Drawing.Point(33, 385);
            this.LB_PositionJoueur.Name = "LB_PositionJoueur";
            this.LB_PositionJoueur.Size = new System.Drawing.Size(135, 20);
            this.LB_PositionJoueur.TabIndex = 0;
            this.LB_PositionJoueur.Text = "Position du joueur";
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(237, 22);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(228, 26);
            this.TB_NumJoueur.TabIndex = 1;
            // 
            // TB_NomJoueur
            // 
            this.TB_NomJoueur.Location = new System.Drawing.Point(237, 82);
            this.TB_NomJoueur.Name = "TB_NomJoueur";
            this.TB_NomJoueur.ReadOnly = true;
            this.TB_NomJoueur.Size = new System.Drawing.Size(228, 26);
            this.TB_NomJoueur.TabIndex = 1;
            // 
            // TB_PrenomJoueur
            // 
            this.TB_PrenomJoueur.Location = new System.Drawing.Point(237, 142);
            this.TB_PrenomJoueur.Name = "TB_PrenomJoueur";
            this.TB_PrenomJoueur.ReadOnly = true;
            this.TB_PrenomJoueur.Size = new System.Drawing.Size(228, 26);
            this.TB_PrenomJoueur.TabIndex = 1;
            // 
            // TB_NumMaillot
            // 
            this.TB_NumMaillot.Location = new System.Drawing.Point(237, 262);
            this.TB_NumMaillot.Name = "TB_NumMaillot";
            this.TB_NumMaillot.ReadOnly = true;
            this.TB_NumMaillot.Size = new System.Drawing.Size(228, 26);
            this.TB_NumMaillot.TabIndex = 1;
            // 
            // DTP_DateNaissance
            // 
            this.DTP_DateNaissance.Enabled = false;
            this.DTP_DateNaissance.Location = new System.Drawing.Point(237, 198);
            this.DTP_DateNaissance.Name = "DTP_DateNaissance";
            this.DTP_DateNaissance.Size = new System.Drawing.Size(228, 26);
            this.DTP_DateNaissance.TabIndex = 2;
            // 
            // CB_EquipeJoueur
            // 
            this.CB_EquipeJoueur.Enabled = false;
            this.CB_EquipeJoueur.FormattingEnabled = true;
            this.CB_EquipeJoueur.Location = new System.Drawing.Point(237, 322);
            this.CB_EquipeJoueur.Name = "CB_EquipeJoueur";
            this.CB_EquipeJoueur.Size = new System.Drawing.Size(228, 28);
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
            this.CB_PosJoueur.Location = new System.Drawing.Point(237, 382);
            this.CB_PosJoueur.Name = "CB_PosJoueur";
            this.CB_PosJoueur.Size = new System.Drawing.Size(228, 28);
            this.CB_PosJoueur.TabIndex = 3;
            // 
            // TB_Url
            // 
            this.TB_Url.Location = new System.Drawing.Point(237, 442);
            this.TB_Url.Name = "TB_Url";
            this.TB_Url.ReadOnly = true;
            this.TB_Url.Size = new System.Drawing.Size(228, 26);
            this.TB_Url.TabIndex = 1;
            // 
            // LB_Url
            // 
            this.LB_Url.AutoSize = true;
            this.LB_Url.Location = new System.Drawing.Point(33, 445);
            this.LB_Url.Name = "LB_Url";
            this.LB_Url.Size = new System.Drawing.Size(137, 20);
            this.LB_Url.TabIndex = 0;
            this.LB_Url.Text = "URL image joueur";
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
            this.FB_Precedent.Location = new System.Drawing.Point(204, 489);
            this.FB_Precedent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Precedent.Name = "FB_Precedent";
            this.FB_Precedent.Size = new System.Drawing.Size(60, 62);
            this.FB_Precedent.TabIndex = 20;
            this.toolTip1.SetToolTip(this.FB_Precedent, "Précédent");
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
            this.FB_Suivant.Location = new System.Drawing.Point(300, 489);
            this.FB_Suivant.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Suivant.Name = "FB_Suivant";
            this.FB_Suivant.Size = new System.Drawing.Size(60, 62);
            this.FB_Suivant.TabIndex = 19;
            this.toolTip1.SetToolTip(this.FB_Suivant, "Suivant");
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
            this.FB_Fin.Location = new System.Drawing.Point(369, 489);
            this.FB_Fin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fin.Name = "FB_Fin";
            this.FB_Fin.Size = new System.Drawing.Size(60, 62);
            this.FB_Fin.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FB_Fin, "Fin");
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
            this.FB_Debut.Location = new System.Drawing.Point(135, 489);
            this.FB_Debut.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Debut.Name = "FB_Debut";
            this.FB_Debut.Size = new System.Drawing.Size(60, 62);
            this.FB_Debut.TabIndex = 17;
            this.toolTip1.SetToolTip(this.FB_Debut, "Début");
            this.FB_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // FB_SupprimerJoueur
            // 
            this.FB_SupprimerJoueur.BackColor = System.Drawing.Color.Transparent;
            this.FB_SupprimerJoueur.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_SupprimerJoueur.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Click;
            this.FB_SupprimerJoueur.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerJoueur.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerJoueur.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Over;
            this.FB_SupprimerJoueur.Location = new System.Drawing.Point(552, 262);
            this.FB_SupprimerJoueur.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_SupprimerJoueur.Name = "FB_SupprimerJoueur";
            this.FB_SupprimerJoueur.Size = new System.Drawing.Size(69, 71);
            this.FB_SupprimerJoueur.TabIndex = 16;
            this.toolTip1.SetToolTip(this.FB_SupprimerJoueur, "Supprimer un joueur");
            this.FB_SupprimerJoueur.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // FB_ModifierJoueur
            // 
            this.FB_ModifierJoueur.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierJoueur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_ModifierJoueur.BackgroundImage")));
            this.FB_ModifierJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierJoueur.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_ModifierJoueur.ImageClick")));
            this.FB_ModifierJoueur.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_ModifierJoueur.ImageDisable")));
            this.FB_ModifierJoueur.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_ModifierJoueur.ImageNeutral")));
            this.FB_ModifierJoueur.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_ModifierJoueur.ImageOver")));
            this.FB_ModifierJoueur.Location = new System.Drawing.Point(592, 185);
            this.FB_ModifierJoueur.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_ModifierJoueur.Name = "FB_ModifierJoueur";
            this.FB_ModifierJoueur.Size = new System.Drawing.Size(69, 71);
            this.FB_ModifierJoueur.TabIndex = 15;
            this.toolTip1.SetToolTip(this.FB_ModifierJoueur, "Modifier un joueur");
            this.FB_ModifierJoueur.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // FB_AjouterJoueur
            // 
            this.FB_AjouterJoueur.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterJoueur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_AjouterJoueur.BackgroundImage")));
            this.FB_AjouterJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjouterJoueur.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_AjouterJoueur.ImageClick")));
            this.FB_AjouterJoueur.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_AjouterJoueur.ImageDisable")));
            this.FB_AjouterJoueur.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_AjouterJoueur.ImageNeutral")));
            this.FB_AjouterJoueur.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_AjouterJoueur.ImageOver")));
            this.FB_AjouterJoueur.Location = new System.Drawing.Point(512, 185);
            this.FB_AjouterJoueur.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_AjouterJoueur.Name = "FB_AjouterJoueur";
            this.FB_AjouterJoueur.Size = new System.Drawing.Size(69, 71);
            this.FB_AjouterJoueur.TabIndex = 14;
            this.toolTip1.SetToolTip(this.FB_AjouterJoueur, "Ajouter un joueur");
            this.FB_AjouterJoueur.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(552, 489);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(60, 62);
            this.PB_Fermer_Gif.TabIndex = 13;
            this.PB_Fermer_Gif.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_Fermer_Gif, "Fermer");
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
            this.FB_Fermer.Location = new System.Drawing.Point(552, 489);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(60, 62);
            this.FB_Fermer.TabIndex = 12;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // PB_Joueur
            // 
            this.PB_Joueur.ErrorImage = global::TPFinal.Properties.Resources.no_picture;
            this.PB_Joueur.Location = new System.Drawing.Point(512, 25);
            this.PB_Joueur.Name = "PB_Joueur";
            this.PB_Joueur.Size = new System.Drawing.Size(150, 149);
            this.PB_Joueur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Joueur.TabIndex = 5;
            this.PB_Joueur.TabStop = false;
            // 
            // CM_Joueur
            // 
            this.CM_Joueur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.premierToolStripMenuItem,
            this.dernierToolStripMenuItem,
            this.premierToolStripMenuItem1,
            this.dernierToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.CM_Joueur.Name = "CM_Stats";
            this.CM_Joueur.Size = new System.Drawing.Size(199, 277);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // premierToolStripMenuItem
            // 
            this.premierToolStripMenuItem.Name = "premierToolStripMenuItem";
            this.premierToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.premierToolStripMenuItem.Text = "Suivant";
            this.premierToolStripMenuItem.Click += new System.EventHandler(this.premierToolStripMenuItem_Click);
            // 
            // dernierToolStripMenuItem
            // 
            this.dernierToolStripMenuItem.Name = "dernierToolStripMenuItem";
            this.dernierToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.dernierToolStripMenuItem.Text = "Précédent";
            this.dernierToolStripMenuItem.Click += new System.EventHandler(this.dernierToolStripMenuItem_Click);
            // 
            // premierToolStripMenuItem1
            // 
            this.premierToolStripMenuItem1.Name = "premierToolStripMenuItem1";
            this.premierToolStripMenuItem1.Size = new System.Drawing.Size(198, 30);
            this.premierToolStripMenuItem1.Text = "Premier";
            this.premierToolStripMenuItem1.Click += new System.EventHandler(this.premierToolStripMenuItem1_Click);
            // 
            // dernierToolStripMenuItem1
            // 
            this.dernierToolStripMenuItem1.Name = "dernierToolStripMenuItem1";
            this.dernierToolStripMenuItem1.Size = new System.Drawing.Size(198, 30);
            this.dernierToolStripMenuItem1.Text = "Dernier";
            this.dernierToolStripMenuItem1.Click += new System.EventHandler(this.dernierToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form_Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 555);
            this.Controls.Add(this.FB_Precedent);
            this.Controls.Add(this.FB_Suivant);
            this.Controls.Add(this.FB_Fin);
            this.Controls.Add(this.FB_Debut);
            this.Controls.Add(this.FB_SupprimerJoueur);
            this.Controls.Add(this.FB_ModifierJoueur);
            this.Controls.Add(this.FB_AjouterJoueur);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.PB_Joueur);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Joueurs";
            this.Text = "Form_Joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Joueurs_FormClosed);
            this.Load += new System.EventHandler(this.Form_Joueurs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Joueurs_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).EndInit();
            this.CM_Joueur.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox PB_Joueur;
        private System.Windows.Forms.TextBox TB_Url;
        private System.Windows.Forms.Label LB_Url;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_SupprimerJoueur;
        private FlashButton.FlashButton FB_ModifierJoueur;
        private FlashButton.FlashButton FB_AjouterJoueur;
        private FlashButton.FlashButton FB_Debut;
        private FlashButton.FlashButton FB_Fin;
        private FlashButton.FlashButton FB_Suivant;
        private FlashButton.FlashButton FB_Precedent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip CM_Joueur;
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