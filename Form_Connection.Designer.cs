namespace TPFinal
{
    partial class Form_Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Connection));
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.FB_Connection = new FlashButton.FlashButton();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.BackColor = System.Drawing.Color.Transparent;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.Black;
            this.LB_Username.Location = new System.Drawing.Point(130, 430);
            this.LB_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(100, 15);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Nom d\'usagé :";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.Transparent;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.Black;
            this.LB_Password.Location = new System.Drawing.Point(130, 459);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(101, 15);
            this.LB_Password.TabIndex = 0;
            this.LB_Password.Text = "Mot de passe :";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(227, 430);
            this.TB_Username.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(90, 20);
            this.TB_Username.TabIndex = 0;
            this.TB_Username.Text = "Cooperch";
            this.TB_Username.TextChanged += new System.EventHandler(this.TB_Username_TextChanged);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(227, 456);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(90, 20);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "ORACLE1";
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_Username_TextChanged);
            // 
            // FB_Connection
            // 
            this.FB_Connection.BackColor = System.Drawing.Color.Transparent;
            this.FB_Connection.BackgroundImage = global::TPFinal.Properties.Resources.Accepter;
            this.FB_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Connection.Enabled = false;
            this.FB_Connection.ImageClick = global::TPFinal.Properties.Resources.Accepter_Click;
            this.FB_Connection.ImageDisable = null;
            this.FB_Connection.ImageNeutral = global::TPFinal.Properties.Resources.Accepter;
            this.FB_Connection.ImageOver = global::TPFinal.Properties.Resources.Accepter_Over;
            this.FB_Connection.Location = new System.Drawing.Point(185, 506);
            this.FB_Connection.Name = "FB_Connection";
            this.FB_Connection.Size = new System.Drawing.Size(36, 36);
            this.FB_Connection.TabIndex = 3;
            this.FB_Connection.Click += new System.EventHandler(this.BTN_Connection_Click);
            this.FB_Connection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BTN_Connect_KeyDown);
            // 
            // FB_Quitter
            // 
            this.FB_Quitter.BackColor = System.Drawing.Color.Transparent;
            this.FB_Quitter.BackgroundImage = global::TPFinal.Properties.Resources.Quitter;
            this.FB_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Quitter.ImageClick = global::TPFinal.Properties.Resources.Quitter_Click;
            this.FB_Quitter.ImageDisable = null;
            this.FB_Quitter.ImageNeutral = global::TPFinal.Properties.Resources.Quitter;
            this.FB_Quitter.ImageOver = global::TPFinal.Properties.Resources.Quitter_Over;
            this.FB_Quitter.Location = new System.Drawing.Point(227, 506);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(36, 36);
            this.FB_Quitter.TabIndex = 4;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // Form_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BackgroundImage = global::TPFinal.Properties.Resources.Connection_Lumiere;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 574);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.FB_Connection);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Connection";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Connection_FormClosing);
            this.Load += new System.EventHandler(this.Form_Connection_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Connection_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private FlashButton.FlashButton FB_Connection;
        private FlashButton.FlashButton FB_Quitter;
    }
}

