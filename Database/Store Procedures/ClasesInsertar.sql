CREATE PROCEDURE [dbo].[ClasesInsertar]
	@SalaImpartidaClases VARCHAR(50),
	@DiaDeLaSemanaClases VARCHAR(MAX),
	@HoraDeComienzoClases VARCHAR(MAX),
	@ActividadImpartidaClases VARCHAR(50),
	@ProfesorResponsableClases VARCHAR(50),
	@EstadoClases BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Clases
		(
			SalaImpartidaClases
		,	DiaDeLaSemanaClases
		,	HoraDeComienzoClases
		,	ActividadImpartidaClases
		,	ProfesorResponsableClases
		,   EstadoClases
		)
		VALUES
		(
			@SalaImpartidaClases
		,	@DiaDeLaSemanaClases
		,	@HoraDeComienzoClases
		,	@ActividadImpartidaClases
		,	@ProfesorResponsableClases
		,	@EstadoClases
		)


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END