USE [Facturacion]
GO

/****** Object:  Table [dbo].[Compras]    Script Date: 29/10/2014 01:52:24 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Compras](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[NroFactura] [varchar](50) NULL,
	[Fecha] [datetime] NULL,
	[idcondPago] [int] NULL,
	[idTipoFact] [int] NULL,
	[idEstado] [int] NULL,
	[idProveedor] [int] NULL,
	[Totalcompra] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


