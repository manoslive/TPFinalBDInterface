namespace TPFinal
{
    partial class Form_Ajouter_Stats
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
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.TB_NbPasses = new System.Windows.Forms.TextBox();
            this.TB_NbButs = new System.Windows.Forms.TextBox();
            this.LB_TempsPunition = new System.Windows.Forms.Label();
            this.LB_NbPasses = new System.Windows.Forms.Label();
            this.LB_NbButs = new System.Windows.Forms.Label();
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.LB_NumMatch = new System.Windows.Forms.Label();
            this.CB_NumeroMatch = new System.Windows.Forms.ComboBox();
            this.CB_NumeroJoueur = new System.Windows.Forms.ComboBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(159, 265);
            this.TB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.Size = new System.Drawing.Size(180, 26);
            this.TB_TempsPunition.TabIndex = 4;
            this.TB_TempsPunition.TextChanged += new System.EventHandler(this.TB_TempsPunition_TextChanged);
            this.TB_TempsPunition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(159, 208);
            this.TB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.Size = new System.Drawing.Size(180, 26);
            this.TB_NbPasses.TabIndex = 3;
            this.TB_NbPasses.TextChanged += new System.EventHandler(this.TB_NbPasses_TextChanged);
            this.TB_NbPasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(159, 149);
            this.TB_NbButs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.Size = new System.Drawing.Size(180, 26);
            this.TB_NbButs.TabIndex = 2;
            this.TB_NbButs.TextChanged += new System.EventHandler(this.TB_NbButs_TextChanged);
            this.TB_NbButs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationChamps);
            // 
            // LB_TempsPunition
            // 
            this.LB_TempsPunition.AutoSize = true;
            this.LB_TempsPunition.Location = new System.Drawing.Point(26, 268);
            this.LB_TempsPunition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TempsPunition.Name = "LB_TempsPunition";
            this.LB_TempsPunition.Size = new System.Drawing.Size(118, 20);
            this.LB_TempsPunition.TabIndex = 6;
            this.LB_TempsPunition.Text = "Temps Punition";
            // 
            // LB_NbPasses
            // 
            this.LB_NbPasses.AutoSize = true;
            this.LB_NbPasses.Location = new System.Drawing.Point(26, 211);
            this.LB_NbPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbPasses.Name = "LB_NbPasses";
            this.LB_NbPasses.Size = new System.Drawing.Size(85, 20);
            this.LB_NbPasses.TabIndex = 7;
            this.LB_NbPasses.Text = "Nb Passes";
            // 
            // LB_NbButs
            // 
            this.LB_NbButs.AutoSize = true;
            this.LB_NbButs.Location = new System.Drawing.Point(22, 155);
            this.LB_NbButs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbButs.Name = "LB_NbButs";
            this.LB_NbButs.Size = new System.Drawing.Size(66, 20);
            this.LB_NbButs.TabIndex = 8;
            this.LB_NbButs.Text = "Nb Buts";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(26, 92);
            this.LB_NumJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(113, 20);
            this.LB_NumJoueur.TabIndex = 9;
            this.LB_NumJoueur.Text = "Numéro joueur";
            // 
            // LB_NumMatch
            // 
            this.LB_NumMatch.AutoSize = true;
            this.LB_NumMatch.Location = new System.Drawing.Point(26, 28);
            this.LB_NumMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumMatch.Name = "LB_NumMatch";
            this.LB_NumMatch.Size = new System.Drawing.Size(113, 20);
            this.LB_NumMatch.TabIndex = 10;
            this.LB_NumMatch.Text = "Numero Match";
            // 
            // CB_NumeroMatch
            // 
            this.CB_NumeroMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NumeroMatch.FormattingEnabled = true;
            this.CB_NumeroMatch.Location = new System.Drawing.Point(159, 25);
            this.CB_NumeroMatch.Name = "CB_NumeroMatch";
            this.CB_NumeroMatch.Size = new System.Drawing.Size(180, 28);
            this.CB_NumeroMatch.TabIndex = 0;
            this.CB_NumeroMatch.SelectedIndexChanged += new System.EventHandler(this.CB_NumeroMatch_SelectedIndexChanged);
            // 
            // CB_NumeroJoueur
            // 
            this.CB_NumeroJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NumeroJoueur.FormattingEnabled = true;
            this.CB_NumeroJoueur.Location = new System.Drawing.Point(159, 89);
            this.CB_NumeroJoueur.Name = "CB_NumeroJoueur";
            this.CB_NumeroJoueur.Size = new System.Drawing.Size(180, 28);
            this.CB_NumeroJoueur.TabIndex = 1;
            this.CB_NumeroJoueur.SelectedIndexChanged += new System.EventHandler(this.CB_NumeroJoueur_SelectedIndexChanged);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(278, 322);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(63, 65);
            this.PB_Fermer_Gif.TabIndex = 33;
            this.PB_Fermer_Gif.TabStop = false;
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
            this.FB_Fermer.Location = new System.Drawing.Point(276, 325);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(63, 65);
            this.FB_Fermer.TabIndex = 32;
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
            this.FB_Ajouter.Location = new System.Drawing.Point(204, 322);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(63, 65);
            this.FB_Ajouter.TabIndex = 31;
            this.FB_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // Form_Ajouter_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 405);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.CB_NumeroJoueur);
            this.Controls.Add(this.CB_NumeroMatch);
            this.Controls.Add(this.TB_TempsPunition);
            this.Controls.Add(this.TB_NbPasses);
            this.Controls.Add(this.TB_NbButs);
            this.Controls.Add(this.LB_TempsPunition);
            this.Controls.Add(this.LB_NbPasses);
            this.Controls.Add(this.LB_NbButs);
            this.Controls.Add(this.LB_NumJoueur);
            this.Controls.Add(this.LB_NumMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ajouter_Stats";
            this.Text = "Form_Ajouter_Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ajouter_Stats_FormClosing);
            this.Load += new System.EventHandler(this.Form_Ajouter_Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TempsPunition;
        private System.Windows.Forms.TextBox TB_NbPasses;
        private System.Windows.Forms.TextBox TB_NbButs;
        private System.Windows.Forms.Label LB_TempsPunition;
        private System.Windows.Forms.Label LB_NbPasses;
        private System.Windows.Forms.Label LB_NbButs;
        private System.Windows.Forms.Label LB_NumJoueur;
        private System.Windows.Forms.Label LB_NumMatch;
        private System.Windows.Forms.ComboBox CB_NumeroMatch;
        private System.Windows.Forms.ComboBox CB_NumeroJoueur;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_Ajouter;
    }
}