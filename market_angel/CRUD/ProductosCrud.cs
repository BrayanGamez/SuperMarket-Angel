using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace market_angel.CRUD
{
    public partial class ProductosCrud : CRUD
    {
        DataBase DB;
        DataTable Products;
        SqlConnection cn;
        public ProductosCrud(DataBase DB,DataTable Products)
        {
            InitializeComponent();
            this.DB = DB;
            this.Products = Products;
        }

        public DataBase DB1
        {
            get
            {
                return DB;
            }

            set
            {
                DB = value;
            }
        }

        public SqlConnection Cn
        {
            get
            {
                return cn;
            }

            set
            {
                cn = value;
            }
        }

        private void LoadDataCombobox()
        {
            DataTable Data = new DataTable("Categorias");
            SqlDataAdapter adapter = new SqlDataAdapter();
            string strSQL = "Select * from Categorias";
            cn = DB.SqlConection;
            using (SqlCommand comand = new SqlCommand(strSQL,cn))
            {
                adapter = new SqlDataAdapter(comand);
                adapter.Fill(Data);
            }
            CmCategory.DisplayMember = "Nombre";
            CmCategory.ValueMember = "id_categoria";
            CmCategory.DataSource = Data;
        }

        //Metodos del CRUD
        private void AddProduct()
        {
            if (txtName.Text!=string.Empty && textBox1.Text !=string.Empty && txtPriceSale.Text != string.Empty && txtDescription.Text != string.Empty)
            {
                string strSQL = $"insert into Producto Values ('{txtName.Text}','{txtDescription.Text}',{textBox1.Text},{CmCategory.SelectedValue.ToString()},{txtPriceSale.Text})";
                DB.ExecuteQuery(strSQL);
                frmRealizado MensajeExitoso = new frmRealizado("Producto Agregado");
                DialogResult Result = new DialogResult();
                Result = MensajeExitoso.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    MensajeExitoso.Close();
                    txtDescription.Text = "";
                    txtName.Text = "";
                    txtPriceSale.Text = "";
                    textBox1.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Rellene los Campos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void UpdateProduct()
        {
            if (txtName.Text != string.Empty && textBox1.Text != string.Empty && txtPriceSale.Text != string.Empty && txtDescription.Text != string.Empty)
            {
                string strQuery = $@"update Producto set Nombre='{txtName.Text}',Descripcion='{txtDescription.Text}',Precio_Unitario={textBox1.Text.Replace(",",".")},Precio_Compra={txtPriceSale.Text.Replace(",", ".")},
                                Categoria={CmCategory.SelectedValue.ToString()} where id_producto={dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[0].Value.ToString()}";
                frmInformation frmUpdate = new frmInformation("Actualzar Producto");
                DialogResult result = new DialogResult();
                result = frmUpdate.ShowDialog();
                if (result==DialogResult.OK)
                {
                    DB.ExecuteQuery(strQuery);
                    frmRealizado frmCheked = new frmRealizado("Producto Actualizado");
                    result = frmCheked.ShowDialog();
                    if (result==DialogResult.OK)
                    {
                        txtDescription.Text = "";
                        txtName.Text = "";
                        txtPriceSale.Text = "";
                        textBox1.Text = "";
                        UpdateTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DeleteProduct()
        {
            try
            {
                if (txtName.Text != string.Empty && textBox1.Text != string.Empty && txtPriceSale.Text != string.Empty && txtDescription.Text != string.Empty)
                {
                    string strQuery = $"Delete from Producto where id_producto={dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[0].Value.ToString()}";
                    frmInformation frmDelete = new frmInformation("¿Eliminar Producto?");
                    DialogResult result = new DialogResult();
                    result = frmDelete.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        DB.ExecuteQuery(strQuery);
                        UpdateTable();
                        frmRealizado frmchecked = new frmRealizado("Producto Eliminado");
                        result = frmchecked.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            txtDescription.Text = "";
                            txtName.Text = "";
                            txtPriceSale.Text = "";
                            textBox1.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateTable()
        {
            dgvProducts.DataSource = getInfoProducts(@"select P.id_producto,P.Nombre, P.Descripcion,P.Precio_Unitario,P.Precio_Compra,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria");
            dgvProducts.Columns["id_producto"].Visible = false;
        }

        private DataTable getInfoProducts(string Query = "")
        {
            DataTable Products = new DataTable("Products_Table");
            SqlDataAdapter adapter;
            DataSet data = new DataSet();
            cn = DB.SqlConection;
            using (SqlCommand comand = new SqlCommand(Query, cn))
            {
                adapter = new SqlDataAdapter(comand);
                adapter.Fill(Products);
            }
            return Products;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ProductosCrud_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Products;
            dgvProducts.Columns["id_producto"].Visible = false;
            LoadDataCombobox();
        }

        private void PCrud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                ErrorHandler.SetError(txtName,"Campo Vacio");
                txtName.Focus();
            }
            else
            {
                ErrorHandler.Clear();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                ErrorHandler.SetError(txtName, "Campo Vacio");
                txtName.Focus();
            }
            else
            {
                ErrorHandler.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar=='.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPriceSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPriceSale_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                ErrorHandler.SetError(txtName, "Campo Vacio");
                txtName.Focus();
            }
            else
            {
                ErrorHandler.Clear();
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                ErrorHandler.SetError(txtName, "Campo Vacio");
                txtName.Focus();
            }
            else
            {
                ErrorHandler.Clear();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddProduct();
            UpdateTable();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[1].Value.ToString();
            textBox1.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[3].Value.ToString();
            txtPriceSale.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[4].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[2].Value.ToString();
            CmCategory.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void btnCRDCategoria_Click(object sender, EventArgs e)
        {
            CategoriasCrud frmCategory = new CategoriasCrud(DB);
            frmCategory.ShowDialog();
            LoadDataCombobox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
    }
}
