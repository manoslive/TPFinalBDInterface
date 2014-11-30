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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.RowTemplate.Height = 28;
            this.DGV_Equipes.Size = new System.Drawing.Size(633, 247);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTN_Classement
            // 
            this.BTN_Classement.Location = new System.Drawing.Point(121, 288);
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
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(670, 183);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(119, 40);
            this.BTN_Modifier.TabIndex = 1;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
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
            this.BTN_Top5.Location = new System.Drawing.Point(421, 288);
            this.BTN_Top5.Name = "BTN_Top5";
            this.BTN_Top5.Size = new System.Drawing.Size(119, 40);
            this.BTN_Top5.TabIndex = 1;
            this.BTN_Top5.Text = "Top 5";
            this.BTN_Top5.UseVisualStyleBackColor = true;
            this.BTN_Top5.Click += new System.EventHandler(this.BTN_Top5_Click);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(670, 288);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(119, 40);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPFinal.Properties.Resources.hockey_cosom7_9;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(661, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 119);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Top5);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Classement);
            this.Controls.Add(this.DGV_Equipes);
            this.Name = "Form_Equipes";
            this.Text = "Form_Equipe";
            this.Load += new System.EventHandler(this.Form_Equipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.Button BTN_Classement;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Top5;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}