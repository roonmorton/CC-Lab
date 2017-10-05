go
CREATE PROCEDURE [dbo].[SpGrabarModificarMuestra]
	@PidMuestra int,
	@PDescripcion varchar(125),
	@Pusuario varchar(40)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM MUESTRA WHERE IDMUESTRA = @PidMuestra)
	BEGIN
		UPDATE MUESTRA SET descripcion = @PDescripcion, fechamodificacion = GETDATE(), usuarioModificacion = @Pusuario
		WHERE idMuestra = @PidMuestra
	END
	ELSE
	BEGIN
		INSERT MUESTRA(DESCRIPCION, fechaCreacion,usuarioCreacion)
		VALUES(@PDescripcion,GETDATE(),@Pusuario)
	END
END;
go



 
 
 go
CREATE PROCEDURE [DBO].[SpEliminarMuestra]
	@PidMuestra int
AS
BEGIN
--Verifica si hay vehículos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM ANALISIS WHERE IDMUESTRA = @PidMuestra)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay vehículos que tienen asignado esta linea',16,1);
	END
	ELSE
	BEGIN
		DELETE MUESTRA WHERE IDMUESTRA = @PidMuestra
	END
END;
go


SELECT * FROM  MUESTRA  where DESCRIPCION LIKE '%%'








-- LOGIN

go
CREATE PROCEDURE SPLogin
	@Pusuario varchar(45),
	@Pcontrasena varchar(75)
as
begin
	SELECT IDUSUARIO,NOMBRES,APELLIDOS,ESTADO,USUARIO FROM USUARIO WHERE USUARIO.USUARIO = @Pusuario AND USUARIO.PASSWORD =@Pcontrasena;
end;
go


EXEC SPLogin @pUSUARIO = '', @PCONTRASENA = ''