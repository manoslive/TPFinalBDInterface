namespace TPFinal
{
    partial class Form_Divisions
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
            this.DGV_Divisions = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Divisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Divisions
            // 
            this.DGV_Divisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Divisions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Divisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Divisions.Location = new System.Drawing.Point(8, 28);
            this.DGV_Divisions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Divisions.MultiSelect = false;
            this.DGV_Divisions.Name = "DGV_Divisions";
            this.DGV_Divisions.ReadOnly = true;
            this.DGV_Divisions.RowHeadersVisible = false;
            this.DGV_Divisions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Divisions.RowTemplate.Height = 28;
            this.DGV_Divisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Divisions.Size = new System.Drawing.Size(220, 126);
            this.DGV_Divisions.TabIndex = 6;
            this.DGV_Divisions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Divisions_CellMouseDoubleClick);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(237, 28);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(90, 24);
            this.BTN_Ajouter.TabIndex = 7;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(237, 56);
            this.BTN_Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(90, 24);
            this.BTN_Modifier.TabIndex = 7;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(237, 84);
            this.BTN_Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(90, 24);
            this.BTN_Supprimer.TabIndex = 7;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(262, 114);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(40, 40);
            this.PB_Fermer_Gif.TabIndex = 15;
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
            this.FB_Fermer.Location = new System.Drawing.Point(262, 114);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(40, 40);
            this.FB_Fermer.TabIndex = 14;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // Form_Divisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 162);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Divisions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Divisions";
            this.Text = "Form_Divisions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Divisions_FormClosed);
            this.Load += new System.EventHandler(this.Form_Divisions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Divisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Divisions;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
    }
}