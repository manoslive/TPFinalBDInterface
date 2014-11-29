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
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Location = new System.Drawing.Point(50, 31);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(110, 20);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Nom d\'usagé :";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Location = new System.Drawing.Point(50, 71);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(113, 20);
            this.LB_Password.TabIndex = 0;
            this.LB_Password.Text = "Mot de passe :";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(182, 31);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(189, 26);
            this.TB_Username.TabIndex = 1;
            this.TB_Username.Text = "Cooperch";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(182, 71);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(189, 26);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "ORACLE1";
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(228, 113);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(143, 35);
            this.BTN_Connect.TabIndex = 2;
            this.BTN_Connect.Text = "Connection";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connection_Click);
            this.BTN_Connect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BTN_Connect_KeyDown);
            // 
            // Form_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 162);
            this.Controls.Add(this.BTN_Connect);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.Name = "Form_Connection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BTN_Connect;
    }
}

