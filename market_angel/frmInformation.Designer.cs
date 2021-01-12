namespace market_angel
{
    partial class frmInformation
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buniAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buniCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 158);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVISO";
            // 
            // lbMensaje
            // 
            this.lbMensaje.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(0, 167);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(287, 43);
            this.lbMensaje.TabIndex = 1;
            this.lbMensaje.Text = "Mensaje";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(-3, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Esta Usted seguro de hacer los cambios correspondientes?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buniAceptar.Location = new System.Drawing.Point(21, 273);
            this.buniAceptar.Name = "buniAceptar";
            this.buniAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            this.buniAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(165)))));
            this.buniAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.buniAceptar.selected = false;
            this.buniAceptar.Size = new System.Drawing.Size(96, 42);
            this.buniAceptar.TabIndex = 3;
            this.buniAceptar.Text = "Aceptar";
            this.buniAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buniAceptar.Textcolor = System.Drawing.Color.White;
            this.buniAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buniAceptar.Click += new System.EventHandler(this.buniAceptar_Click);
            // 
            // buniCancelar
            // 
            this.buniCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buniCancelar.BackColor = System.Drawing.Color.Red;
            this.buniCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniCancelar.BorderRadius = 6;
            this.buniCancelar.ButtonText = "Cancelar";
            this.buniCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.buniCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buniCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.buniCancelar.Iconimage = null;
            this.buniCancelar.Iconimage_right = null;
            this.buniCancelar.Iconimage_right_Selected = null;
            this.buniCancelar.Iconimage_Selected = null;
            this.buniCancelar.IconMarginLeft = 0;
            this.buniCancelar.IconMarginRight = 0;
            this.buniCancelar.IconRightVisible = true;
            this.buniCancelar.IconRightZoom = 0D;
            this.buniCancelar.IconVisible = true;
            this.buniCancelar.IconZoom = 90D;
            this.buniCancelar.IsTab = false;
            this.buniCancelar.Location = new System.Drawing.Point(159, 273);
            this.buniCancelar.Name = "buniCancelar";
            this.buniCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            this.buniCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(128)))), ((int)(((byte)(165)))));
            this.buniCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.buniCancelar.selected = false;
            this.buniCancelar.Size = new System.Drawing.Size(96, 42);
            this.buniCancelar.TabIndex = 4;
            this.buniCancelar.Text = "Cancelar";
            this.buniCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buniCancelar.Textcolor = System.Drawing.Color.White;
            this.buniCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buniCancelar.Click += new System.EventHandler(this.buniCancelar_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.panel1;
            this.dragControl.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::market_angel.Properties.Resources.Informarcion;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 327);
            this.Controls.Add(this.buniCancelar);
            this.Controls.Add(this.buniAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton buniAceptar;
        private Bunifu.Framework.UI.BunifuFlatButton buniCancelar;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
    }
}