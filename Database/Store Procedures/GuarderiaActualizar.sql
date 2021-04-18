CREATE PROCEDURE [dbo].[GuarderiaActualizar]
	@IdGuarderia INT,
	@NombreGuarderia VARCHAR(50),
	@DiaDeLaSemanaGuarderia VARCHAR(MAX),
	@HoraDeComienzoGuarderia VARCHAR(MAX),
	@ProfesorResponsableGuarderia VARCHAR(50)
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		UPDATE Guarderia SET
		NombreGuarderia = @NombreGuarderia,
		DiaDeLaSemanaGuarderia=CONVERT(VARCHAR,DiaDeLaSemanaGuarderia,103),
		HoraDeComienzoGuarderia = @HoraDeComienzoGuarderia,
		ProfesorResponsableGuarderia = @ProfesorResponsableGuarderia
		
		WHERE IdGuarderia=@IdGuarderia
		
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