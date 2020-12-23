using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

            string strSQL = "select * from master.dbo.sysdatabases where name="+LDataBase.StrServerName+"";

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
            if (!verificarBaseDatos())
            {
                DataBase DB = LDataBase;

                string strSQL = "Create DataBase Supermercado_Angel";
                DB.ExecuteQuery(strSQL);
                DB = new DataBase(DB.StrServerName, DB.StrInitialCatalog, DB.StrPassword, DB.StrUserId);

                strSQL = "USE [master]" +
"\nGO" +
/****** Object:  Database [Supermercado_Angel]    Script Date: 21/12/2020 20:03:21 ******/
"\nCREATE DATABASE[Supermercado_Angel]"+
 "\nCONTAINMENT = NONE"+
 "\nON PRIMARY"+
"\n(NAME = N'Supermercado_Angel', FILENAME = N'C:/Program Files/Microsoft SQL Server/MSSQL12.MSSQLSERVER/MSSQL/DATA/Supermercado_Angel.mdf', SIZE = 5120KB, MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )"+
"\n LOG ON"+
"\n(NAME = N'Supermercado_Angel_log', FILENAME = N'C:/Program Files/Microsoft SQL Server/MSSQL12.MSSQLSERVER/MSSQL/DATA/Supermercado_Angel_log.ldf', SIZE = 1024KB, MAXSIZE = 2048GB, FILEGROWTH = 10 %)"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET COMPATIBILITY_LEVEL = 120"+
"\nGO"+
"\nIF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))"+
"\nbegin"+
"\nEXEC[Supermercado_Angel].[dbo].[sp_fulltext_database] @action = 'enable'"+
"\nend"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ANSI_NULL_DEFAULT OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ANSI_NULLS OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ANSI_PADDING OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ANSI_WARNINGS OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ARITHABORT OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET AUTO_CLOSE OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET AUTO_SHRINK OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET AUTO_UPDATE_STATISTICS ON"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET CURSOR_CLOSE_ON_COMMIT OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET CURSOR_DEFAULT  GLOBAL"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET CONCAT_NULL_YIELDS_NULL OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET NUMERIC_ROUNDABORT OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET QUOTED_IDENTIFIER OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET RECURSIVE_TRIGGERS OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET  DISABLE_BROKER"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET DATE_CORRELATION_OPTIMIZATION OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET TRUSTWORTHY OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET ALLOW_SNAPSHOT_ISOLATION OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET PARAMETERIZATION SIMPLE"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET READ_COMMITTED_SNAPSHOT OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET HONOR_BROKER_PRIORITY OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET RECOVERY SIMPLE"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET  MULTI_USER"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET PAGE_VERIFY CHECKSUM"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET DB_CHAINING OFF"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET TARGET_RECOVERY_TIME = 0 SECONDS"+
"\nGO"+
"\nALTER DATABASE[Supermercado_Angel] SET DELAYED_DURABILITY = DISABLED" +
"\nGO" +
"\nUSE[Supermercado_Angel]" +
"\nGO";

                DB.ExecuteQuery(strSQL);
/****** Object:  Table [dbo].[Cliente]    Script Date: 21/12/2020 20:03:21 ******/

 strSQL= "\nSET ANSI_NULLS ON" +
"\nGO" +
"\nSET QUOTED_IDENTIFIER ON" +
"\nGO" +
"\nSET ANSI_PADDING ON" +
"\nGO" +
"\nCREATE TABLE[dbo].[Cliente](" +

    "\n[id_cliente][int] IDENTITY(1, 1) NOT NULL," +

    "\n[Nombre][varchar](50) NULL," +
 "\nCONSTRAINT[PK_Cliente] PRIMARY KEY CLUSTERED" +
"\n(" +

   "\n [id_cliente] ASC" +
"\n)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]" +
"\n) ON[PRIMARY]"+
"\nGO"+
"\nSET ANSI_PADDING OFF"+
"\nGO";
                DB.ExecuteQuery(strSQL);
/****** Object:  Table [dbo].[Entradas]    Script Date: 21/12/2020 20:03:22 ******/
strSQL= "\nSET ANSI_NULLS ON"+
"\nGO"+
"\nSET QUOTED_IDENTIFIER ON"+
"\nGO"+
"\nCREATE TABLE[dbo].[Entradas]("+

    "\n[id_entrada][int] NULL,"+
    "\n[Fecha]"+
        "\n[date]"+
        "\nNOT NULL CONSTRAINT[DF_Date] DEFAULT(getdate()),"+
    "\n[Usuario]"+
        "\n[int] NOT NULL,"+

"\n[Cantidad] [int] NULL,"+
    "\n[Articulo]"+
        "\n[int] NOT NULL,"+

"\n[Descripcion] [nchar](10) NULL,"+

    "\n[Monto]"+
        "\n[decimal](4, 2) NULL"+
"\n) ON[PRIMARY]"+

"\nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  Table [dbo].[Inventario]    Script Date: 21/12/2020 20:03:22 ******/
              strSQL=  "\nSET ANSI_NULLS ON"+
"\nGO"+
"\nSET QUOTED_IDENTIFIER ON"+
"\nGO"+
"\nSET ANSI_PADDING ON"+
"\nGO"+
"\nCREATE TABLE[dbo].[Inventario]("+
    "\n[id_inventario]"+
        "\n[int] NULL,"+
    "\n[Articulo]"+
        "\n[int] NOT NULL,"+

"\n[Cantidad] [int] NOT NULL,"+

"\n[Descripcion] [varchar](50) NULL"+
"\n) ON[PRIMARY]"+

"\nGO"+
"\nSET ANSI_PADDING OFF"+
"\nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  Table [dbo].[Producto]    Script Date: 21/12/2020 20:03:22 ******/
                strSQL= "\nSET ANSI_NULLS ON"+
"\nGO"+
"\nSET QUOTED_IDENTIFIER ON"+
"\nGO"+
"\nSET ANSI_PADDING ON"+
"\nGO"+
"\nCREATE TABLE[dbo].[Producto]("+
    "\n[id_producto]"+
        "\n[int] IDENTITY(1,1) NOT NULL,"+

"\n[Nombre] [varchar](50) NULL,"+
    "\n[Categoria]"+
        "\n[varchar](50) NULL,"+
    "\n[Descripcion]"+
        "\n[varchar](50) NULL,"+
    "\n[Precio_Unitario]"+
        "\n[decimal](4, 2) NULL,"+
 "\nCONSTRAINT[PK_Producto] PRIMARY KEY CLUSTERED"+
"\n("+
   "\n[id_producto] ASC"+
"\n)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]"+
"\n) ON[PRIMARY]"+

"\nGO"+
"\nSET ANSI_PADDING OFF"+
"\nGO";
                DB.ExecuteQuery(strSQL);
/****** Object:  Table [dbo].[Salidas]    Script Date: 21/12/2020 20:03:22 ******/
strSQL = "\nSET ANSI_NULLS ON"+
"\nGO"+
"\nSET QUOTED_IDENTIFIER ON"+
"\nGO"+
"\nSET ANSI_PADDING ON"+
"\nGO"+
"\nCREATE TABLE[dbo].[Salidas]("+
    "\n[id_salida]"+
        "\n[int] NULL,"+
    "\n[Usuario]"+
        "\n[int] NOT NULL,"+

"\n[Cliente] [int] NULL,"+
    "\n[Fecha]"+
        "\n[date]"+
        "\nNOT NULL,"+

    "\n[Cantidad] [int] NOT NULL,"+

    "\n[Articulo] [int] NOT NULL,"+

    "\n[Descripcion] [varchar](50) NULL,"+
    "\n[Monto]"+
        "\n[decimal](4, 2) NULL"+
"\n) ON[PRIMARY]"+

"\nGO"+
"\nSET ANSI_PADDING OFF"+
"\nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  Table [dbo].[Usuario]    Script Date: 21/12/2020 20:03:22 ******/
             strSQL=   "\nSET ANSI_NULLS ON"+
"\nGO"+
"\nSET QUOTED_IDENTIFIER ON"+
"\nGO"+
"\nSET ANSI_PADDING ON"+
"\nGO"+
"\nCREATE TABLE[dbo].[Usuario]("+
    "\n[id_usuario]"+
        "\n[int] IDENTITY(1,1) NOT NULL,"+

"\n[Nombre] [varchar](50) NULL,"+
    "\n[Foto]"+
        "\n[image]"+
        "\nNULL,"+
    "\n[Contraseña]"+
        "\n[varchar](100) NULL,"+
 "\nCONSTRAINT[PK_Usuario] PRIMARY KEY CLUSTERED"+
"\n("+
   "\n[id_usuario] ASC"+
"\n)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]"+
"\n) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]"+

"\nGO"+
"\nSET ANSI_PADDING OFF"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
        "\nADD CONSTRAINT[DF_Date2]  DEFAULT(getdate()) FOR[Fecha]"+
"\nGO"+
"\nALTER TABLE[dbo].[Entradas]"+
        "\nWITH CHECK ADD CONSTRAINT[FK_ProductoOut2] FOREIGN KEY([Articulo])"+
"\nREFERENCES[dbo].[Producto] ([id_producto])"+
"\nGO"+
"\nALTER TABLE[dbo].[Entradas]"+
        "\nCHECK CONSTRAINT[FK_ProductoOut2]"+
"\nGO"+
"\nALTER TABLE[dbo].[Entradas]"+
        "\nWITH CHECK ADD CONSTRAINT[FK_Usuario] FOREIGN KEY([Usuario])"+
"\nREFERENCES[dbo].[Usuario] ([id_usuario])"+
"\nGO"+
"\nALTER TABLE[dbo].[Entradas]"+
        "\nCHECK CONSTRAINT[FK_Usuario]"+
"\nGO"+
"\nALTER TABLE[dbo].[Inventario]"+
       "\n WITH CHECK ADD CONSTRAINT[FK_ProductoOut3] FOREIGN KEY([Articulo])"+
"\nREFERENCES[dbo].[Producto] ([id_producto])"+
"\nGO"+
"\nALTER TABLE[dbo].[Inventario]"+
        "\nCHECK CONSTRAINT[FK_ProductoOut3]"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
        "\nWITH CHECK ADD CONSTRAINT[FK_ClienteOut] FOREIGN KEY([Cliente])"+
"\nREFERENCES[dbo].[Cliente] ([id_cliente])"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
        "\nCHECK CONSTRAINT[FK_ClienteOut]"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
        "\nWITH CHECK ADD CONSTRAINT[FK_ProductoOut] FOREIGN KEY([Articulo])"+
"\nREFERENCES[dbo].[Producto] ([id_producto])"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
        "\nCHECK CONSTRAINT[FK_ProductoOut]"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
       "\n WITH CHECK ADD CONSTRAINT[FK_UsuarioOut] FOREIGN KEY([Usuario])"+
"\nREFERENCES[dbo].[Usuario] ([id_usuario])"+
"\nGO"+
"\nALTER TABLE[dbo].[Salidas]"+
       "\n CHECK CONSTRAINT[FK_UsuarioOut]"+
"\nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  StoredProcedure [dbo].[add_buy]    Script Date: 21/12/2020 20:03:22 ******/
                strSQL = "/nSET ANSI_NULLS ON" +
               "/nGO" +
               "/nSET QUOTED_IDENTIFIER ON" +
               "/nGO" +

               "/nCreate Procedure[dbo].[add_buy]" +
                       "/n@id int," +
               "/n@user int," +
               "/n@quantity int," +
               "/n@Article int," +
               "/n@comment varchar(50)," +
               "/n@total_sale decimal(4,2)" +
               "/nAs" +
               "/nDeclare @cant INT" +
               "/nselect @cant = Cantidad from Inventario where Articulo = @Article" +
               "/nif (Select COUNT(*) from Producto where id_producto = @Article)>0" +
               "/nBegin" +
               "/ninsert into Entradas Values(@id,default, @user, @quantity, @Article, @comment, @total_sale)" +
               "/nupdate Inventario SET Cantidad = @cant + @quantity where Articulo = @Article" +
               "/nEnd" +
               "/nelse" +
               "/nBegin" +
               "/nPRINT 'Cantidad pedida rebasa a la de stock'" +
               "/nEnd" +

               "/nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  StoredProcedure [dbo].[add_client]    Script Date: 21/12/2020 20:03:22 ******/
                strSQL = "/nSET ANSI_NULLS ON" +
 "/nGO" +
 "/nSET QUOTED_IDENTIFIER ON" +
 "/nGO" +
 "/nCreate Procedure[dbo].[add_client]" +
         "/n@name varchar(50)" +
 "/nAS" +
 "/nif (select COUNT(*) from Usuario where Nombre = @name)=0" +
 "/nBegin" +
 "/ninsert into Cliente values(@name)" +
 "/nEnd" +
 "/nELSE" +
 "/nBegin" +
 "/nPrint 'Ya hay un usuario con ese nombre'" +
 "/nEnd" +

 "/nGO";
                DB.ExecuteQuery(strSQL);
                /****** Object:  StoredProcedure [dbo].[add_products]    Script Date: 21/12/2020 20:03:22 ******/
                strSQL = "/nSET ANSI_NULLS ON" +
   "/nGO" +
   "/nSET QUOTED_IDENTIFIER ON" +
   "/nGO" +
   "/nCreate Procedure[dbo].[add_products]" +
           "/n@id int," +
   "/n@name varchar(50)," +
   "/n@categoria Varchar(50)," +
   "/n@descripcion varchar(50)," +
   "/n@price decimal(4,2)" +
   "/nAs" +
   "/nif (Select COUNT(*) From Producto where Nombre = @name)=0" +
   "/nBegin" +
   "/ninsert into Producto values(@name, @categoria, @descripcion, @price)" +
   "/nDeclare @cod_product int" +
   "/nSelect @cod_product = id_producto from Producto where Nombre=@name--Sacamos el codigo del producto en inventario y lo agregamos a inventario" +
   "/ninsert into Inventario values(@id, @cod_product,0, @descripcion)" +
   "/nEnd" +
   "/nELSE" +
   "/nBegin" +
   "/nPRINT 'Ya existe un producto con ese nombre'" +
   "/nEnd" +

   "/nGO";
                DB.ExecuteQuery(strSQL);
/****** Object:  StoredProcedure [dbo].[add_sale]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure[dbo].[add_sale]
        @id int,
@user int,
@client int,
@quantity int,
@Article int,
@comment varchar(50),
@total_sale decimal(4,2)
As
Declare @cant INT
select @cant = Cantidad from Inventario where Articulo = @Article
if (@cant>@quantity)
Begin
insert into Salidas Values(@id, @user, @client,default, @quantity, @Article, @comment, @total_sale)
END
ELSE
Begin
PRINT 'Cantidad pedida rebasa a la de stock'
END

GO
USE[master]
GO
ALTER DATABASE[Supermercado_Angel] SET READ_WRITE
GO
";

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

