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
            this.components = new System.ComponentModel.Container();
            this.CB_EquipeHome = new System.Windows.Forms.ComboBox();
            this.CB_EquipeAway = new System.Windows.Forms.ComboBox();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.TB_NumeroMatch = new System.Windows.Forms.TextBox();
            this.LB_LieuMatch = new System.Windows.Forms.Label();
            this.LB_DateMatch = new System.Windows.Forms.Label();
            this.DTP_DateRencontre = new System.Windows.Forms.DateTimePicker();
            this.LB_EquipeAway = new System.Windows.Forms.Label();
            this.LB_EquipeHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Scorevisiteur = new System.Windows.Forms.Label();
            this.LB_ScoreReceveur = new System.Windows.Forms.Label();
            this.TB_ScoreVisiteur = new System.Windows.Forms.TextBox();
            this.TB_ScoreReceveur = new System.Windows.Forms.TextBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_EquipeHome
            // 
            this.CB_EquipeHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EquipeHome.FormattingEnabled = true;
            this.CB_EquipeHome.Location = new System.Drawing.Point(116, 20);
            this.CB_EquipeHome.Name = "CB_EquipeHome";
            this.CB_EquipeHome.Size = new System.Drawing.Size(132, 21);
            this.CB_EquipeHome.TabIndex = 0;
            this.CB_EquipeHome.SelectedIndexChanged += new System.EventHandler(this.CB_EquipeHome_SelectedIndexChanged);
            // 
            // CB_EquipeAway
            // 
            this.CB_EquipeAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EquipeAway.FormattingEnabled = true;
            this.CB_EquipeAway.Location = new System.Drawing.Point(116, 63);
            this.CB_EquipeAway.Name = "CB_EquipeAway";
            this.CB_EquipeAway.Size = new System.Drawing.Size(132, 21);
            this.CB_EquipeAway.TabIndex = 1;
            this.CB_EquipeAway.SelectedIndexChanged += new System.EventHandler(this.CB_EquipeAway_SelectedIndexChanged);
            // 
            // TB_Lieu
            // 
            this.TB_Lieu.Location = new System.Drawing.Point(116, 136);
            this.TB_Lieu.MaxLength = 40;
            this.TB_Lieu.Name = "TB_Lieu";
            this.TB_Lieu.Size = new System.Drawing.Size(132, 20);
            this.TB_Lieu.TabIndex = 3;
            this.TB_Lieu.TextChanged += new System.EventHandler(this.TB_Lieu_TextChanged);
            // 
            // TB_NumeroMatch
            // 
            this.TB_NumeroMatch.Enabled = false;
            this.TB_NumeroMatch.Location = new System.Drawing.Point(77, -61);
            this.TB_NumeroMatch.Name = "TB_NumeroMatch";
            this.TB_NumeroMatch.Size = new System.Drawing.Size(132, 20);
            this.TB_NumeroMatch.TabIndex = 17;
            // 
            // LB_LieuMatch
            // 
            this.LB_LieuMatch.AutoSize = true;
            this.LB_LieuMatch.Location = new System.Drawing.Point(17, 139);
            this.LB_LieuMatch.Name = "LB_LieuMatch";
            this.LB_LieuMatch.Size = new System.Drawing.Size(74, 13);
            this.LB_LieuMatch.TabIndex = 24;
            this.LB_LieuMatch.Text = "Lieu du match";
            // 
            // LB_DateMatch
            // 
            this.LB_DateMatch.AutoSize = true;
            this.LB_DateMatch.Location = new System.Drawing.Point(17, 101);
            this.LB_DateMatch.Name = "LB_DateMatch";
            this.LB_DateMatch.Size = new System.Drawing.Size(62, 13);
            this.LB_DateMatch.TabIndex = 22;
            this.LB_DateMatch.Text = "Date match";
            // 
            // DTP_DateRencontre
            // 
            this.DTP_DateRencontre.Location = new System.Drawing.Point(116, 101);
            this.DTP_DateRencontre.Name = "DTP_DateRencontre";
            this.DTP_DateRencontre.Size = new System.Drawing.Size(132, 20);
            this.DTP_DateRencontre.TabIndex = 2;
            this.DTP_DateRencontre.ValueChanged += new System.EventHandler(this.DTP_DateRencontre_ValueChanged);
            // 
            // LB_EquipeAway
            // 
            this.LB_EquipeAway.AutoSize = true;
            this.LB_EquipeAway.Location = new System.Drawing.Point(17, 66);
            this.LB_EquipeAway.Name = "LB_EquipeAway";
            this.LB_EquipeAway.Size = new System.Drawing.Size(77, 13);
            this.LB_EquipeAway.TabIndex = 20;
            this.LB_EquipeAway.Text = "Équipe Visiteur";
            // 
            // LB_EquipeHome
            // 
            this.LB_EquipeHome.AutoSize = true;
            this.LB_EquipeHome.Location = new System.Drawing.Point(17, 23);
            this.LB_EquipeHome.Name = "LB_EquipeHome";
            this.LB_EquipeHome.Size = new System.Drawing.Size(90, 13);
            this.LB_EquipeHome.TabIndex = 18;
            this.LB_EquipeHome.Text = "Équipe à domicile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-22, -61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero du Match";
            // 
            // LB_Scorevisiteur
            // 
            this.LB_Scorevisiteur.AutoSize = true;
            this.LB_Scorevisiteur.Location = new System.Drawing.Point(17, 170);
            this.LB_Scorevisiteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Scorevisiteur.Name = "LB_Scorevisiteur";
            this.LB_Scorevisiteur.Size = new System.Drawing.Size(71, 13);
            this.LB_Scorevisiteur.TabIndex = 25;
            this.LB_Scorevisiteur.Text = "Score visiteur";
            // 
            // LB_ScoreReceveur
            // 
            this.LB_ScoreReceveur.AutoSize = true;
            this.LB_ScoreReceveur.Location = new System.Drawing.Point(17, 205);
            this.LB_ScoreReceveur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ScoreReceveur.Name = "LB_ScoreReceveur";
            this.LB_ScoreReceveur.Size = new System.Drawing.Size(80, 13);
            this.LB_ScoreReceveur.TabIndex = 25;
            this.LB_ScoreReceveur.Text = "Score receveur";
            // 
            // TB_ScoreVisiteur
            // 
            this.TB_ScoreVisiteur.Location = new System.Drawing.Point(116, 168);
            this.TB_ScoreVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ScoreVisiteur.Name = "TB_ScoreVisiteur";
            this.TB_ScoreVisiteur.Size = new System.Drawing.Size(132, 20);
            this.TB_ScoreVisiteur.TabIndex = 26;
            this.TB_ScoreVisiteur.TextChanged += new System.EventHandler(this.TB_ScoreVisiteur_TextChanged);
            // 
            // TB_ScoreReceveur
            // 
            this.TB_ScoreReceveur.Location = new System.Drawing.Point(116, 203);
            this.TB_ScoreReceveur.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ScoreReceveur.Name = "TB_ScoreReceveur";
            this.TB_ScoreReceveur.Size = new System.Drawing.Size(132, 20);
            this.TB_ScoreReceveur.TabIndex = 26;
            this.TB_ScoreReceveur.TextChanged += new System.EventHandler(this.TB_ScoreReceveur_TextChanged);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(206, 239);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(40, 40);
            this.PB_Fermer_Gif.TabIndex = 30;
            this.PB_Fermer_Gif.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_Fermer_Gif, "Quitter");
            this.PB_Fermer_Gif.Visible = false;
            this.PB_Fermer_Gif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseDown);
            this.PB_Fermer_Gif.MouseLeave += new System.EventHandler(this.PB_Fermer_Gif_MouseLeave);
            this.PB_Fermer_Gif.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_Fermer_Gif_MouseUp);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::TPFinal.Properties.Resources.ICON_Fermer_Click;
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(206, 239);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(40, 40);
            this.FB_Fermer.TabIndex = 29;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Cancel_MouseEnter);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ajouter.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Click;
            this.FB_Ajouter.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Over;
            this.FB_Ajouter.Location = new System.Drawing.Point(149, 239);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(42, 42);
            this.FB_Ajouter.TabIndex = 28;
            this.toolTip1.SetToolTip(this.FB_Ajouter, "Ajouter le match");
            this.FB_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // Form_Ajouter_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 289);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.TB_ScoreReceveur);
            this.Controls.Add(this.TB_ScoreVisiteur);
            this.Controls.Add(this.LB_ScoreReceveur);
            this.Controls.Add(this.LB_Scorevisiteur);
            this.Controls.Add(this.CB_EquipeHome);
            this.Controls.Add(this.CB_EquipeAway);
            this.Controls.Add(this.TB_Lieu);
            this.Controls.Add(this.TB_NumeroMatch);
            this.Controls.Add(this.LB_LieuMatch);
            this.Controls.Add(this.LB_DateMatch);
            this.Controls.Add(this.DTP_DateRencontre);
            this.Controls.Add(this.LB_EquipeAway);
            this.Controls.Add(this.LB_EquipeHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Ajouter_Match";
            this.Text = "Form_Ajouter_Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Ajouter_Match_FormClosed);
            this.Load += new System.EventHandler(this.Form_Ajouter_Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_EquipeHome;
        private System.Windows.Forms.ComboBox CB_EquipeAway;
        private System.Windows.Forms.TextBox TB_Lieu;
        private System.Windows.Forms.TextBox TB_NumeroMatch;
        private System.Windows.Forms.Label LB_LieuMatch;
        private System.Windows.Forms.Label LB_DateMatch;
        private System.Windows.Forms.DateTimePicker DTP_DateRencontre;
        private System.Windows.Forms.Label LB_EquipeAway;
        private System.Windows.Forms.Label LB_EquipeHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Scorevisiteur;
        private System.Windows.Forms.Label LB_ScoreReceveur;
        private System.Windows.Forms.TextBox TB_ScoreVisiteur;
        private System.Windows.Forms.TextBox TB_ScoreReceveur;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}