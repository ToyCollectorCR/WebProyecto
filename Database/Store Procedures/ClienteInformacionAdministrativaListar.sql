CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaListar]
	
	AS BEGIN
	SET NOCOUNT ON

	SELECT 
			IdClienteInformacionAdmin,
			Tarifa,
			SesionesRayosUVA,
			FechaProximaRenovacion=CONVERT(VARCHAR,FechaProximaRenovacion,103),
			Casillero,
			SaldoMonederoVirtual

	FROM dbo.ClienteInformacionAdministrativa

	
	ORDER BY IdClienteInformacionAdmin
END
