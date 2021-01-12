namespace market_angel.CRUD
{
    partial class ProductosCrud
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.Label();
            this.Tagger = new System.Windows.Forms.ToolTip(this.components);
            this.btnCRDCategoria = new System.Windows.Forms.PictureBox();
            this.ErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.CmCategory = new System.Windows.Forms.ComboBox();
            this.PCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCRDCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // PCrud
            // 
            this.PCrud.Controls.Add(this.btnCRDCategoria);
            this.PCrud.Paint += new System.Windows.Forms.PaintEventHandler(this.PCrud_Paint);
            this.PCrud.Controls.SetChildIndex(this.label1, 0);
            this.PCrud.Controls.SetChildIndex(this.btnCRDCategoria, 0);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.IconRightVisible = true;
            this.BtnUpdate.IconVisible = true;
            this.BtnUpdate.Size = new System.Drawing.Size(122, 33);
            this.Tagger.SetToolTip(this.BtnUpdate, "Actualizar Producto");
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.Size = new System.Drawing.Size(113, 33);
            this.Tagger.SetToolTip(this.BtnDelete, "Eliminar Producto");
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(508, 86);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(520, 366);
            this.bunifuFlatButton1.Size = new System.Drawing.Size(121, 33);
            this.Tagger.SetToolTip(this.bunifuFlatButton1, "Agregar Producto");
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.Text = "CRUD Productos";
            // 
            // lBName
            // 
            this.lBName.Location = new System.Drawing.Point(512, 53);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(509, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio_Unitario";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(508, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(509, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio_Compra";
            // 
            // txtPriceSale
            // 
            this.txtPriceSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceSale.Location = new System.Drawing.Point(508, 206);
            this.txtPriceSale.Name = "txtPriceSale";
            this.txtPriceSale.Size = new System.Drawing.Size(133, 20);
            this.txtPriceSale.TabIndex = 11;
            this.txtPriceSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceSale_KeyPress);
            this.txtPriceSale.Validated += new System.EventHandler(this.txtPriceSale_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(512, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(508, 273);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 20);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(445, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 364);
            this.panel1.TabIndex = 14;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor = System.Drawing.Color.LightGray;
            this.dgvProducts.Location = new System.Drawing.Point(12, 86);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(415, 252);
            this.dgvProducts.TabIndex = 15;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.Categoria.Location = new System.Drawing.Point(466, 314);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(82, 21);
            this.Categoria.TabIndex = 16;
            this.Categoria.Text = "Categoria";
            // 
            // btnCRDCategoria
            // 
            this.btnCRDCategoria.Image = global::market_angel.Properties.Resources.categorias;
            this.btnCRDCategoria.Location = new System.Drawing.Point(621, 11);
            this.btnCRDCategoria.Name = "btnCRDCategoria";
            this.btnCRDCategoria.Size = new System.Drawing.Size(28, 29);
            this.btnCRDCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCRDCategoria.TabIndex = 18;
            this.btnCRDCategoria.TabStop = false;
            this.Tagger.SetToolTip(this.btnCRDCategoria, "Crud Categorias");
            this.btnCRDCategoria.Click += new System.EventHandler(this.btnCRDCategoria_Click);
            // 
            // ErrorHandler
            // 
            this.ErrorHandler.ContainerControl = this;
            // 
            // CmCategory
            // 
            this.CmCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmCategory.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmCategory.FormattingEnabled = true;
            this.CmCategory.Location = new System.Drawing.Point(566, 314);
            this.CmCategory.Name = "CmCategory";
            this.CmCategory.Size = new System.Drawing.Size(121, 24);
            this.CmCategory.TabIndex = 17;
            // 
            // ProductosCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.CmCategory);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPriceSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "ProductosCrud";
            this.Text = "ProductosCrud";
            this.Load += new System.EventHandler(this.ProductosCrud_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPriceSale, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvProducts, 0);
            this.Controls.SetChildIndex(this.Categoria, 0);
            this.Controls.SetChildIndex(this.CmCategory, 0);
            this.Controls.SetChildIndex(this.PCrud, 0);
            this.Controls.SetChildIndex(this.BtnUpdate, 0);
            this.Controls.SetChildIndex(this.BtnDelete, 0);
            this.Controls.SetChildIndex(this.lBName, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.PCrud.ResumeLayout(false);
            this.PCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCRDCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ToolTip Tagger;
        private System.Windows.Forms.ErrorProvider ErrorHandler;
        private System.Windows.Forms.ComboBox CmCategory;
        private System.Windows.Forms.PictureBox btnCRDCategoria;
    }
}