CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaInsertar]
	@Tarifa INT,
	@SesionesRayosUVA INT,
	@FechaProximaRenovacion VARCHAR(MAX),
	@Casillero INT,
	@SaldoMonederoVirtual INT,
	@TieneHijos BIT

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	INSERT INTO ClienteInformacionAdministrativa
	(
	Tarifa,
	SesionesRayosUVA,
	FechaProximaRenovacion,
	Casillero,
	SaldoMonederoVirtual,
	TieneHijos
	)
	VALUES
	(
	@Tarifa,
	@SesionesRayosUVA,
	@FechaProximaRenovacion,
	@Casillero,
	@SaldoMonederoVirtual,
	@TieneHijos
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
