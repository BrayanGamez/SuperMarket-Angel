USE [master]
GO
/****** Object:  Database [Supermercado_Angel]    Script Date: 21/12/2020 20:03:21 ******/
CREATE DATABASE [Supermercado_Angel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Supermercado_Angel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Supermercado_Angel.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Supermercado_Angel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Supermercado_Angel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Supermercado_Angel] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Supermercado_Angel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Supermercado_Angel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Supermercado_Angel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Supermercado_Angel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Supermercado_Angel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Supermercado_Angel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Supermercado_Angel] SET  MULTI_USER 
GO
ALTER DATABASE [Supermercado_Angel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Supermercado_Angel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Supermercado_Angel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Supermercado_Angel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Supermercado_Angel] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Supermercado_Angel]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 21/12/2020 20:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[id_entrada] [int] NULL,
	[Fecha] [date] NOT NULL CONSTRAINT [DF_Date]  DEFAULT (getdate()),
	[Usuario] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Articulo] [int] NOT NULL,
	[Descripcion] [nchar](10) NULL,
	[Monto] [decimal](4, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[id_inventario] [int] NULL,
	[Articulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Precio_Unitario] [decimal](4, 2) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salidas]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salidas](
	[id_salida] [int] NULL,
	[Usuario] [int] NOT NULL,
	[Cliente] [int] NULL,
	[Fecha] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Articulo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Monto] [decimal](4, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Foto] [image] NULL,
	[Contraseña] [varchar](100) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Salidas] ADD  CONSTRAINT [DF_Date2]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_ProductoOut2] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_ProductoOut2]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_Usuario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_ProductoOut3] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_ProductoOut3]
GO
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [FK_ClienteOut] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [FK_ClienteOut]
GO
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [FK_ProductoOut] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [FK_ProductoOut]
GO
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioOut] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [FK_UsuarioOut]
GO
/****** Object:  StoredProcedure [dbo].[add_buy]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[add_buy]
@id int,
@user int,
@quantity int,
@Article int,
@comment varchar(50),
@total_sale decimal(4,2)
As
Declare @cant INT
select @cant = Cantidad from Inventario where Articulo = @Article
if (Select COUNT(*) from Producto where id_producto=@Article)>0
Begin
insert into Entradas Values (@id,default,@user,@quantity,@Article,@comment,@total_sale)
update Inventario SET Cantidad = @cant + @quantity where Articulo=@Article
End
else
Begin
PRINT 'Cantidad pedida rebasa a la de stock'
End

GO
/****** Object:  StoredProcedure [dbo].[add_client]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[add_client]
@name varchar(50)
AS
if(select COUNT(*) from Usuario where Nombre=@name)=0
Begin
insert into Cliente values (@name)
End
ELSE
Begin
Print 'Ya hay un usuario con ese nombre'
End

GO
/****** Object:  StoredProcedure [dbo].[add_products]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[add_products]
@id int,
@name varchar(50),
@categoria Varchar(50),
@descripcion varchar(50),
@price decimal(4,2)
As
if (Select COUNT(*) From Producto where Nombre=@name)=0
Begin
insert into Producto values (@name,@categoria,@descripcion,@price)
Declare @cod_product int
Select @cod_product = id_producto from Producto where Nombre=@name--Sacamos el codigo del producto en inventario y lo agregamos a inventario
insert into Inventario values (@id,@cod_product,0,@descripcion)
End
ELSE
Begin
PRINT 'Ya existe un producto con ese nombre'
End

GO
/****** Object:  StoredProcedure [dbo].[add_sale]    Script Date: 21/12/2020 20:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[add_sale]
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
insert into Salidas Values (@id,@user,@client,default,@quantity,@Article,@comment,@total_sale)
END
ELSE
Begin
PRINT 'Cantidad pedida rebasa a la de stock'
END

GO
USE [master]
GO
ALTER DATABASE [Supermercado_Angel] SET  READ_WRITE 
GO
