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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.LB_Division = new System.Windows.Forms.Label();
            this.CB_Division = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Classement
            // 
            this.DGV_Classement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Classement.Location = new System.Drawing.Point(22, 24);
            this.DGV_Classement.MultiSelect = false;
            this.DGV_Classement.Name = "DGV_Classement";
            this.DGV_Classement.ReadOnly = true;
            this.DGV_Classement.RowHeadersVisible = false;
            this.DGV_Classement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Classement.RowTemplate.Height = 28;
            this.DGV_Classement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Classement.Size = new System.Drawing.Size(586, 350);
            this.DGV_Classement.TabIndex = 1;
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(506, 400);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(102, 33);
            this.BTN_Fermer.TabIndex = 2;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // LB_Division
            // 
            this.LB_Division.AutoSize = true;
            this.LB_Division.Location = new System.Drawing.Point(325, 386);
            this.LB_Division.Name = "LB_Division";
            this.LB_Division.Size = new System.Drawing.Size(63, 20);
            this.LB_Division.TabIndex = 6;
            this.LB_Division.Text = "Division";
            // 
            // CB_Division
            // 
            this.CB_Division.FormattingEnabled = true;
            this.CB_Division.Items.AddRange(new object[] {
            "Est / Ouest"});
            this.CB_Division.Location = new System.Drawing.Point(329, 408);
            this.CB_Division.Name = "CB_Division";
            this.CB_Division.Size = new System.Drawing.Size(152, 28);
            this.CB_Division.TabIndex = 5;
            // 
            // Form_Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 447);
            this.Controls.Add(this.LB_Division);
            this.Controls.Add(this.CB_Division);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.DGV_Classement);
            this.Name = "Form_Classement";
            this.Text = "Form_Classement";
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Classement;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Label LB_Division;
        public System.Windows.Forms.ComboBox CB_Division;

    }
}