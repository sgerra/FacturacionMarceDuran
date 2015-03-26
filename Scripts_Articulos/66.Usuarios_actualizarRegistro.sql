USE [Facturacion]
GO

CREATE PROCEDURE Usuarios_actualizarRegistro
@usu_id int,
@usu_identi varchar(50),
@usu_apeynom varchar(50),
@usu_clave varchar(10),
@usu_prf_id int,
@usu_entrada char(1),
@usu_auditor char(1)

AS

UPDATE [dbo].[Usuarios]

set [usu_identi]=@usu_identi,
    [usu_apeynom]=@usu_apeynom,
    [usu_clave]=@usu_clave,
    [usu_prf_id]=@usu_prf_id,
    [usu_entrada]=@usu_entrada,
    [usu_auditor]=@usu_auditor
    
	WHERE usu_id=@usu_id 

GO


