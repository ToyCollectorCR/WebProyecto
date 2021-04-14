CREATE PROCEDURE [dbo].[TarifasInsertar]
	@Tarifas VARCHAR(50),
	@Ofertas VARCHAR(50),
	@MesesDuracion INT,
	@InclusionBebes INT,
	@PrecioTarifa INT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Tarifas
		(
			Tarifas,
			Ofertas,
			MesesDuracion,
			InclusionBebes,
			PrecioTarifa
		)
		VALUES
		(
			@Tarifas,
			@Ofertas,
			@MesesDuracion,
			@InclusionBebes,
			@PrecioTarifa
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
