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
            this.DGV_Equipes = new System.Windows.Forms.DataGridView();
            this.BTN_Classement = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Top5 = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.BTN_Matchs = new System.Windows.Forms.Button();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.LB_Division = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipes.MultiSelect = false;
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.ReadOnly = true;
            this.DGV_Equipes.RowHeadersVisible = false;
            this.DGV_Equipes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Equipes.RowTemplate.Height = 28;
            this.DGV_Equipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Equipes.Size = new System.Drawing.Size(586, 247);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Equipes_CellMouseDoubleClick);
            this.DGV_Equipes.SelectionChanged += new System.EventHandler(this.DGV_Equipes_SelectionChanged);
            // 
            // BTN_Classement
            // 
            this.BTN_Classement.Location = new System.Drawing.Point(148, 288);
            this.BTN_Classement.Name = "BTN_Classement";
            this.BTN_Classement.Size = new System.Drawing.Size(119, 40);
            this.BTN_Classement.TabIndex = 1;
            this.BTN_Classement.Text = "Classement";
            this.BTN_Classement.UseVisualStyleBackColor = true;
            this.BTN_Classement.Click += new System.EventHandler(this.BTN_Classement_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(670, 229);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(119, 40);
            this.BTN_Supprimer.TabIndex = 1;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(670, 183);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(119, 40);
            this.BTN_Modifier.TabIndex = 1;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(670, 137);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(119, 40);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Top5
            // 
            this.BTN_Top5.Location = new System.Drawing.Point(286, 288);
            this.BTN_Top5.Name = "BTN_Top5";
            this.BTN_Top5.Size = new System.Drawing.Size(119, 40);
            this.BTN_Top5.TabIndex = 1;
            this.BTN_Top5.Text = "Top 5";
            this.BTN_Top5.UseVisualStyleBackColor = true;
            this.BTN_Top5.Click += new System.EventHandler(this.BTN_Top5_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(670, 288);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(119, 40);
            this.BTN_Fermer.TabIndex = 1;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Equipe.ErrorImage = global::TPFinal.Properties.Resources.no_picture;
            this.PB_Equipe.Location = new System.Drawing.Point(661, 12);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(140, 119);
            this.PB_Equipe.TabIndex = 2;
            this.PB_Equipe.TabStop = false;
            // 
            // BTN_Matchs
            // 
            this.BTN_Matchs.Location = new System.Drawing.Point(12, 288);
            this.BTN_Matchs.Name = "BTN_Matchs";
            this.BTN_Matchs.Size = new System.Drawing.Size(119, 40);
            this.BTN_Matchs.TabIndex = 1;
            this.BTN_Matchs.Text = "Matchs";
            this.BTN_Matchs.UseVisualStyleBackColor = true;
            this.BTN_Matchs.Click += new System.EventHandler(this.BTN_Matchs_Click);
            // 
            // CB_Division
            // 
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Est / Ouest"});
            this.CB_Division.Location = new System.Drawing.Point(461, 295);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(152, 28);
            this.CB_Division.TabIndex = 3;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(457, 273);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 4;
            this.LB_Division.Text = "Division";
            // 
            // Form_Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 343);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.PB_Equipe);
            this.Controls.Add(this.BTN_Matchs);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Top5);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Classement);
            this.Controls.Add(this.DGV_Equipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Equipes";
            this.Text = "Form_Equipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipes_FormClosing);
            this.Load += new System.EventHandler(this.Form_Equipe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Equipes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.Button BTN_Classement;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Top5;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.Button BTN_Matchs;
        public System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.Label LB_Division;
    }
}