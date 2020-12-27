namespace market_angel
{
    partial class ptxUserPhoto
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
            this.txtUserName = new System.Windows.Forms.Label();
            this.ptxUserPhotoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxUserPhotoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(33, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(35, 13);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "label1";
            // 
            // ptxUserPhotoImg
            // 
            this.ptxUserPhotoImg.Location = new System.Drawing.Point(12, 58);
            this.ptxUserPhotoImg.Name = "ptxUserPhotoImg";
            this.ptxUserPhotoImg.Size = new System.Drawing.Size(128, 122);
            this.ptxUserPhotoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxUserPhotoImg.TabIndex = 1;
            this.ptxUserPhotoImg.TabStop = false;
            // 
            // ptxUserPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 319);
            this.Controls.Add(this.ptxUserPhotoImg);
            this.Controls.Add(this.txtUserName);
            this.Name = "ptxUserPhoto";
            this.Text = "Wrapper";
            this.Load += new System.EventHandler(this.ptxUserPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptxUserPhotoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.PictureBox ptxUserPhotoImg;
    }
}