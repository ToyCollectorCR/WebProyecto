CREATE PROCEDURE [dbo].[BebeActualizar]
	@IdBebe INT,
	@NombreBebe VARCHAR(50),
	@Apellido1Bebe VARCHAR(50),
	@Apellido2Bebe VARCHAR(50),
	@NombrePadreMadreBebe VARCHAR(50),
	@FechaNacimientoBebe VARCHAR(MAX),
	@InscripcionClasesBebe INT,
	@AforoDisponibleBebe INT,
	@EstadoBebe BIT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		UPDATE Bebe SET
		NombreBebe = @NombreBebe,
		Apellido1Bebe = @Apellido1Bebe,
		Apellido2Bebe = @Apellido2Bebe,
		NombrePadreMadreBebe = @NombrePadreMadreBebe,
		FechaNacimientoBebe=CONVERT(VARCHAR,FechaNacimientoBebe,103),
		InscripcionClasesBebe = @InscripcionClasesBebe,
		AforoDisponibleBebe = @AforoDisponibleBebe,
		EstadoBebe = @EstadoBebe

		WHERE IdBebe=@IdBebe
		
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