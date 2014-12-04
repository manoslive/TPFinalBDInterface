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
            this.LB_EquipeHome = new System.Windows.Forms.Label();
            this.LB_EquipeAway = new System.Windows.Forms.Label();
            this.BTN_AjoutRencontre = new System.Windows.Forms.Button();
            this.BTN_ModifierMatch = new System.Windows.Forms.Button();
            this.BTN_Calendrier = new System.Windows.Forms.Button();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.BTN_AjoutStats = new System.Windows.Forms.Button();
            this.DGV_Matchs = new System.Windows.Forms.DataGridView();
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            this.PB_Faceoff = new System.Windows.Forms.PictureBox();
            this.PB_EquipeHome = new System.Windows.Forms.PictureBox();
            this.PB_EquipeAway = new System.Windows.Forms.PictureBox();
            this.LB_ScoreAway = new System.Windows.Forms.Label();
            this.LB_ScoreHome = new System.Windows.Forms.Label();
            this.LB_NbButsHome = new System.Windows.Forms.Label();
            this.LB_NbButsAway = new System.Windows.Forms.Label();
            this.TB_Receveur = new System.Windows.Forms.TextBox();
            this.TB_Visiteur = new System.Windows.Forms.TextBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Faceoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_EquipeHome
            // 
            this.LB_EquipeHome.AutoSize = true;
            this.LB_EquipeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EquipeHome.Location = new System.Drawing.Point(169, 8);
            this.LB_EquipeHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EquipeHome.Name = "LB_EquipeHome";
            this.LB_EquipeHome.Size = new System.Drawing.Size(127, 17);
            this.LB_EquipeHome.TabIndex = 0;
            this.LB_EquipeHome.Text = "Équipe receveur";
            // 
            // LB_EquipeAway
            // 
            this.LB_EquipeAway.AutoSize = true;
            this.LB_EquipeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EquipeAway.Location = new System.Drawing.Point(502, 8);
            this.LB_EquipeAway.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EquipeAway.Name = "LB_EquipeAway";
            this.LB_EquipeAway.Size = new System.Drawing.Size(116, 17);
            this.LB_EquipeAway.TabIndex = 0;
            this.LB_EquipeAway.Text = "Équipe visiteur";
            // 
            // BTN_AjoutRencontre
            // 
            this.BTN_AjoutRencontre.Location = new System.Drawing.Point(8, 258);
            this.BTN_AjoutRencontre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AjoutRencontre.Name = "BTN_AjoutRencontre";
            this.BTN_AjoutRencontre.Size = new System.Drawing.Size(109, 21);
            this.BTN_AjoutRencontre.TabIndex = 4;
            this.BTN_AjoutRencontre.Text = "Ajouter match";
            this.BTN_AjoutRencontre.UseVisualStyleBackColor = true;
            this.BTN_AjoutRencontre.Click += new System.EventHandler(this.BTN_AjoutRencontre_Click);
            // 
            // BTN_ModifierMatch
            // 
            this.BTN_ModifierMatch.Location = new System.Drawing.Point(241, 258);
            this.BTN_ModifierMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ModifierMatch.Name = "BTN_ModifierMatch";
            this.BTN_ModifierMatch.Size = new System.Drawing.Size(109, 21);
            this.BTN_ModifierMatch.TabIndex = 4;
            this.BTN_ModifierMatch.Text = "Modifier Match";
            this.BTN_ModifierMatch.UseVisualStyleBackColor = true;
            this.BTN_ModifierMatch.Click += new System.EventHandler(this.BTN_ModifierMatch_Click);
            // 
            // BTN_Calendrier
            // 
            this.BTN_Calendrier.Location = new System.Drawing.Point(454, 258);
            this.BTN_Calendrier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Calendrier.Name = "BTN_Calendrier";
            this.BTN_Calendrier.Size = new System.Drawing.Size(109, 21);
            this.BTN_Calendrier.TabIndex = 4;
            this.BTN_Calendrier.Text = "Calendrier";
            this.BTN_Calendrier.UseVisualStyleBackColor = true;
            this.BTN_Calendrier.Click += new System.EventHandler(this.BTN_Calendrier_Click);
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.Location = new System.Drawing.Point(152, 392);
            this.BTN_Stats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(109, 21);
            this.BTN_Stats.TabIndex = 4;
            this.BTN_Stats.Text = "Stats";
            this.BTN_Stats.UseVisualStyleBackColor = true;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // BTN_AjoutStats
            // 
            this.BTN_AjoutStats.Location = new System.Drawing.Point(8, 392);
            this.BTN_AjoutStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_AjoutStats.Name = "BTN_AjoutStats";
            this.BTN_AjoutStats.Size = new System.Drawing.Size(109, 21);
            this.BTN_AjoutStats.TabIndex = 4;
            this.BTN_AjoutStats.Text = "Ajouter stats";
            this.BTN_AjoutStats.UseVisualStyleBackColor = true;
            this.BTN_AjoutStats.Click += new System.EventHandler(this.BTN_AjoutStats_Click);
            // 
            // DGV_Matchs
            // 
            this.DGV_Matchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Matchs.Location = new System.Drawing.Point(8, 153);
            this.DGV_Matchs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Matchs.MultiSelect = false;
            this.DGV_Matchs.Name = "DGV_Matchs";
            this.DGV_Matchs.ReadOnly = true;
            this.DGV_Matchs.RowHeadersVisible = false;
            this.DGV_Matchs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Matchs.RowTemplate.Height = 28;
            this.DGV_Matchs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Matchs.Size = new System.Drawing.Size(763, 101);
            this.DGV_Matchs.TabIndex = 5;
            this.DGV_Matchs.SelectionChanged += new System.EventHandler(this.DGV_Matchs_SelectionChanged);
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Location = new System.Drawing.Point(8, 283);
            this.DGV_Joueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Joueurs.MultiSelect = false;
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.ReadOnly = true;
            this.DGV_Joueurs.RowHeadersVisible = false;
            this.DGV_Joueurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Joueurs.RowTemplate.Height = 28;
            this.DGV_Joueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Joueurs.Size = new System.Drawing.Size(763, 101);
            this.DGV_Joueurs.TabIndex = 5;
            this.DGV_Joueurs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Joueurs_CellMouseDoubleClick);
            // 
            // PB_Faceoff
            // 
            this.PB_Faceoff.Image = global::TPFinal.Properties.Resources.hockey_face_off;
            this.PB_Faceoff.Location = new System.Drawing.Point(300, 8);
            this.PB_Faceoff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_Faceoff.Name = "PB_Faceoff";
            this.PB_Faceoff.Size = new System.Drawing.Size(198, 121);
            this.PB_Faceoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Faceoff.TabIndex = 6;
            this.PB_Faceoff.TabStop = false;
            // 
            // PB_EquipeHome
            // 
            this.PB_EquipeHome.Location = new System.Drawing.Point(8, 8);
            this.PB_EquipeHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_EquipeHome.Name = "PB_EquipeHome";
            this.PB_EquipeHome.Size = new System.Drawing.Size(149, 134);
            this.PB_EquipeHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_EquipeHome.TabIndex = 1;
            this.PB_EquipeHome.TabStop = false;
            // 
            // PB_EquipeAway
            // 
            this.PB_EquipeAway.Location = new System.Drawing.Point(621, 8);
            this.PB_EquipeAway.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_EquipeAway.Name = "PB_EquipeAway";
            this.PB_EquipeAway.Size = new System.Drawing.Size(149, 134);
            this.PB_EquipeAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_EquipeAway.TabIndex = 1;
            this.PB_EquipeAway.TabStop = false;
            // 
            // LB_ScoreAway
            // 
            this.LB_ScoreAway.AutoSize = true;
            this.LB_ScoreAway.Location = new System.Drawing.Point(530, 74);
            this.LB_ScoreAway.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ScoreAway.Name = "LB_ScoreAway";
            this.LB_ScoreAway.Size = new System.Drawing.Size(57, 13);
            this.LB_ScoreAway.TabIndex = 7;
            this.LB_ScoreAway.Text = "Score final";
            // 
            // LB_ScoreHome
            // 
            this.LB_ScoreHome.AutoSize = true;
            this.LB_ScoreHome.Location = new System.Drawing.Point(199, 74);
            this.LB_ScoreHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ScoreHome.Name = "LB_ScoreHome";
            this.LB_ScoreHome.Size = new System.Drawing.Size(57, 13);
            this.LB_ScoreHome.TabIndex = 7;
            this.LB_ScoreHome.Text = "Score final";
            // 
            // LB_NbButsHome
            // 
            this.LB_NbButsHome.AutoSize = true;
            this.LB_NbButsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NbButsHome.Location = new System.Drawing.Point(214, 96);
            this.LB_NbButsHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NbButsHome.Name = "LB_NbButsHome";
            this.LB_NbButsHome.Size = new System.Drawing.Size(25, 26);
            this.LB_NbButsHome.TabIndex = 8;
            this.LB_NbButsHome.Text = "#";
            // 
            // LB_NbButsAway
            // 
            this.LB_NbButsAway.AutoSize = true;
            this.LB_NbButsAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NbButsAway.Location = new System.Drawing.Point(551, 96);
            this.LB_NbButsAway.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NbButsAway.Name = "LB_NbButsAway";
            this.LB_NbButsAway.Size = new System.Drawing.Size(25, 26);
            this.LB_NbButsAway.TabIndex = 8;
            this.LB_NbButsAway.Text = "#";
            // 
            // TB_Receveur
            // 
            this.TB_Receveur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Receveur.Location = new System.Drawing.Point(172, 36);
            this.TB_Receveur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Receveur.Name = "TB_Receveur";
            this.TB_Receveur.ReadOnly = true;
            this.TB_Receveur.Size = new System.Drawing.Size(110, 13);
            this.TB_Receveur.TabIndex = 9;
            this.TB_Receveur.Text = "Home";
            this.TB_Receveur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Visiteur
            // 
            this.TB_Visiteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Visiteur.Location = new System.Drawing.Point(502, 36);
            this.TB_Visiteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Visiteur.Name = "TB_Visiteur";
            this.TB_Visiteur.ReadOnly = true;
            this.TB_Visiteur.Size = new System.Drawing.Size(110, 13);
            this.TB_Visiteur.TabIndex = 9;
            this.TB_Visiteur.Text = "Away";
            this.TB_Visiteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(727, 389);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(40, 40);
            this.PB_Fermer_Gif.TabIndex = 11;
            this.PB_Fermer_Gif.TabStop = false;
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
            this.FB_Fermer.Location = new System.Drawing.Point(727, 386);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(40, 40);
            this.FB_Fermer.TabIndex = 10;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // Form_Matchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 432);
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
            this.Controls.Add(this.BTN_Stats);
            this.Controls.Add(this.BTN_Calendrier);
            this.Controls.Add(this.BTN_ModifierMatch);
            this.Controls.Add(this.BTN_AjoutStats);
            this.Controls.Add(this.BTN_AjoutRencontre);
            this.Controls.Add(this.PB_EquipeHome);
            this.Controls.Add(this.PB_EquipeAway);
            this.Controls.Add(this.LB_EquipeAway);
            this.Controls.Add(this.LB_EquipeHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Matchs";
            this.Text = "Form_Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Matchs_FormClosed);
            this.Load += new System.EventHandler(this.Form_Matchs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Faceoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_EquipeHome;
        private System.Windows.Forms.Label LB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeHome;
        private System.Windows.Forms.Button BTN_AjoutRencontre;
        private System.Windows.Forms.Button BTN_ModifierMatch;
        private System.Windows.Forms.Button BTN_Calendrier;
        private System.Windows.Forms.Button BTN_Stats;
        private System.Windows.Forms.Button BTN_AjoutStats;
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

    }
}