CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaListar]
	
	AS BEGIN
	SET NOCOUNT ON

	SELECT 
			IdClienteInformacionAdmin,
			Tarifa,
			SesionesRayosUVA,
			FechaProximaRenovacion,
			Casillero,
			SaldoMonederoVirtual

	FROM dbo.ClienteInformacionAdministrativa

	
	ORDER BY IdClienteInformacionAdmin
END
