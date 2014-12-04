namespace TPFinal
{
    partial class Form_Top3
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
            this.DGV_Top3 = new System.Windows.Forms.DataGridView();
            this.LB_Top1 = new System.Windows.Forms.Label();
            this.LB_Top2 = new System.Windows.Forms.Label();
            this.LB_Top3 = new System.Windows.Forms.Label();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.PB_Top2 = new System.Windows.Forms.PictureBox();
            this.PB_Top3 = new System.Windows.Forms.PictureBox();
            this.PB_Top1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Top3
            // 
            this.DGV_Top3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Top3.Location = new System.Drawing.Point(201, 217);
            this.DGV_Top3.Name = "DGV_Top3";
            this.DGV_Top3.Size = new System.Drawing.Size(10, 10);
            this.DGV_Top3.TabIndex = 4;
            this.DGV_Top3.Visible = false;
            // 
            // LB_Top1
            // 
            this.LB_Top1.AutoSize = true;
            this.LB_Top1.Location = new System.Drawing.Point(198, 12);
            this.LB_Top1.Name = "LB_Top1";
            this.LB_Top1.Size = new System.Drawing.Size(35, 13);
            this.LB_Top1.TabIndex = 5;
            this.LB_Top1.Text = "label1";
            // 
            // LB_Top2
            // 
            this.LB_Top2.AutoSize = true;
            this.LB_Top2.Location = new System.Drawing.Point(48, 54);
            this.LB_Top2.Name = "LB_Top2";
            this.LB_Top2.Size = new System.Drawing.Size(35, 13);
            this.LB_Top2.TabIndex = 6;
            this.LB_Top2.Text = "label2";
            // 
            // LB_Top3
            // 
            this.LB_Top3.AutoSize = true;
            this.LB_Top3.Location = new System.Drawing.Point(344, 82);
            this.LB_Top3.Name = "LB_Top3";
            this.LB_Top3.Size = new System.Drawing.Size(35, 13);
            this.LB_Top3.TabIndex = 7;
            this.LB_Top3.Text = "label3";
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(181, 272);
            this.BTN_Fermer.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(63, 22);
            this.BTN_Fermer.TabIndex = 9;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // PB_Top2
            // 
            this.PB_Top2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top2.Location = new System.Drawing.Point(9, 70);
            this.PB_Top2.Name = "PB_Top2";
            this.PB_Top2.Size = new System.Drawing.Size(117, 87);
            this.PB_Top2.TabIndex = 3;
            this.PB_Top2.TabStop = false;
            // 
            // PB_Top3
            // 
            this.PB_Top3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top3.Location = new System.Drawing.Point(300, 97);
            this.PB_Top3.Name = "PB_Top3";
            this.PB_Top3.Size = new System.Drawing.Size(117, 87);
            this.PB_Top3.TabIndex = 2;
            this.PB_Top3.TabStop = false;
            // 
            // PB_Top1
            // 
            this.PB_Top1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top1.Location = new System.Drawing.Point(154, 28);
            this.PB_Top1.Name = "PB_Top1";
            this.PB_Top1.Size = new System.Drawing.Size(117, 87);
            this.PB_Top1.TabIndex = 1;
            this.PB_Top1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TPFinal.Properties.Resources.Podium;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Top3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 302);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.LB_Top3);
            this.Controls.Add(this.LB_Top2);
            this.Controls.Add(this.LB_Top1);
            this.Controls.Add(this.DGV_Top3);
            this.Controls.Add(this.PB_Top2);
            this.Controls.Add(this.PB_Top3);
            this.Controls.Add(this.PB_Top1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Top3";
            this.Text = "Form_Top5";
            this.Load += new System.EventHandler(this.Form_Top5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PB_Top1;
        private System.Windows.Forms.PictureBox PB_Top3;
        private System.Windows.Forms.PictureBox PB_Top2;
        private System.Windows.Forms.DataGridView DGV_Top3;
        private System.Windows.Forms.Label LB_Top1;
        private System.Windows.Forms.Label LB_Top2;
        private System.Windows.Forms.Label LB_Top3;
        private System.Windows.Forms.Button BTN_Fermer;
    }
}