namespace market_angel
{
    partial class frmRealizado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbExito = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buniAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(243)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbExito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 158);
            this.panel1.TabIndex = 0;
            // 
            // lbExito
            // 
            this.lbExito.AutoSize = true;
            this.lbExito.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExito.ForeColor = System.Drawing.Color.White;
            this.lbExito.Location = new System.Drawing.Point(108, 56);
            this.lbExito.Name = "lbExito";
            this.lbExito.Size = new System.Drawing.Size(167, 56);
            this.lbExito.TabIndex = 2;
            this.lbExito.Text = "EXITO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::market_angel.Properties.Resources.Check;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buniAceptar
            // 
            this.buniAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buniAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            this.buniAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniAceptar.BorderRadius = 6;
            this.buniAceptar.ButtonText = "Aceptar";
            this.buniAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.buniAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buniAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.buniAceptar.Iconimage = null;
            this.buniAceptar.Iconimage_right = null;
            this.buniAceptar.Iconimage_right_Selected = null;
            this.buniAceptar.Iconimage_Selected = null;
            this.buniAceptar.IconMarginLeft = 0;
            this.buniAceptar.IconMarginRight = 0;
            this.buniAceptar.IconRightVisible = true;
            this.buniAceptar.IconRightZoom = 0D;
            this.buniAceptar.IconVisible = true;
            this.buniAceptar.IconZoom = 90D;
            this.buniAceptar.IsTab = false;
            this.buniAceptar.Location = new System.Drawing.Point(95, 273);
            this.buniAceptar.Name = "buniAceptar";
            this.buniAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            this.buniAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(165)))));
            this.buniAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.buniAceptar.selected = false;
            this.buniAceptar.Size = new System.Drawing.Size(96, 42);
            this.buniAceptar.TabIndex = 4;
            this.buniAceptar.Text = "Aceptar";
            this.buniAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buniAceptar.Textcolor = System.Drawing.Color.White;
            this.buniAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buniAceptar.Click += new System.EventHandler(this.buniAceptar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(-6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "El Registro fue agregado con exito a la base de datos del sistema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMensaje
            // 
            this.lbMensaje.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(-3, 161);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(287, 43);
            this.lbMensaje.TabIndex = 5;
            this.lbMensaje.Text = "Mensaje";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRealizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.buniAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRealizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRealizado";
            this.Load += new System.EventHandler(this.frmRealizado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbExito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton buniAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMensaje;
    }
}