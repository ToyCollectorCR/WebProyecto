CREATE PROCEDURE [dbo].[ClasesActualizar]
	@IdClases INT,
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
		
		UPDATE Clases SET
		SalaImpartidaClases = @SalaImpartidaClases,
		DiaDeLaSemanaClases=CONVERT(VARCHAR,DiaDeLaSemanaClases,103),
		HoraDeComienzoClases=CONVERT(VARCHAR,HoraDeComienzoClases,103),
		ActividadImpartidaClases = @ActividadImpartidaClases,
		ProfesorResponsableClases = @ProfesorResponsableClases,
		EstadoClases = @EstadoClases
		WHERE IdClases=@IdClases


		
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