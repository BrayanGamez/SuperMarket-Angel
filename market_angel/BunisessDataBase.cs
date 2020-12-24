using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace market_angel
{
    class BunisessDataBase
    {
        private DataBase LDataBase;

        public BunisessDataBase(DataBase DBL)
        {
            setLDataBase(DBL);
        }

        public bool verificarBaseDatos()
        {
            bool bReturn = false;

            string strSQL = "select * from master.dbo.sysdatabases where name='Supermercado_Angel'";

            DataBase CDataBase = getLDataBase();
            SqlConnection CConnection = CDataBase.SqlConection;
            SqlCommand CCommand;
            SqlDataReader CDataReader;

            CCommand = new SqlCommand(strSQL, CConnection);
            CDataReader = CCommand.ExecuteReader();

            if (CDataReader.HasRows)
            {
                bReturn = true;
            }

            CCommand.Dispose();
            CDataReader.Close();

            return bReturn; // si retorna true existe la base de datos, caso contrario no
        }


        public void CreateDataBase()
        {
           
            try
            {
                if (!verificarBaseDatos())
                {
                    DataBase DB = LDataBase;

                    string strSQL = "Create Database Supermercado_Angel";
                    DB.ExecuteQuery(strSQL);
                    DB = new DataBase(DB.StrServerName, "Supermercado_Angel", DB.StrUserId,DB.StrPassword);

                    strSQL = "\n USE Supermercado_Angel" +

"\n" +
"\nCREATE TABLE Cliente(" +
"\n	id_cliente int IDENTITY(1,1) NOT NULL," +
"\n	Nombre varchar(50) NULL," +
"\n)" +

"\n CREATE TABLE Entradas(" +
"\n	id_entrada int NULL," +
"\n	Fecha date NOT NULL ," +
"\n	Usuario int NOT NULL," +
"\n	Cantidad int NULL," +
"\n	Articulo int NOT NULL," +
"\n	Descripcion nchar(10) NULL," +
"\n	Monto decimal(4, 2) NULL" +
"\n) " +

"\n CREATE TABLE Inventario(" +
"\n	id_inventario int NULL," +
"\n	Articulo int NOT NULL," +
"\n	Cantidad int NOT NULL," +
"\n	Descripcion varchar(50) NULL" +
"\n)" +

"\n CREATE TABLE Producto(" +
"\n 	id_producto int IDENTITY(1,1) NOT NULL," +
"\n	Nombre varchar(50) NULL," +
"\n	Categoria varchar(50) NULL," +
"\n	Descripcion varchar(50) NULL," +
"\n	Precio_Unitario decimal(4, 2) NULL" +
"\n	)" +

"\n CREATE TABLE Salidas(" +
"\n	id_salida int NULL," +
"\n	Usuario int NOT NULL," +
"\n	Cliente int NULL," +
"\n	Fecha date NOT NULL," +
"\n	Cantidad int NOT NULL," +
"\n	Articulo int NOT NULL," +
"\n	Descripcion varchar(50) NULL," +
"\n	Monto decimal(4, 2) NULL" +
"\n)"+

"\n CREATE TABLE Usuario(" +
"\n 	id_usuario int IDENTITY(1,1) NOT NULL," +
"\n	Nombre varchar(50) NULL," +
"\n	Foto image NULL," +
"\n	Contraseña varchar(100) NULL" +
"\n)";

                    DB.ExecuteQuery(strSQL);

                    strSQL = "\n Alter Table Usuario" +
     "\n ADD CONSTRAINT PK_Usuario" +
     "\n Primary key (id_usuario)" +


     "\n Alter Table Cliente" +
     "\n ADD CONSTRAINT PK_Cliente" +
     "\n Primary key (id_cliente)" +


     "\n Alter Table Producto" +
     "\n ADD CONSTRAINT PK_Producto" +
     "\n Primary key (id_producto)" +


     "\n Alter Table Entradas" +
     "\n ADD CONSTRAINT FK_Usuario" +
     "\n FOREIGN key (Usuario)" +
     "\n REFERENCES Usuario(id_usuario)" +


     "\n Alter Table Salidas" +
     "\n ADD CONSTRAINT FK_UsuarioOut" +
     "\n FOREIGN key (Usuario)" +
     "\n REFERENCES Usuario(id_usuario)" +


     "\n Alter Table Salidas" +
     "\n ADD CONSTRAINT FK_ClienteOut" +
     "\n FOREIGN key (Cliente)" +
     "\n REFERENCES Cliente(id_cliente)" +


     "\n Alter Table Salidas" +
     "\n ADD CONSTRAINT FK_ProductoOut" +
     "\n FOREIGN key (Articulo)" +
     "\n REFERENCES Producto(id_producto)" +


     "\n Alter Table Entradas" +
     "\n ADD CONSTRAINT FK_ProductoOut2" +
     "\n FOREIGN key (Articulo)" +
     "\n REFERENCES Producto(id_producto)" +


     "\n Alter Table Inventario" +
     "\n ADD CONSTRAINT FK_ProductoOut3" +
     "\n FOREIGN key (Articulo)" +
     "\n REFERENCES Producto(id_producto)";
DB.ExecuteQuery(strSQL);

                    strSQL = "\n Alter Table Entradas" +
       "\n ADD CONSTRAINT DF_Date" +
       "\n Default getdate() for Fecha" +
       "\n" +

       "\n Alter Table Salidas" +
       "\n ADD CONSTRAINT DF_Date2" +
       "\n Default getdate() for Fecha" +
       "\n ";
                    DB.ExecuteQuery(strSQL);

                    strSQL = "\n Create Procedure add_products" +
   "\n @id int," +
   "\n @name varchar(50)," +
   "\n @categoria Varchar(50)," +
   "\n @descripcion varchar(50)," +
   "\n @price decimal(4,2)" +
   "\n As" +
   "\n if (Select COUNT(*) From Producto where Nombre=@name)=0" +
   "\n Begin" +
   "\n insert into Producto values (@name,@categoria,@descripcion,@price)" +
   "\n Declare @cod_product int" +
   "\n Select @cod_product = id_producto from Producto where Nombre=@name--Sacamos el codigo del producto en inventario y lo agregamos a inventario" +
   "\n insert into Inventario values (@id,@cod_product,0,@descripcion)" +
   "\n End" +
   "\n ELSE" +
   "\n Begin" +
   "\n PRINT 'Ya existe un producto con ese nombre'" +
   "\n End";
                    DB.ExecuteQuery(strSQL);

                    strSQL = "\n Create Procedure add_sale" +
          "\n @id int," +
          "\n @user int," +
          "\n @client int," +
          "\n @quantity int," +
          "\n @Article int," +
          "\n @comment varchar(50)," +
          "\n @total_sale decimal(4,2)" +
          "\n As" +
          "\n Declare @cant INT" +
          "\n select @cant = Cantidad from Inventario where Articulo = @Article" +
          "\n if (@cant>@quantity)" +
          "\n Begin" +
          "\n insert into Salidas Values (@id,@user,@client,default,@quantity,@Article,@comment,@total_sale)" +
          "\n END" +
          "\n ELSE" +
          "\n Begin" +
          "\n PRINT 'Cantidad pedida rebasa a la de stock'" +
          "\n END";         DB.ExecuteQuery(strSQL);

                    strSQL = "\n Create Procedure add_buy" +
     "\n @id int," +
     "\n @user int," +
     "\n @quantity int," +
     "\n @Article int," +
     "\n @comment varchar(50)," +
     "\n @total_sale decimal(4,2)" +
     "\n As" +
     "\n Declare @cant INT" +
     "\n select @cant = Cantidad from Inventario where Articulo = @Article" +
     "\n if (Select COUNT(*) from Producto where id_producto=@Article)>0" +
     "\n Begin" +
     "\n insert into Entradas Values (@id,default,@user,@quantity,@Article,@comment,@total_sale)" +
     "\n update Inventario SET Cantidad = @cant + @quantity where Articulo=@Article" +
     "\n End" +
     "\n else" +
     "\n Begin" +
     "\n PRINT 'Cantidad pedida rebasa a la de stock'" +
     "\n End";      DB.ExecuteQuery(strSQL);

                    strSQL = "\n Create Procedure add_client" +
     "\n @name varchar(50)" +
     "\n AS" +
     "\n if(select COUNT(*) from Usuario where Nombre=@name)=0" +
     "\n Begin" +
     "\n insert into Cliente values (@name)" +
     "\n End" +
     "\n ELSE" +
     "\n Begin" +
     "\n Print 'Ya hay un usuario con ese nombre'" +
     "\n End";
                    DB.ExecuteQuery(strSQL);
                    //Cargamos un usuario por defecto
                    strSQL = "insert into Usuario values ('Admin',NULL,'123456')";
                    DB.ExecuteQuery(strSQL);
                }
            }
            catch (SqlException ex)//Manejamos las exepciones SQL(Lado del Servidor)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Mensaje: " + ex.Errors[i].Message + "\n" +
                        "Numero de Linea: " + ex.Errors[i].LineNumber + "\n" +
                        "Fuente: " + ex.Errors[i].Source + "\n" +
                        "Procedimiento: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "Error del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"Error del Cliente",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private DataBase getLDataBase()
        {
            return LDataBase;
        }

        private void setLDataBase(DataBase DB)
        {
            LDataBase = DB;
        }

    }

}

