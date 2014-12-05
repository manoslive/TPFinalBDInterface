namespace TPFinal
{
    partial class Form_APropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_APropos));
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PB_Lego = new System.Windows.Forms.PictureBox();
            this.PB_Manu = new System.Windows.Forms.PictureBox();
            this.PB_Shaun = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Manu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Shaun)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(474, 359);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(100, 31);
            this.BTN_Fermer.TabIndex = 0;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.57068F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.42932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Controls.Add(this.PB_Manu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PB_Shaun, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PB_Lego, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.53791F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(570, 157);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PB_Lego
            // 
            this.PB_Lego.Dock = System.Windows.Forms.DockStyle.Right;
            this.PB_Lego.Image = global::TPFinal.Properties.Resources.joueur_hockey_lego;
            this.PB_Lego.Location = new System.Drawing.Point(200, 3);
            this.PB_Lego.Name = "PB_Lego";
            this.PB_Lego.Size = new System.Drawing.Size(179, 185);
            this.PB_Lego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Lego.TabIndex = 1;
            this.PB_Lego.TabStop = false;
            // 
            // PB_Manu
            // 
            this.PB_Manu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_Manu.Image = global::TPFinal.Properties.Resources.avatar;
            this.PB_Manu.Location = new System.Drawing.Point(3, 3);
            this.PB_Manu.Name = "PB_Manu";
            this.PB_Manu.Size = new System.Drawing.Size(191, 185);
            this.PB_Manu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Manu.TabIndex = 0;
            this.PB_Manu.TabStop = false;
            this.PB_Manu.Click += new System.EventHandler(this.PB_Manu_Click);
            // 
            // PB_Shaun
            // 
            this.PB_Shaun.Image = global::TPFinal.Properties.Resources.shaun;
            this.PB_Shaun.Location = new System.Drawing.Point(385, 3);
            this.PB_Shaun.Name = "PB_Shaun";
            this.PB_Shaun.Size = new System.Drawing.Size(184, 185);
            this.PB_Shaun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Shaun.TabIndex = 0;
            this.PB_Shaun.TabStop = false;
            this.PB_Shaun.Click += new System.EventHandler(this.PB_Shaun_Click);
            // 
            // Form_APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 402);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BTN_Fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_APropos";
            this.Text = "Form_APropos";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Manu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Shaun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PB_Manu;
        private System.Windows.Forms.PictureBox PB_Shaun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox PB_Lego;
    }
}