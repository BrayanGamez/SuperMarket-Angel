namespace market_angel
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptxButton = new System.Windows.Forms.PictureBox();
            this.Radius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxButton)).BeginInit();
            this.SuspendLayout();
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.BackColor = System.Drawing.Color.Transparent;
            this.LbUser.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbUser.Location = new System.Drawing.Point(126, 83);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(112, 31);
            this.LbUser.TabIndex = 0;
            this.LbUser.Text = "Usuario";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbPassword.Location = new System.Drawing.Point(85, 138);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(153, 31);
            this.LbPassword.TabIndex = 1;
            this.LbPassword.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(256, 89);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(195, 29);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(256, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::market_angel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(132, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ptxButton
            // 
            this.ptxButton.Image = global::market_angel.Properties.Resources.log;
            this.ptxButton.Location = new System.Drawing.Point(230, 183);
            this.ptxButton.Name = "ptxButton";
            this.ptxButton.Size = new System.Drawing.Size(83, 70);
            this.ptxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxButton.TabIndex = 4;
            this.ptxButton.TabStop = false;
            this.toolTip1.SetToolTip(this.ptxButton, "Iniciar Sesion");
            this.ptxButton.Click += new System.EventHandler(this.ptxButton_Click);
            // 
            // Radius
            // 
            this.Radius.ElipseRadius = 8;
            this.Radius.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(525, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptxButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox ptxButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse Radius;
    }
}

