USE [Facturacion]
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_insertarRegistro]    Script Date: 30/01/2015 13:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Usuarios_insertarRegistro]
@usu_id int,
@usu_identi varchar(50),
@usu_apeynom varchar(50),
@usu_clave varchar(10),
@usu_prf_id int,
@usu_entrada char(1),
@usu_auditor char(1)

AS

INSERT INTO [dbo].[Usuarios]
           ([usu_identi]
           ,[usu_apeynom]
           ,[usu_clave]
           ,[usu_prf_id]
           ,[usu_entrada]
           ,[usu_auditor])
     VALUES
           (@usu_identi
           ,@usu_apeynom
           ,@usu_clave
           ,@usu_prf_id
           ,@usu_entrada
           ,@usu_auditor)


      set @usu_id=@@IDENTITY
	  select @usu_id as usu_id