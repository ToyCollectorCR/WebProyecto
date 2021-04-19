CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaActualizar]
	@IdClienteInformacionAdmin INT,
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
		
	UPDATE ClienteInformacionAdministrativa SET
	Tarifa=@Tarifa, 
	SesionesRayosUVA=@SesionesRayosUVA,
	FechaProximaRenovacion=@FechaProximaRenovacion,--=CONVERT(VARCHAR,FechaProximaRenovacion,103),
	Casillero=@Casillero, 
	SaldoMonederoVirtual=@SaldoMonederoVirtual,
	TieneHijos=@TieneHijos

	where IdClienteInformacionAdmin=@IdClienteInformacionAdmin


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