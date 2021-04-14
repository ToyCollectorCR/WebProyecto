CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaInsertar]
	@IdCliente INT,
	@Tarifa INT,
	@SesionesRayosUVA INT,
	@FechaProximaRenovacion VARCHAR(MAX),
	@Casillero INT,
	@SaldoMonederoVirtual INT
AS BEGIN

SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	INSERT INTO ClienteInformacionAdministrativa(
	IdCliente,
	Tarifa,
	SesionesRayosUVA,
	FechaProximaRenovacion,
	Casillero,
	SaldoMonederoVirtual
	)VALUES(
	@IdCliente,
	@Tarifa,
	@SesionesRayosUVA,
	@FechaProximaRenovacion,
	@Casillero,
	@SaldoMonederoVirtual
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
