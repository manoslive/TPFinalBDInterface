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
            this.BTN_Matchs = new System.Windows.Forms.Button();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.LB_Division = new System.Windows.Forms.Label();
            this.toolTip_Equipe = new System.Windows.Forms.ToolTip(this.components);
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_SupprimerEquipe = new FlashButton.FlashButton();
            this.FB_ModifierEquipe = new FlashButton.FlashButton();
            this.FB_AjouterEquipe = new FlashButton.FlashButton();
            this.FB_Classement = new FlashButton.FlashButton();
            this.FB_Top3 = new FlashButton.FlashButton();
            this.BTN_Divisions = new System.Windows.Forms.Button();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.Location = new System.Drawing.Point(8, 8);
            this.DGV_Equipes.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Equipes.MultiSelect = false;
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.ReadOnly = true;
            this.DGV_Equipes.RowHeadersVisible = false;
            this.DGV_Equipes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Equipes.RowTemplate.Height = 28;
            this.DGV_Equipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Equipes.Size = new System.Drawing.Size(391, 161);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Equipes_CellMouseDoubleClick);
            this.DGV_Equipes.SelectionChanged += new System.EventHandler(this.DGV_Equipes_SelectionChanged);
            // 
            // BTN_Matchs
            // 
            this.BTN_Matchs.Location = new System.Drawing.Point(8, 187);
            this.BTN_Matchs.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Matchs.Name = "BTN_Matchs";
            this.BTN_Matchs.Size = new System.Drawing.Size(79, 26);
            this.BTN_Matchs.TabIndex = 1;
            this.BTN_Matchs.Text = "Matchs";
            this.BTN_Matchs.UseVisualStyleBackColor = true;
            this.BTN_Matchs.Click += new System.EventHandler(this.BTN_Matchs_Click);
            // 
            // CB_Division
            // 
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Toutes"});
            this.CB_Division.Location = new System.Drawing.Point(307, 192);
            this.CB_Division.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(103, 21);
            this.CB_Division.TabIndex = 3;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(305, 177);
            this.LB_Division.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(44, 13);
            this.LB_Division.TabIndex = 4;
            this.LB_Division.Text = "Division";
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(465, 177);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(46, 41);
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
            this.FB_Fermer.BackColor = System.Drawing.Color.Transparent;
            this.FB_Fermer.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::TPFinal.Properties.Resources.ICON_Fermer_Click;
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(465, 177);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(46, 41);
            this.FB_Fermer.TabIndex = 11;
            this.toolTip_Equipe.SetToolTip(this.FB_Fermer, "Supprimer une équipe");
            this.FB_Fermer.Click += new System.EventHandler(this.BTN_Ok_Click);
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // FB_SupprimerEquipe
            // 
            this.FB_SupprimerEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_SupprimerEquipe.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_SupprimerEquipe.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Click;
            this.FB_SupprimerEquipe.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerEquipe.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerEquipe.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Over;
            this.FB_SupprimerEquipe.Location = new System.Drawing.Point(465, 129);
            this.FB_SupprimerEquipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_SupprimerEquipe.Name = "FB_SupprimerEquipe";
            this.FB_SupprimerEquipe.Size = new System.Drawing.Size(46, 46);
            this.FB_SupprimerEquipe.TabIndex = 9;
            this.toolTip_Equipe.SetToolTip(this.FB_SupprimerEquipe, "Supprimer une équipe");
            this.FB_SupprimerEquipe.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // FB_ModifierEquipe
            // 
            this.FB_ModifierEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierEquipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.BackgroundImage")));
            this.FB_ModifierEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierEquipe.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageClick")));
            this.FB_ModifierEquipe.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageDisable")));
            this.FB_ModifierEquipe.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageNeutral")));
            this.FB_ModifierEquipe.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_ModifierEquipe.ImageOver")));
            this.FB_ModifierEquipe.Location = new System.Drawing.Point(486, 90);
            this.FB_ModifierEquipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_ModifierEquipe.Name = "FB_ModifierEquipe";
            this.FB_ModifierEquipe.Size = new System.Drawing.Size(46, 46);
            this.FB_ModifierEquipe.TabIndex = 8;
            this.toolTip_Equipe.SetToolTip(this.FB_ModifierEquipe, "Modifier une équipe");
            this.FB_ModifierEquipe.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // FB_AjouterEquipe
            // 
            this.FB_AjouterEquipe.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterEquipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.BackgroundImage")));
            this.FB_AjouterEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjouterEquipe.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageClick")));
            this.FB_AjouterEquipe.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageDisable")));
            this.FB_AjouterEquipe.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageNeutral")));
            this.FB_AjouterEquipe.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_AjouterEquipe.ImageOver")));
            this.FB_AjouterEquipe.Location = new System.Drawing.Point(440, 90);
            this.FB_AjouterEquipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_AjouterEquipe.Name = "FB_AjouterEquipe";
            this.FB_AjouterEquipe.Size = new System.Drawing.Size(46, 46);
            this.FB_AjouterEquipe.TabIndex = 7;
            this.toolTip_Equipe.SetToolTip(this.FB_AjouterEquipe, "Ajouter une équipe");
            this.FB_AjouterEquipe.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // FB_Classement
            // 
            this.FB_Classement.BackColor = System.Drawing.Color.Transparent;
            this.FB_Classement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Classement.BackgroundImage")));
            this.FB_Classement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Classement.ImageClick = global::TPFinal.Properties.Resources.ICON_Classement_Click;
            this.FB_Classement.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Classement.ImageDisable")));
            this.FB_Classement.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Classement.ImageNeutral")));
            this.FB_Classement.ImageOver = global::TPFinal.Properties.Resources.ICON_Classement_Over;
            this.FB_Classement.Location = new System.Drawing.Point(200, 177);
            this.FB_Classement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_Classement.Name = "FB_Classement";
            this.FB_Classement.Size = new System.Drawing.Size(36, 36);
            this.FB_Classement.TabIndex = 6;
            this.toolTip_Equipe.SetToolTip(this.FB_Classement, "Classement");
            this.FB_Classement.Click += new System.EventHandler(this.BTN_Classement_Click);
            // 
            // FB_Top3
            // 
            this.FB_Top3.BackColor = System.Drawing.Color.Transparent;
            this.FB_Top3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Top3.BackgroundImage")));
            this.FB_Top3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Top3.ImageClick = global::TPFinal.Properties.Resources.ICON_Top3_Click;
            this.FB_Top3.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Top3.ImageDisable")));
            this.FB_Top3.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Top3.ImageNeutral")));
            this.FB_Top3.ImageOver = global::TPFinal.Properties.Resources.ICON_Top3_Over;
            this.FB_Top3.Location = new System.Drawing.Point(254, 177);
            this.FB_Top3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FB_Top3.Name = "FB_Top3";
            this.FB_Top3.Size = new System.Drawing.Size(36, 36);
            this.FB_Top3.TabIndex = 5;
            this.toolTip_Equipe.SetToolTip(this.FB_Top3, "Top 3");
            this.FB_Top3.Click += new System.EventHandler(this.BTN_Top5_Click);
            // 
            // BTN_Divisions
            // 
            this.BTN_Divisions.Location = new System.Drawing.Point(109, 188);
            this.BTN_Divisions.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Divisions.Name = "BTN_Divisions";
            this.BTN_Divisions.Size = new System.Drawing.Size(77, 25);
            this.BTN_Divisions.TabIndex = 10;
            this.BTN_Divisions.Text = "Divisions";
            this.BTN_Divisions.UseVisualStyleBackColor = true;
            this.BTN_Divisions.Click += new System.EventHandler(this.BTN_Divisions_Click);
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Equipe.ErrorImage = global::TPFinal.Properties.Resources.no_picture;
            this.PB_Equipe.Location = new System.Drawing.Point(441, 8);
            this.PB_Equipe.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(93, 77);
            this.PB_Equipe.TabIndex = 2;
            this.PB_Equipe.TabStop = false;
            // 
            // Form_Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 223);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.BTN_Divisions);
            this.Controls.Add(this.FB_SupprimerEquipe);
            this.Controls.Add(this.FB_ModifierEquipe);
            this.Controls.Add(this.FB_AjouterEquipe);
            this.Controls.Add(this.FB_Classement);
            this.Controls.Add(this.FB_Top3);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.PB_Equipe);
            this.Controls.Add(this.BTN_Matchs);
            this.Controls.Add(this.DGV_Equipes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Equipes";
            this.Text = "Form_Equipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipes_FormClosing);
            this.Load += new System.EventHandler(this.Form_Equipe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Equipes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.Button BTN_Matchs;
        public System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.Label LB_Division;
        private FlashButton.FlashButton FB_Top3;
        private FlashButton.FlashButton FB_Classement;
        private System.Windows.Forms.ToolTip toolTip_Equipe;
        private FlashButton.FlashButton FB_AjouterEquipe;
        private FlashButton.FlashButton FB_ModifierEquipe;
        private FlashButton.FlashButton FB_SupprimerEquipe;
        private System.Windows.Forms.Button BTN_Divisions;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
    }
}