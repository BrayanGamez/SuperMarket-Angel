namespace market_angel.CRUD
{
    partial class CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            this.PCrud = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BRadius1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BRadius2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lBName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DropForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PCrud
            // 
            this.PCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.PCrud.Controls.Add(this.pictureBox1);
            this.PCrud.Controls.Add(this.label1);
            this.PCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.PCrud.Location = new System.Drawing.Point(0, 0);
            this.PCrud.Name = "PCrud";
            this.PCrud.Size = new System.Drawing.Size(720, 50);
            this.PCrud.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD";
            // 
            // BRadius1
            // 
            this.BRadius1.ElipseRadius = 15;
            this.BRadius1.TargetControl = this.BtnUpdate;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.BorderRadius = 0;
            this.BtnUpdate.ButtonText = "Actualizar";
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUpdate.Iconimage = global::market_angel.Properties.Resources.captcha;
            this.BtnUpdate.Iconimage_right = null;
            this.BtnUpdate.Iconimage_right_Selected = null;
            this.BtnUpdate.Iconimage_Selected = null;
            this.BtnUpdate.IconMarginLeft = 0;
            this.BtnUpdate.IconMarginRight = 0;
            this.BtnUpdate.IconRightVisible = true;
            this.BtnUpdate.IconRightZoom = 0D;
            this.BtnUpdate.IconVisible = true;
            this.BtnUpdate.IconZoom = 50D;
            this.BtnUpdate.IsTab = false;
            this.BtnUpdate.Location = new System.Drawing.Point(60, 366);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUpdate.OnHovercolor = System.Drawing.Color.Black;
            this.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUpdate.selected = false;
            this.BtnUpdate.Size = new System.Drawing.Size(117, 33);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUpdate.Textcolor = System.Drawing.Color.White;
            this.BtnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BRadius2
            // 
            this.BRadius2.ElipseRadius = 15;
            this.BRadius2.TargetControl = this.BtnDelete;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.BorderRadius = 0;
            this.BtnDelete.ButtonText = "Eliminar";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledColor = System.Drawing.Color.Green;
            this.BtnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.Iconimage = global::market_angel.Properties.Resources.basura;
            this.BtnDelete.Iconimage_right = null;
            this.BtnDelete.Iconimage_right_Selected = null;
            this.BtnDelete.Iconimage_Selected = null;
            this.BtnDelete.IconMarginLeft = 0;
            this.BtnDelete.IconMarginRight = 0;
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconRightZoom = 0D;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.IconZoom = 50D;
            this.BtnDelete.IsTab = false;
            this.BtnDelete.Location = new System.Drawing.Point(230, 366);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BtnDelete.OnHovercolor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDelete.selected = false;
            this.BtnDelete.Size = new System.Drawing.Size(107, 33);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDelete.Textcolor = System.Drawing.Color.White;
            this.BtnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lBName
            // 
            this.lBName.AutoSize = true;
            this.lBName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.lBName.Location = new System.Drawing.Point(541, 73);
            this.lBName.Name = "lBName";
            this.lBName.Size = new System.Drawing.Size(70, 21);
            this.lBName.TabIndex = 5;
            this.lBName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(509, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DropForm
            // 
            this.DropForm.Fixed = true;
            this.DropForm.Horizontal = true;
            this.DropForm.TargetControl = this.PCrud;
            this.DropForm.Vertical = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Agregar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(545, 366);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(109, 33);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Agregar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lBName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.PCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.PCrud.ResumeLayout(false);
            this.PCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse BRadius1;
        private Bunifu.Framework.UI.BunifuElipse BRadius2;
        private Bunifu.Framework.UI.BunifuDragControl DropForm;
        protected System.Windows.Forms.Panel PCrud;
        protected Bunifu.Framework.UI.BunifuFlatButton BtnUpdate;
        protected Bunifu.Framework.UI.BunifuFlatButton BtnDelete;
        protected System.Windows.Forms.TextBox txtName;
        protected Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lBName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}