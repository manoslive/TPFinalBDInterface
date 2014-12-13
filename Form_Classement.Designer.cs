namespace TPFinal
{
    partial class Form_Classement
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
            this.DGV_Classement = new System.Windows.Forms.DataGridView();
            this.LB_Division = new System.Windows.Forms.Label();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.MS_Equipe = new System.Windows.Forms.MenuStrip();
            this.fonctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.MS_Equipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Classement
            // 
            this.DGV_Classement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Classement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Classement.Location = new System.Drawing.Point(30, 54);
            this.DGV_Classement.MultiSelect = false;
            this.DGV_Classement.Name = "DGV_Classement";
            this.DGV_Classement.ReadOnly = true;
            this.DGV_Classement.RowHeadersVisible = false;
            this.DGV_Classement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Classement.RowTemplate.Height = 28;
            this.DGV_Classement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Classement.Size = new System.Drawing.Size(579, 289);
            this.DGV_Classement.TabIndex = 1;
            // 
            // LB_Division
            // 
            this.LB_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(327, 355);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 6;
            this.LB_Division.Text = "Division";
            // 
            // CB_Division
            // 
            this.CB_Division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Toutes"});
            this.CB_Division.Location = new System.Drawing.Point(328, 377);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(152, 28);
            this.CB_Division.TabIndex = 0;
            this.CB_Division.SelectedIndexChanged += new System.EventHandler(this.CB_Division_SelectedIndexChanged);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(549, 354);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(60, 62);
            this.PB_Fermer_Gif.TabIndex = 8;
            this.PB_Fermer_Gif.TabStop = false;
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
            this.FB_Fermer.ImageDisable = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Fermer;
            this.FB_Fermer.ImageOver = null;
            this.FB_Fermer.Location = new System.Drawing.Point(549, 354);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(60, 62);
            this.FB_Fermer.TabIndex = 7;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // MS_Equipe
            // 
            this.MS_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonctionsToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MS_Equipe.Location = new System.Drawing.Point(0, 0);
            this.MS_Equipe.Name = "MS_Equipe";
            this.MS_Equipe.Size = new System.Drawing.Size(621, 33);
            this.MS_Equipe.TabIndex = 15;
            this.MS_Equipe.Text = "menuStrip1";
            // 
            // fonctionsToolStripMenuItem
            // 
            this.fonctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem1});
            this.fonctionsToolStripMenuItem.Name = "fonctionsToolStripMenuItem";
            this.fonctionsToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.fonctionsToolStripMenuItem.Text = "Fonctions";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(198, 30);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
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
            // Form_Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 418);
            this.Controls.Add(this.MS_Equipe);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.DGV_Classement);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1036, 765);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 296);
            this.Name = "Form_Classement";
            this.Text = "Form_Classement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Classement_FormClosing);
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Classement_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.MS_Equipe.ResumeLayout(false);
            this.MS_Equipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Classement;
        private System.Windows.Forms.Label LB_Division;
        public System.Windows.Forms.ComboBox CB_Division;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private System.Windows.Forms.MenuStrip MS_Equipe;
        private System.Windows.Forms.ToolStripMenuItem fonctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    }
}