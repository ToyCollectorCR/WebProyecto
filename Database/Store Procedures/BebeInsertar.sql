CREATE PROCEDURE [dbo].[BebeInsertar]
	@NombreBebe VARCHAR(50),
	@Apellido1Bebe VARCHAR(50),
	@Apellido2Bebe VARCHAR(50),
	@NombrePadreMadreBebe VARCHAR(50),
	@FechaNaciminetoBebe VARCHAR(MAX),
	@InscripcionClasesBebe INT,
	@AforoDisponibleBebe INT,
	@EstadoBebe BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Bebe
		(
			NombreBebe
		,	Apellido1Bebe
		,	Apellido2Bebe
		,	NombrePadreMadreBebe
		,	FechaNaciminetoBebe
		,	InscripcionClasesBebe
		,	AforoDisponibleBebe
		,	EstadoBebe
		)
		VALUES
		(
			@NombreBebe
		,	@Apellido1Bebe
		,	@Apellido2Bebe
		,	@NombrePadreMadreBebe
		,	@FechaNaciminetoBebe
		,	@InscripcionClasesBebe
		,	@AforoDisponibleBebe
		,	@EstadoBebe
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