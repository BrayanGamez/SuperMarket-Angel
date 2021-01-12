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
using market_angel.CRUD;

namespace market_angel
{
    public partial class frmProducts : Form
    {
        private DataBase DB;
        private SqlConnection cn;
        public frmProducts(DataBase DataBase)
        {
            InitializeComponent();
            setDB(DataBase);
        }

        private DataTable getInfoProducts(string Query="")
        {
            DataTable Products = new DataTable("Products_Table");
            SqlDataAdapter adapter;
            DataSet data = new DataSet();
            cn = DB.SqlConection;
            using (SqlCommand comand = new SqlCommand(Query,cn))
            {
                adapter = new SqlDataAdapter(comand);
                adapter.Fill(Products);
            }
            return Products;
        }

        public void setDB(DataBase DataB)
        {
            DB = DataB;
        }

        public DataBase getDB()
        {
            return DB;
        }

        private void searchProducts(string Product)
        {
            if (txtSearchProducts.text != String.Empty)
            {
                string strQuery = $@"select P.Nombre, P.Descripcion,P.Precio_Unitario,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria where P.Nombre LIKE '{Product}%'";
                DataTable Products = new DataTable("SearchProduct");
                SqlDataAdapter adapter;
                DataSet data = new DataSet();
                cn = DB.SqlConection;
                using (SqlCommand comand = new SqlCommand(strQuery, cn))
                {
                    adapter = new SqlDataAdapter(comand);
                    adapter.Fill(Products);
                }
                dgvProducts.DataSource = Products;
                Product = "";
            }
            else
            {
                dgvProducts.DataSource = getInfoProducts(@"select P.Nombre, P.Descripcion,P.Precio_Unitario,P.Precio_Compra,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria");
            }


        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = getInfoProducts(@"select P.Nombre, P.Descripcion,P.Precio_Unitario,P.Precio_Compra,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria");
        }


        private void txtSearchProducts_KeyPress(object sender, EventArgs e)
        {
            
        }

        private void txtSearchProducts_KeyUp(object sender, EventArgs e)
        {
            searchProducts(txtSearchProducts.text);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            ProductosCrud CrudProduct = new ProductosCrud(DB, getInfoProducts(@"select P.id_producto,P.Nombre, P.Descripcion,P.Precio_Unitario,P.Precio_Compra,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria"));
            CrudProduct.ShowDialog();
            dgvProducts.DataSource = getInfoProducts(@"select P.Nombre, P.Descripcion,P.Precio_Unitario,P.Precio_Compra,C.Nombre as Categoria from Producto As P
INNER JOIN Categorias as C 
on P.Categoria = C.id_categoria");
        }
    }
}
