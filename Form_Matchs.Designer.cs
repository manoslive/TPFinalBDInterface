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
            this.TB_EquipeHome = new System.Windows.Forms.TextBox();
            this.TB_EquipeAway = new System.Windows.Forms.TextBox();
            this.PB_EquipeHome = new System.Windows.Forms.PictureBox();
            this.PB_EquipeAway = new System.Windows.Forms.PictureBox();
            this.BTN_AjoutRencontre = new System.Windows.Forms.Button();
            this.BTN_ModifierMatch = new System.Windows.Forms.Button();
            this.BTN_Calendrier = new System.Windows.Forms.Button();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.BTN_AjoutStats = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.DGV_Matchs = new System.Windows.Forms.DataGridView();
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_EquipeHome
            // 
            this.LB_EquipeHome.AutoSize = true;
            this.LB_EquipeHome.Location = new System.Drawing.Point(12, 9);
            this.LB_EquipeHome.Name = "LB_EquipeHome";
            this.LB_EquipeHome.Size = new System.Drawing.Size(127, 20);
            this.LB_EquipeHome.TabIndex = 0;
            this.LB_EquipeHome.Text = "Équipe qui reçoit";
            // 
            // LB_EquipeAway
            // 
            this.LB_EquipeAway.AutoSize = true;
            this.LB_EquipeAway.Location = new System.Drawing.Point(224, 9);
            this.LB_EquipeAway.Name = "LB_EquipeAway";
            this.LB_EquipeAway.Size = new System.Drawing.Size(103, 20);
            this.LB_EquipeAway.TabIndex = 0;
            this.LB_EquipeAway.Text = "Équipe reçue";
            // 
            // TB_EquipeHome
            // 
            this.TB_EquipeHome.Location = new System.Drawing.Point(29, 203);
            this.TB_EquipeHome.Name = "TB_EquipeHome";
            this.TB_EquipeHome.Size = new System.Drawing.Size(100, 26);
            this.TB_EquipeHome.TabIndex = 2;
            // 
            // TB_EquipeAway
            // 
            this.TB_EquipeAway.Location = new System.Drawing.Point(227, 203);
            this.TB_EquipeAway.Name = "TB_EquipeAway";
            this.TB_EquipeAway.Size = new System.Drawing.Size(101, 26);
            this.TB_EquipeAway.TabIndex = 2;
            // 
            // PB_EquipeHome
            // 
            this.PB_EquipeHome.Location = new System.Drawing.Point(29, 67);
            this.PB_EquipeHome.Name = "PB_EquipeHome";
            this.PB_EquipeHome.Size = new System.Drawing.Size(100, 108);
            this.PB_EquipeHome.TabIndex = 1;
            this.PB_EquipeHome.TabStop = false;
            // 
            // PB_EquipeAway
            // 
            this.PB_EquipeAway.Location = new System.Drawing.Point(228, 67);
            this.PB_EquipeAway.Name = "PB_EquipeAway";
            this.PB_EquipeAway.Size = new System.Drawing.Size(100, 108);
            this.PB_EquipeAway.TabIndex = 1;
            this.PB_EquipeAway.TabStop = false;
            // 
            // BTN_AjoutRencontre
            // 
            this.BTN_AjoutRencontre.Location = new System.Drawing.Point(12, 397);
            this.BTN_AjoutRencontre.Name = "BTN_AjoutRencontre";
            this.BTN_AjoutRencontre.Size = new System.Drawing.Size(164, 32);
            this.BTN_AjoutRencontre.TabIndex = 4;
            this.BTN_AjoutRencontre.Text = "Ajouter match";
            this.BTN_AjoutRencontre.UseVisualStyleBackColor = true;
            this.BTN_AjoutRencontre.Click += new System.EventHandler(this.BTN_AjoutRencontre_Click);
            // 
            // BTN_ModifierMatch
            // 
            this.BTN_ModifierMatch.Location = new System.Drawing.Point(362, 397);
            this.BTN_ModifierMatch.Name = "BTN_ModifierMatch";
            this.BTN_ModifierMatch.Size = new System.Drawing.Size(164, 32);
            this.BTN_ModifierMatch.TabIndex = 4;
            this.BTN_ModifierMatch.Text = "Modifier Match";
            this.BTN_ModifierMatch.UseVisualStyleBackColor = true;
            this.BTN_ModifierMatch.Click += new System.EventHandler(this.BTN_ModifierMatch_Click);
            // 
            // BTN_Calendrier
            // 
            this.BTN_Calendrier.Location = new System.Drawing.Point(681, 397);
            this.BTN_Calendrier.Name = "BTN_Calendrier";
            this.BTN_Calendrier.Size = new System.Drawing.Size(164, 32);
            this.BTN_Calendrier.TabIndex = 4;
            this.BTN_Calendrier.Text = "Calendrier";
            this.BTN_Calendrier.UseVisualStyleBackColor = true;
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.Location = new System.Drawing.Point(992, 397);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(164, 32);
            this.BTN_Stats.TabIndex = 4;
            this.BTN_Stats.Text = "Stats";
            this.BTN_Stats.UseVisualStyleBackColor = true;
            // 
            // BTN_AjoutStats
            // 
            this.BTN_AjoutStats.Location = new System.Drawing.Point(12, 603);
            this.BTN_AjoutStats.Name = "BTN_AjoutStats";
            this.BTN_AjoutStats.Size = new System.Drawing.Size(164, 32);
            this.BTN_AjoutStats.TabIndex = 4;
            this.BTN_AjoutStats.Text = "Ajouter stats";
            this.BTN_AjoutStats.UseVisualStyleBackColor = true;
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(992, 603);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(164, 32);
            this.BTN_Fermer.TabIndex = 4;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // DGV_Matchs
            // 
            this.DGV_Matchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Matchs.Location = new System.Drawing.Point(12, 235);
            this.DGV_Matchs.MultiSelect = false;
            this.DGV_Matchs.Name = "DGV_Matchs";
            this.DGV_Matchs.ReadOnly = true;
            this.DGV_Matchs.RowHeadersVisible = false;
            this.DGV_Matchs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Matchs.RowTemplate.Height = 28;
            this.DGV_Matchs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Matchs.Size = new System.Drawing.Size(1144, 156);
            this.DGV_Matchs.TabIndex = 5;
            this.DGV_Matchs.SelectionChanged += new System.EventHandler(this.DGV_Matchs_SelectionChanged);
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Location = new System.Drawing.Point(12, 435);
            this.DGV_Joueurs.MultiSelect = false;
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.ReadOnly = true;
            this.DGV_Joueurs.RowHeadersVisible = false;
            this.DGV_Joueurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Joueurs.RowTemplate.Height = 28;
            this.DGV_Joueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Joueurs.Size = new System.Drawing.Size(1144, 156);
            this.DGV_Joueurs.TabIndex = 5;
            // 
            // Form_Matchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 647);
            this.Controls.Add(this.DGV_Joueurs);
            this.Controls.Add(this.DGV_Matchs);
            this.Controls.Add(this.BTN_Stats);
            this.Controls.Add(this.BTN_Calendrier);
            this.Controls.Add(this.BTN_ModifierMatch);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_AjoutStats);
            this.Controls.Add(this.BTN_AjoutRencontre);
            this.Controls.Add(this.TB_EquipeAway);
            this.Controls.Add(this.TB_EquipeHome);
            this.Controls.Add(this.PB_EquipeHome);
            this.Controls.Add(this.PB_EquipeAway);
            this.Controls.Add(this.LB_EquipeAway);
            this.Controls.Add(this.LB_EquipeHome);
            this.Name = "Form_Matchs";
            this.Text = "Form_Match";
            this.Load += new System.EventHandler(this.Form_Matchs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Matchs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_EquipeHome;
        private System.Windows.Forms.Label LB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeAway;
        private System.Windows.Forms.PictureBox PB_EquipeHome;
        private System.Windows.Forms.TextBox TB_EquipeHome;
        private System.Windows.Forms.TextBox TB_EquipeAway;
        private System.Windows.Forms.Button BTN_AjoutRencontre;
        private System.Windows.Forms.Button BTN_ModifierMatch;
        private System.Windows.Forms.Button BTN_Calendrier;
        private System.Windows.Forms.Button BTN_Stats;
        private System.Windows.Forms.Button BTN_AjoutStats;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.DataGridView DGV_Matchs;
        private System.Windows.Forms.DataGridView DGV_Joueurs;

    }
}