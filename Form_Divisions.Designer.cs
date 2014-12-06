﻿namespace TPFinal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Divisions));
            this.DGV_Divisions = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FB_SupprimerDivision = new FlashButton.FlashButton();
            this.FB_ModifierDivision = new FlashButton.FlashButton();
            this.FB_AjouterDivision = new FlashButton.FlashButton();
            this.PB_Fermer_Gif = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.CM_Divisions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Divisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).BeginInit();
            this.CM_Divisions.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Divisions
            // 
            this.DGV_Divisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Divisions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Divisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Divisions.ContextMenuStrip = this.CM_Divisions;
            this.DGV_Divisions.Location = new System.Drawing.Point(12, 43);
            this.DGV_Divisions.MultiSelect = false;
            this.DGV_Divisions.Name = "DGV_Divisions";
            this.DGV_Divisions.ReadOnly = true;
            this.DGV_Divisions.RowHeadersVisible = false;
            this.DGV_Divisions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Divisions.RowTemplate.Height = 28;
            this.DGV_Divisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Divisions.Size = new System.Drawing.Size(330, 194);
            this.DGV_Divisions.TabIndex = 6;
            this.DGV_Divisions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Divisions_CellMouseDoubleClick);
            // 
            // FB_SupprimerDivision
            // 
            this.FB_SupprimerDivision.BackColor = System.Drawing.Color.Transparent;
            this.FB_SupprimerDivision.BackgroundImage = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_SupprimerDivision.ImageClick = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Click;
            this.FB_SupprimerDivision.ImageDisable = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerDivision.ImageNeutral = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer;
            this.FB_SupprimerDivision.ImageOver = global::TPFinal.Properties.Resources.ICON_Equipe_Supprimer_Over;
            this.FB_SupprimerDivision.Location = new System.Drawing.Point(390, 98);
            this.FB_SupprimerDivision.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_SupprimerDivision.Name = "FB_SupprimerDivision";
            this.FB_SupprimerDivision.Size = new System.Drawing.Size(69, 71);
            this.FB_SupprimerDivision.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FB_SupprimerDivision, "Supprimer une division");
            this.FB_SupprimerDivision.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // FB_ModifierDivision
            // 
            this.FB_ModifierDivision.BackColor = System.Drawing.Color.Transparent;
            this.FB_ModifierDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_ModifierDivision.BackgroundImage")));
            this.FB_ModifierDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ModifierDivision.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_ModifierDivision.ImageClick")));
            this.FB_ModifierDivision.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_ModifierDivision.ImageDisable")));
            this.FB_ModifierDivision.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_ModifierDivision.ImageNeutral")));
            this.FB_ModifierDivision.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_ModifierDivision.ImageOver")));
            this.FB_ModifierDivision.Location = new System.Drawing.Point(430, 22);
            this.FB_ModifierDivision.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_ModifierDivision.Name = "FB_ModifierDivision";
            this.FB_ModifierDivision.Size = new System.Drawing.Size(69, 71);
            this.FB_ModifierDivision.TabIndex = 17;
            this.toolTip1.SetToolTip(this.FB_ModifierDivision, "Modifier une division");
            this.FB_ModifierDivision.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // FB_AjouterDivision
            // 
            this.FB_AjouterDivision.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_AjouterDivision.BackgroundImage")));
            this.FB_AjouterDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AjouterDivision.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_AjouterDivision.ImageClick")));
            this.FB_AjouterDivision.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_AjouterDivision.ImageDisable")));
            this.FB_AjouterDivision.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_AjouterDivision.ImageNeutral")));
            this.FB_AjouterDivision.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_AjouterDivision.ImageOver")));
            this.FB_AjouterDivision.Location = new System.Drawing.Point(350, 22);
            this.FB_AjouterDivision.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_AjouterDivision.Name = "FB_AjouterDivision";
            this.FB_AjouterDivision.Size = new System.Drawing.Size(69, 71);
            this.FB_AjouterDivision.TabIndex = 16;
            this.toolTip1.SetToolTip(this.FB_AjouterDivision, "Ajouter une division");
            this.FB_AjouterDivision.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // PB_Fermer_Gif
            // 
            this.PB_Fermer_Gif.Image = global::TPFinal.Properties.Resources.ICON_Fermer_Over;
            this.PB_Fermer_Gif.Location = new System.Drawing.Point(393, 175);
            this.PB_Fermer_Gif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fermer_Gif.Name = "PB_Fermer_Gif";
            this.PB_Fermer_Gif.Size = new System.Drawing.Size(60, 62);
            this.PB_Fermer_Gif.TabIndex = 15;
            this.PB_Fermer_Gif.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_Fermer_Gif, "Fermer");
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
            this.FB_Fermer.Location = new System.Drawing.Point(393, 175);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(60, 62);
            this.FB_Fermer.TabIndex = 14;
            this.FB_Fermer.MouseEnter += new System.EventHandler(this.FB_Fermer_MouseEnter);
            // 
            // CM_Divisions
            // 
            this.CM_Divisions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.CM_Divisions.Name = "CM_Divisions";
            this.CM_Divisions.Size = new System.Drawing.Size(168, 124);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form_Divisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 249);
            this.ContextMenuStrip = this.CM_Divisions;
            this.Controls.Add(this.FB_SupprimerDivision);
            this.Controls.Add(this.FB_ModifierDivision);
            this.Controls.Add(this.FB_AjouterDivision);
            this.Controls.Add(this.PB_Fermer_Gif);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.DGV_Divisions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Divisions";
            this.Text = "Form_Divisions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Divisions_FormClosed);
            this.Load += new System.EventHandler(this.Form_Divisions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Divisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fermer_Gif)).EndInit();
            this.CM_Divisions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Divisions;
        private System.Windows.Forms.PictureBox PB_Fermer_Gif;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_SupprimerDivision;
        private FlashButton.FlashButton FB_ModifierDivision;
        private FlashButton.FlashButton FB_AjouterDivision;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip CM_Divisions;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}