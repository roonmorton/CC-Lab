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
--Verifica si hay vehÝculos relacionados con el actual registro antes de borrar
	IF EXISTS(SELECT 1 FROM ANALISIS WHERE IDMUESTRA = @PidMuestra)
	BEGIN
		RAISERROR ('No se puede eliminar porque actualmente hay vehÝculos que tienen asignado esta linea',16,1);
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
ALTER PROCEDURE SPLogin
	@Pusuario varchar(45),
	@Pcontrasena varchar(75)
as
begin
	SELECT IDUSUARIO,NOMBRES,APELLIDOS,ESTADO,USUARIO FROM USUARIO WHERE UPPER(USUARIO.USUARIO) = upper(@Pusuario) AND USUARIO.PASSWORD =CONVERT(VARCHAR(32), HashBytes('MD5', @Pcontrasena), 2);
end;
go


EXEC SPLogin @pUSUARIO = '', @PCONTRASENA = ''









select * from RESULTADO_ANALISIS;




INSERT INTO RESULTADO_ANALISIS(IDNALISIS,IDRESULTADO,VALOR) VALUES();



go
ALTER PROCEDURE [dbo].[SpRegistrarResultado]
	@PidResultado int,
	@pidAnalisis int,
	@pValor varchar(75)	
AS
BEGIN
	INSERT INTO RESULTADO_ANALISIS(IDANALISIS,IDRESULTADO,VALOR) 
	VALUES(@pidAnalisis,@PidResultado,@pValor);
END;
go



select * from ANALISIS

SELECT * FROM ANALISIS A
INNER JOIN RESULTADO_ANALISIS RA
ON a.IDANALISIS = ra.IDANALISIS
INNER JOIN RESULTADO R
ON R.IDRESULTADO = RA.IDRESULTADO


select * FROM RESULTADO_ANALISIS

SELECT R.DESCRIPCION RESULTADO,RA.VALOR, R.VALORNORMAL, R.TIPOMEDIDA, A.FECHA, (P.NOMBRES + ' ' + P.APELLIDOS ) NOMBRES, YEAR(GETDATE()) - YEAR(P.FECHANACIMIENTO)EDAD, 
(
SELECT TP.DESCRIPCION FROM ANALISIS AA
INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTP
ON AA.IDANALISIS = AMTP.IDANALISIS
INNER JOIN MUESTRA_TIPO_ANALISIS MTP
ON MTP.IDMUESTRA_TIPO_ANALISIS = AMTP.IDMUESTRA_TIPO_ANALISIS
INNER JOIN TIPO_ANALISIS TP
ON TP.IDTIPO_ANALISIS = MTP.IDTIPO_ANALISIS 
WHERE AA.IDANALISIS = A.IDANALISIS
) TIPO_ANALISIS
 FROM RESULTADO R
INNER JOIN RESULTADO_ANALISIS RA
ON RA.IDRESULTADO = R.IDRESULTADO
LEFT JOIN ANALISIS A
ON A.IDANALISIS = RA.IDANALISIS
INNER JOIN PACIENTE P
ON P.IDPACIENTE = A.IDPACIENTE
where A.IDANALISIS = 10



SELECT * FROM TIPO_ANALISIS 
select * from ANALISIS_MUESTRA_TIPO_ANALISIS
SELECT * FROM MUESTRA_TIPO_ANALISIS

SELECT * FROM TIPO_ANALISIS TP
INNER JOIN MUESTRA_TIPO_ANALISIS
INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTP
ON TP.IDTIPO_ANALISIS = AMTP.
SELECT * FROM ANALISIS AA
INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTP
ON AA.IDANALISIS = AMTP.IDANALISIS
INNER JOIN MUESTRA_TIPO_ANALISIS MTP
ON MTP.IDMUESTRA_TIPO_ANALISIS = AMTP.IDMUESTRA_TIPO_ANALISIS
INNER JOIN TIPO_ANALISIS TP
ON TP.IDTIPO_ANALISIS = MTP.IDTIPO_ANALISIS 
WHERE AA.IDANALISIS = 8


SELECT * FROM RESULTADO_ANALISIS


SELECT * FROM ANALISIS
UPDATE ANALISIS SET FECHA_COMPLETADO = NULL



SELECT * FROM ANALISIS
SELECT * FROM ANALISIS_MUESTRA_TIPO_ANALISIS
SELECT * FROM MUESTRA_TIPO_ANALISIS *
SELECT * FROM TIPO_ANALISIS


SELECT TP.DESCRIPCION TIPOaNALISIS, AMTA.IDMUESTRA_TIPO_ANALISIS FROM TIPO_ANALISIS TP
INNER JOIN MUESTRA_TIPO_ANALISIS MTA
ON TP.IDTIPO_ANALISIS = MTA.IDTIPO_ANALISIS
INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTA
ON MTA.IDMUESTRA_TIPO_ANALISIS = AMTA.IDMUESTRA_TIPO_ANALISIS
WHERE AMTA.IDANALISIS = 8





SELECT R.DESCRIPCION RESULTADO, RA.VALOR, R.VALORNORMAL, R.TIPOMEDIDA, A.FECHA, (P.NOMBRES + ' ' + P.APELLIDOS ) NOMBRES, YEAR(GETDATE()) - YEAR(P.FECHANACIMIENTO)EDAD,  (SELECT TP.DESCRIPCION FROM ANALISIS AA INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTP ON AA.IDANALISIS = AMTP.IDANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS MTP ON MTP.IDMUESTRA_TIPO_ANALISIS = AMTP.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_ANALISIS TP ON TP.IDTIPO_ANALISIS = MTP.IDTIPO_ANALISIS  WHERE AA.IDANALISIS = A.IDANALISIS ) TIPO_ANALISIS 
FROM RESULTADO R INNER JOIN RESULTADO_ANALISIS RA ON RA.IDRESULTADO = R.IDRESULTADO 
LEFT JOIN ANALISIS A ON A.IDANALISIS = RA.IDANALISIS 
INNER JOIN PACIENTE P ON P.IDPACIENTE = A.IDPACIENTE where a.IDANALISIS = 10 


SELECT R.DESCRIPCION RESULTADO, RA.VALOR, R.VALORNORMAL, R.TIPOMEDIDA, A.FECHA, M.DESCRIPCION MUESTRA FROM RESULTADO R
LEFT JOIN RESULTADO_ANALISIS RA ON R.IDRESULTADO = RA.IDRESULTADO
INNER JOIN ANALISIS A
ON A.IDANALISIS = RA.IDANALISIS
INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTA
ON A.IDANALISIS = AMTA.IDANALISIS
INNER JOIN MUESTRA_TIPO_ANALISIS MTA
ON MTA.IDMUESTRA_TIPO_ANALISIS = AMTA.IDMUESTRA_TIPO_ANALISIS
INNER JOIN TIPO_ANALISIS TA
ON TA.IDTIPO_ANALISIS = MTA.IDTIPO_ANALISIS
INNER JOIN MUESTRA M 
ON M.IDMUESTRA = MTA.IDMUESTRA
WHERE MTA.IDMUESTRA_TIPO_ANALISIS = 28

