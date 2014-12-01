namespace TPFinal
{
    partial class Form_Top5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PB_Top1 = new System.Windows.Forms.PictureBox();
            this.PB_Top3 = new System.Windows.Forms.PictureBox();
            this.PB_Top2 = new System.Windows.Forms.PictureBox();
            this.DGV_Top3 = new System.Windows.Forms.DataGridView();
            this.LB_Top1 = new System.Windows.Forms.Label();
            this.LB_Top2 = new System.Windows.Forms.Label();
            this.LB_Top3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TPFinal.Properties.Resources.Podium;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PB_Top1
            // 
            this.PB_Top1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top1.Location = new System.Drawing.Point(200, 33);
            this.PB_Top1.Name = "PB_Top1";
            this.PB_Top1.Size = new System.Drawing.Size(117, 87);
            this.PB_Top1.TabIndex = 1;
            this.PB_Top1.TabStop = false;
            // 
            // PB_Top3
            // 
            this.PB_Top3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top3.Location = new System.Drawing.Point(346, 103);
            this.PB_Top3.Name = "PB_Top3";
            this.PB_Top3.Size = new System.Drawing.Size(117, 87);
            this.PB_Top3.TabIndex = 2;
            this.PB_Top3.TabStop = false;
            // 
            // PB_Top2
            // 
            this.PB_Top2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top2.Location = new System.Drawing.Point(55, 75);
            this.PB_Top2.Name = "PB_Top2";
            this.PB_Top2.Size = new System.Drawing.Size(117, 87);
            this.PB_Top2.TabIndex = 3;
            this.PB_Top2.TabStop = false;
            // 
            // DGV_Top3
            // 
            this.DGV_Top3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Top3.Location = new System.Drawing.Point(247, 222);
            this.DGV_Top3.Name = "DGV_Top3";
            this.DGV_Top3.Size = new System.Drawing.Size(10, 10);
            this.DGV_Top3.TabIndex = 4;
            this.DGV_Top3.Visible = false;
            // 
            // LB_Top1
            // 
            this.LB_Top1.AutoSize = true;
            this.LB_Top1.Location = new System.Drawing.Point(244, 17);
            this.LB_Top1.Name = "LB_Top1";
            this.LB_Top1.Size = new System.Drawing.Size(35, 13);
            this.LB_Top1.TabIndex = 5;
            this.LB_Top1.Text = "label1";
            // 
            // LB_Top2
            // 
            this.LB_Top2.AutoSize = true;
            this.LB_Top2.Location = new System.Drawing.Point(94, 59);
            this.LB_Top2.Name = "LB_Top2";
            this.LB_Top2.Size = new System.Drawing.Size(35, 13);
            this.LB_Top2.TabIndex = 6;
            this.LB_Top2.Text = "label2";
            // 
            // LB_Top3
            // 
            this.LB_Top3.AutoSize = true;
            this.LB_Top3.Location = new System.Drawing.Point(390, 87);
            this.LB_Top3.Name = "LB_Top3";
            this.LB_Top3.Size = new System.Drawing.Size(35, 13);
            this.LB_Top3.TabIndex = 7;
            this.LB_Top3.Text = "label3";
            // 
            // Form_Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 263);
            this.Controls.Add(this.LB_Top3);
            this.Controls.Add(this.LB_Top2);
            this.Controls.Add(this.LB_Top1);
            this.Controls.Add(this.DGV_Top3);
            this.Controls.Add(this.PB_Top2);
            this.Controls.Add(this.PB_Top3);
            this.Controls.Add(this.PB_Top1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Top5";
            this.Text = "Form_Top5";
            this.Load += new System.EventHandler(this.Form_Top5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Top3)).EndInit();
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
    }
}