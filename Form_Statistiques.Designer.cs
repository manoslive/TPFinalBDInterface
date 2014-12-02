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
            this.DGV_Stats = new System.Windows.Forms.DataGridView();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.LB_TempsPunition = new System.Windows.Forms.Label();
            this.LB_NbPoints = new System.Windows.Forms.Label();
            this.LB_NbPasses = new System.Windows.Forms.Label();
            this.LB_NbButs = new System.Windows.Forms.Label();
            this.LB_Equipe = new System.Windows.Forms.Label();
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.TB_NbPoints = new System.Windows.Forms.TextBox();
            this.TB_NbPasses = new System.Windows.Forms.TextBox();
            this.TB_NbButs = new System.Windows.Forms.TextBox();
            this.TB_Equipe = new System.Windows.Forms.TextBox();
            this.TB_NumJoueur = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Stats
            // 
            this.DGV_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stats.Location = new System.Drawing.Point(2, 555);
            this.DGV_Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Stats.Name = "DGV_Stats";
            this.DGV_Stats.Size = new System.Drawing.Size(10, 10);
            this.DGV_Stats.TabIndex = 28;
            this.DGV_Stats.Visible = false;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(268, 517);
            this.BTN_Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(112, 35);
            this.BTN_Ok.TabIndex = 27;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // LB_TempsPunition
            // 
            this.LB_TempsPunition.AutoSize = true;
            this.LB_TempsPunition.Location = new System.Drawing.Point(13, 405);
            this.LB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TempsPunition.Name = "LB_TempsPunition";
            this.LB_TempsPunition.Size = new System.Drawing.Size(139, 20);
            this.LB_TempsPunition.TabIndex = 13;
            this.LB_TempsPunition.Text = "Temps de punition";
            // 
            // LB_NbPoints
            // 
            this.LB_NbPoints.AutoSize = true;
            this.LB_NbPoints.Location = new System.Drawing.Point(13, 352);
            this.LB_NbPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPoints.Name = "LB_NbPoints";
            this.LB_NbPoints.Size = new System.Drawing.Size(163, 20);
            this.LB_NbPoints.TabIndex = 14;
            this.LB_NbPoints.Text = "Nombres points totals";
            // 
            // LB_NbPasses
            // 
            this.LB_NbPasses.AutoSize = true;
            this.LB_NbPasses.Location = new System.Drawing.Point(13, 299);
            this.LB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPasses.Name = "LB_NbPasses";
            this.LB_NbPasses.Size = new System.Drawing.Size(150, 20);
            this.LB_NbPasses.TabIndex = 15;
            this.LB_NbPasses.Text = "Nombres de passes";
            // 
            // LB_NbButs
            // 
            this.LB_NbButs.AutoSize = true;
            this.LB_NbButs.Location = new System.Drawing.Point(13, 245);
            this.LB_NbButs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbButs.Name = "LB_NbButs";
            this.LB_NbButs.Size = new System.Drawing.Size(130, 20);
            this.LB_NbButs.TabIndex = 16;
            this.LB_NbButs.Text = "Nombres de buts";
            // 
            // LB_Equipe
            // 
            this.LB_Equipe.AutoSize = true;
            this.LB_Equipe.Location = new System.Drawing.Point(13, 190);
            this.LB_Equipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Equipe.Name = "LB_Equipe";
            this.LB_Equipe.Size = new System.Drawing.Size(112, 20);
            this.LB_Equipe.TabIndex = 17;
            this.LB_Equipe.Text = "Équipe Joueur";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(13, 20);
            this.LB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(118, 20);
            this.LB_NumJoueur.TabIndex = 18;
            this.LB_NumJoueur.Text = "Numero Joueur";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(13, 80);
            this.LB_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(42, 20);
            this.LB_Nom.TabIndex = 11;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(13, 134);
            this.LB_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(64, 20);
            this.LB_Prenom.TabIndex = 19;
            this.LB_Prenom.Text = "Prénom";
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(196, 405);
            this.TB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.ReadOnly = true;
            this.TB_TempsPunition.Size = new System.Drawing.Size(170, 26);
            this.TB_TempsPunition.TabIndex = 26;
            // 
            // TB_NbPoints
            // 
            this.TB_NbPoints.Location = new System.Drawing.Point(196, 352);
            this.TB_NbPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPoints.Name = "TB_NbPoints";
            this.TB_NbPoints.ReadOnly = true;
            this.TB_NbPoints.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPoints.TabIndex = 25;
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(196, 299);
            this.TB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.ReadOnly = true;
            this.TB_NbPasses.Size = new System.Drawing.Size(170, 26);
            this.TB_NbPasses.TabIndex = 24;
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(196, 245);
            this.TB_NbButs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.ReadOnly = true;
            this.TB_NbButs.Size = new System.Drawing.Size(170, 26);
            this.TB_NbButs.TabIndex = 23;
            // 
            // TB_Equipe
            // 
            this.TB_Equipe.Location = new System.Drawing.Point(196, 190);
            this.TB_Equipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Equipe.Name = "TB_Equipe";
            this.TB_Equipe.ReadOnly = true;
            this.TB_Equipe.Size = new System.Drawing.Size(170, 26);
            this.TB_Equipe.TabIndex = 22;
            // 
            // TB_NumJoueur
            // 
            this.TB_NumJoueur.Location = new System.Drawing.Point(196, 20);
            this.TB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NumJoueur.Name = "TB_NumJoueur";
            this.TB_NumJoueur.ReadOnly = true;
            this.TB_NumJoueur.Size = new System.Drawing.Size(170, 26);
            this.TB_NumJoueur.TabIndex = 12;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(196, 80);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(170, 26);
            this.TB_Nom.TabIndex = 20;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(196, 134);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.ReadOnly = true;
            this.TB_Prenom.Size = new System.Drawing.Size(170, 26);
            this.TB_Prenom.TabIndex = 21;
            // 
            // Form_Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 571);
            this.Controls.Add(this.DGV_Stats);
            this.Controls.Add(this.BTN_Ok);
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
            this.Controls.Add(this.TB_Equipe);
            this.Controls.Add(this.TB_NumJoueur);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_Prenom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Statistiques";
            this.Text = "Form_Statistiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Statistiques_FormClosing);
            this.Load += new System.EventHandler(this.Form_Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Stats;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label LB_TempsPunition;
        private System.Windows.Forms.Label LB_NbPoints;
        private System.Windows.Forms.Label LB_NbPasses;
        private System.Windows.Forms.Label LB_NbButs;
        private System.Windows.Forms.Label LB_Equipe;
        private System.Windows.Forms.Label LB_NumJoueur;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.TextBox TB_TempsPunition;
        private System.Windows.Forms.TextBox TB_NbPoints;
        private System.Windows.Forms.TextBox TB_NbPasses;
        private System.Windows.Forms.TextBox TB_NbButs;
        private System.Windows.Forms.TextBox TB_Equipe;
        private System.Windows.Forms.TextBox TB_NumJoueur;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prenom;

    }
}