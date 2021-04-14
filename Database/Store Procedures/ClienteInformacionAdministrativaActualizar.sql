CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaActualizar]
	@IdClienteInformacionAdmin INT,
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
		
	update dbo.ClienteInformacionAdministrativa set
	IdCliente=@IdCliente, 
	Tarifa=@Tarifa, 
	SesionesRayosUVA=@SesionesRayosUVA,
	FechaProximaRenovacion=@FechaProximaRenovacion, 
	Casillero=@Casillero, 
	SaldoMonederoVirtual=@SaldoMonederoVirtual
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