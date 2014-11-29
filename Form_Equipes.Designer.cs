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
            this.BTN_Equipes = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.RowTemplate.Height = 28;
            this.DGV_Equipes.Size = new System.Drawing.Size(590, 398);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTN_Classement
            // 
            this.BTN_Classement.Location = new System.Drawing.Point(22, 454);
            this.BTN_Classement.Name = "BTN_Classement";
            this.BTN_Classement.Size = new System.Drawing.Size(119, 40);
            this.BTN_Classement.TabIndex = 1;
            this.BTN_Classement.Text = "Classement";
            this.BTN_Classement.UseVisualStyleBackColor = true;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(635, 321);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(119, 40);
            this.BTN_Supprimer.TabIndex = 1;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(635, 253);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(119, 40);
            this.BTN_Modifier.TabIndex = 1;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(635, 183);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(119, 40);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // BTN_Top5
            // 
            this.BTN_Top5.Location = new System.Drawing.Point(431, 454);
            this.BTN_Top5.Name = "BTN_Top5";
            this.BTN_Top5.Size = new System.Drawing.Size(119, 40);
            this.BTN_Top5.TabIndex = 1;
            this.BTN_Top5.Text = "Top 5";
            this.BTN_Top5.UseVisualStyleBackColor = true;
            // 
            // BTN_Equipes
            // 
            this.BTN_Equipes.Location = new System.Drawing.Point(224, 454);
            this.BTN_Equipes.Name = "BTN_Equipes";
            this.BTN_Equipes.Size = new System.Drawing.Size(119, 40);
            this.BTN_Equipes.TabIndex = 1;
            this.BTN_Equipes.Text = "Équipes";
            this.BTN_Equipes.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(635, 454);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(119, 40);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // Form_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 539);
            this.Controls.Add(this.BTN_Equipes);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Top5);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Classement);
            this.Controls.Add(this.DGV_Equipes);
            this.Name = "Form_Equipe";
            this.Text = "Form_Equipe";
            this.Load += new System.EventHandler(this.Form_Equipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.Button BTN_Classement;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Top5;
        private System.Windows.Forms.Button BTN_Equipes;
        private System.Windows.Forms.Button BTN_Ok;
    }
}