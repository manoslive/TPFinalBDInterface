namespace TPFinal
{
    partial class Form_Ajouter_Equipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajouter_Equipe));
            this.LB_Equipe = new System.Windows.Forms.Label();
            this.LB_DateCreation = new System.Windows.Forms.Label();
            this.LB_Division = new System.Windows.Forms.Label();
            this.LB_Ville = new System.Windows.Forms.Label();
            this.TB_NomEquipe = new System.Windows.Forms.TextBox();
            this.DTP_Creation = new System.Windows.Forms.DateTimePicker();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.TB_Ville = new System.Windows.Forms.TextBox();
            this.BTN_ChargerImage = new System.Windows.Forms.Button();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Equipe
            // 
            this.LB_Equipe.AutoSize = true;
            this.LB_Equipe.Location = new System.Drawing.Point(12, 22);
            this.LB_Equipe.Name = "LB_Equipe";
            this.LB_Equipe.Size = new System.Drawing.Size(94, 20);
            this.LB_Equipe.TabIndex = 0;
            this.LB_Equipe.Text = "Nom équipe";
            // 
            // LB_DateCreation
            // 
            this.LB_DateCreation.AutoSize = true;
            this.LB_DateCreation.Location = new System.Drawing.Point(12, 118);
            this.LB_DateCreation.Name = "LB_DateCreation";
            this.LB_DateCreation.Size = new System.Drawing.Size(127, 20);
            this.LB_DateCreation.TabIndex = 0;
            this.LB_DateCreation.Text = "Date de création";
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(12, 214);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 0;
            this.LB_Division.Text = "Division";
            // 
            // LB_Ville
            // 
            this.LB_Ville.AutoSize = true;
            this.LB_Ville.Location = new System.Drawing.Point(12, 315);
            this.LB_Ville.Name = "LB_Ville";
            this.LB_Ville.Size = new System.Drawing.Size(38, 20);
            this.LB_Ville.TabIndex = 0;
            this.LB_Ville.Text = "Ville";
            // 
            // TB_NomEquipe
            // 
            this.TB_NomEquipe.Location = new System.Drawing.Point(16, 55);
            this.TB_NomEquipe.Name = "TB_NomEquipe";
            this.TB_NomEquipe.Size = new System.Drawing.Size(200, 26);
            this.TB_NomEquipe.TabIndex = 0;
            this.TB_NomEquipe.TextChanged += new System.EventHandler(this.TB_NomEquipe_TextChanged);
            // 
            // DTP_Creation
            // 
            this.DTP_Creation.Location = new System.Drawing.Point(16, 155);
            this.DTP_Creation.Name = "DTP_Creation";
            this.DTP_Creation.Size = new System.Drawing.Size(200, 26);
            this.DTP_Creation.TabIndex = 1;
            this.DTP_Creation.ValueChanged += new System.EventHandler(this.DTP_Creation_ValueChanged);
            // 
            // CB_Division
            // 
            this.CB_Division.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Division.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Location = new System.Drawing.Point(16, 252);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(200, 28);
            this.CB_Division.TabIndex = 2;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // TB_Ville
            // 
            this.TB_Ville.Location = new System.Drawing.Point(16, 352);
            this.TB_Ville.Name = "TB_Ville";
            this.TB_Ville.Size = new System.Drawing.Size(200, 26);
            this.TB_Ville.TabIndex = 3;
            this.TB_Ville.TextChanged += new System.EventHandler(this.TB_Ville_TextChanged);
            // 
            // BTN_ChargerImage
            // 
            this.BTN_ChargerImage.Location = new System.Drawing.Point(290, 214);
            this.BTN_ChargerImage.Name = "BTN_ChargerImage";
            this.BTN_ChargerImage.Size = new System.Drawing.Size(183, 38);
            this.BTN_ChargerImage.TabIndex = 4;
            this.BTN_ChargerImage.Text = "Charger image";
            this.BTN_ChargerImage.UseVisualStyleBackColor = true;
            this.BTN_ChargerImage.Click += new System.EventHandler(this.BTN_ChargerImage_Click);
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.Location = new System.Drawing.Point(290, 22);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(183, 160);
            this.PB_Equipe.TabIndex = 6;
            this.PB_Equipe.TabStop = false;
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(412, 408);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(60, 62);
            this.PB_Fermer_Gif.TabIndex = 9;
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
            this.FB_Fermer.Location = new System.Drawing.Point(412, 411);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(60, 62);
            this.FB_Fermer.TabIndex = 8;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Cancel_MouseEnter);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ajouter.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Click;
            this.FB_Ajouter.ImageDisable = null;
            this.FB_Ajouter.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter;
            this.FB_Ajouter.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Ajouter_Over;
            this.FB_Ajouter.Location = new System.Drawing.Point(322, 408);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(63, 65);
            this.FB_Ajouter.TabIndex = 7;
            this.toolTip1.SetToolTip(this.FB_Ajouter, "Ajouter l\'équipe");
            this.FB_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // Form_Ajouter_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 488);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.FB_Ajouter);
            this.Controls.Add(this.BTN_ChargerImage);
            this.Controls.Add(this.PB_Equipe);
            this.Controls.Add(this.TB_Ville);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.DTP_Creation);
            this.Controls.Add(this.TB_NomEquipe);
            this.Controls.Add(this.LB_Ville);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.LB_DateCreation);
            this.Controls.Add(this.LB_Equipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Ajouter_Equipe";
            this.Text = "Form_Ajouter_Equipe";
            this.Load += new System.EventHandler(this.FormEquipe_Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Equipe;
        private System.Windows.Forms.Label LB_DateCreation;
        private System.Windows.Forms.Label LB_Division;
        private System.Windows.Forms.Label LB_Ville;
        private System.Windows.Forms.TextBox TB_NomEquipe;
        private System.Windows.Forms.DateTimePicker DTP_Creation;
        public System.Windows.Forms.ComboBox CB_Division;
        private System.Windows.Forms.TextBox TB_Ville;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.Button BTN_ChargerImage;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}