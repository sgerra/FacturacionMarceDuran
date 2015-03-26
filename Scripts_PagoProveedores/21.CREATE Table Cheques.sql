USE [Facturacion]
GO

/****** Object:  Table [dbo].[Cheques]    Script Date: 12/12/2014 11:12:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cheques](
	[pcp_idpcp] [int] IDENTITY(1,1) NOT NULL,
	[pcp_nrocheque] [nvarchar](50) NULL,
	[pcp_banco] [int] NULL,
	[pcp_monto] [float] NULL,
	[pcp_fecemi] [smalldatetime] NULL,
	[pcp_fecpago] [smalldatetime] NULL,
	[pcp_soc_id] [int] NULL,
	[pcp_nropago] [int] NULL,
	[pcp_origen] [char](1) NULL,
 CONSTRAINT [PK_ChequesPropios] PRIMARY KEY CLUSTERED 
(
	[pcp_idpcp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Me indica si son cheques propios (P) o de terceros (T)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cheques', @level2type=N'COLUMN',@level2name=N'pcp_origen'
GO


