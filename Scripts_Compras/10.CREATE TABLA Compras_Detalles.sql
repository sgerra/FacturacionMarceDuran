USE [Facturacion]
GO

/****** Object:  Table [dbo].[Compras_Detalles]    Script Date: 29/10/2014 02:03:58 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Compras_Detalles](
	[iddet] [int] IDENTITY(1,1) NOT NULL,
	[idCompra] [int] NULL,
	[codart] [int] NULL,
	[descri] [varchar](100) NULL,
	[cantidad] [int] NULL,
	[idunidad] [int] NULL,
	[precio] [decimal](18, 2) NULL,
	[porciva] [decimal](18, 2) NULL,
	[montoiva] [decimal](18, 2) NULL,
	[porcImpInt] [decimal](18, 2) NULL,
	[montoImpInt] [decimal](18, 2) NULL,
	[porcDto] [decimal](18, 2) NULL,
	[montoDto] [decimal](18, 2) NULL,
	[punitfinal] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Compras_Detalles] PRIMARY KEY CLUSTERED 
(
	[iddet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


