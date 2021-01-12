namespace market_angel.CRUD
{
    partial class CategoriasCrud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dgvCategorys = new System.Windows.Forms.DataGridView();
            this.setError = new System.Windows.Forms.ErrorProvider(this.components);
            this.PCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setError)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.IconRightVisible = true;
            this.BtnUpdate.IconVisible = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.Text = "CRUD Categorias";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.lbDescription.Location = new System.Drawing.Point(530, 135);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(102, 21);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(509, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 95);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // dgvCategorys
            // 
            this.dgvCategorys.AllowUserToAddRows = false;
            this.dgvCategorys.AllowUserToDeleteRows = false;
            this.dgvCategorys.AllowUserToResizeRows = false;
            this.dgvCategorys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorys.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorys.GridColor = System.Drawing.Color.LightGray;
            this.dgvCategorys.Location = new System.Drawing.Point(34, 73);
            this.dgvCategorys.Name = "dgvCategorys";
            this.dgvCategorys.ReadOnly = true;
            this.dgvCategorys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorys.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorys.RowHeadersVisible = false;
            this.dgvCategorys.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategorys.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorys.Size = new System.Drawing.Size(415, 252);
            this.dgvCategorys.TabIndex = 16;
            this.dgvCategorys.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorys_CellDoubleClick);
            // 
            // setError
            // 
            this.setError.ContainerControl = this;
            // 
            // CategoriasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.dgvCategorys);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Name = "CategoriasCrud";
            this.Text = "CategoriasCrud";
            this.Load += new System.EventHandler(this.CategoriasCrud_Load);
            this.Controls.SetChildIndex(this.PCrud, 0);
            this.Controls.SetChildIndex(this.BtnUpdate, 0);
            this.Controls.SetChildIndex(this.BtnDelete, 0);
            this.Controls.SetChildIndex(this.lBName, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.lbDescription, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.dgvCategorys, 0);
            this.PCrud.ResumeLayout(false);
            this.PCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.DataGridView dgvCategorys;
        private System.Windows.Forms.ErrorProvider setError;
    }
}