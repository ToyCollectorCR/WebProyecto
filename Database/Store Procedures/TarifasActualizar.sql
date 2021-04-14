CREATE PROCEDURE [dbo].[TarifasActualizar]
	@IdTarifa INT,
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
		
		UPDATE Tarifas SET
		Tarifas=@Tarifas,
		Ofertas=@Ofertas,
		MesesDuracion=@MesesDuracion,
		InclusionBebes=@InclusionBebes,
		PrecioTarifa=@PrecioTarifa
		WHERE IdTarifa=@IdTarifa
		
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