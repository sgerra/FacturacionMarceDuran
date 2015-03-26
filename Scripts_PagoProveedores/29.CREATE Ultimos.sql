USE [Facturacion]
GO

/****** Object:  Table [dbo].[Ultimos]    Script Date: 23/12/2014 11:04:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Ultimos](
	[idUltimo] [int] IDENTITY(1,1) NOT NULL,
	[NombreTabla] [varchar](50) NULL,
	[Campo] [varchar](50) NULL,
	[ultimo] [int] NULL,
 CONSTRAINT [PK_Ultimos] PRIMARY KEY CLUSTERED 
(
	[idUltimo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


