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
    public partial class CategoriasCrud : CRUD
    {
        private DataBase DB;
        private SqlConnection cn;

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

        public CategoriasCrud(DataBase DB)
        {
            InitializeComponent();
            this.DB = DB;
        }

        private DataTable getInfoCategory()
        {
            try
            {
                DataTable Categorys = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string strQuery = "Select *  from Categorias";
                cn = DB.SqlConection;
                using (SqlCommand comando = new SqlCommand(strQuery, cn))
                {
                    adapter = new SqlDataAdapter(comando);
                    adapter.Fill(Categorys);
                }
                return Categorys;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CategoriasCrud_Load(object sender, EventArgs e)
        {
            dgvCategorys.DataSource = getInfoCategory();
            dgvCategorys.Columns["id_categoria"].Visible = false;
        }

        private void dgvCategorys_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCategorys.Rows[dgvCategorys.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategorys.Rows[dgvCategorys.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                setError.SetError(txtName,"Campo Vacio");
                txtName.Focus();
            }
            else
            {
                setError.Clear();
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            if (txtDescription.Text == string.Empty)
            {
                setError.SetError(txtDescription, "Campo Vacio");
                txtDescription.Focus();
            }
            else
            {
                setError.Clear();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text != string.Empty && txtName.Text != string.Empty)
                {
                    string strQuery = $"insert into Categorias Values ('{txtName.Text}','{txtDescription.Text}')";
                    DB.ExecuteQuery(strQuery);
                    frmRealizado frmChecked = new frmRealizado("Categoria Agregada");
                    DialogResult Result = new DialogResult();
                    Result = frmChecked.ShowDialog();
                    if (Result == DialogResult.OK)
                    {
                        frmChecked.Close();
                        dgvCategorys.DataSource = getInfoCategory();
                        dgvCategorys.Columns["id_categoria"].Visible = false;
                        txtDescription.Text = "";
                        txtName.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los campos Vacios","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text != string.Empty && txtName.Text != string.Empty)
                {
                    string strQuery = $"Delete from Categorias where Nombre ='{txtName.Text}' and Descripcion = '{txtDescription.Text}'";
                    DialogResult result = new DialogResult();
                    frmInformation frmDelete = new frmInformation("¿Eliminar Categoria?");
                    result = frmDelete.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        frmDelete.Close();
                        DB.ExecuteQuery(strQuery);
                        frmRealizado frmChecked = new frmRealizado("Categoria Eliminada");
                        result = frmChecked.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            frmChecked.Close();
                            dgvCategorys.DataSource = getInfoCategory();
                            dgvCategorys.Columns.Remove("id_categoria");
                            txtDescription.Text = "";
                            txtName.Text = "";
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Rellene los campos","Campos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text != string.Empty && txtName.Text != string.Empty)
                {
                    string strQuery = $"update Categorias set Nombre='{txtName.Text}',Descripcion = '{txtDescription.Text}' where id_categoria ={dgvCategorys.Rows[dgvCategorys.CurrentRow.Index].Cells[0].Value.ToString()} ";
                    frmInformation frmUpdateResult = new frmInformation("¿Actualizar categoria?");
                    DialogResult result = new DialogResult();
                    result = frmUpdateResult.ShowDialog();
                    if (result== DialogResult.OK)
                    {
                        DB.ExecuteQuery(strQuery);
                        frmRealizado frmCheced = new frmRealizado("Registro actualizado con exito");
                        result = frmCheced.ShowDialog();
                        if (result==DialogResult.OK)
                        {
                            frmCheced.Close();
                            dgvCategorys.DataSource = getInfoCategory();
                            dgvCategorys.Columns["id_categoria"].Visible = false;
                            txtDescription.Text = "";
                            txtName.Text = "";
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Rellene los Campos","Campos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
