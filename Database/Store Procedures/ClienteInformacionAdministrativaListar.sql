CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaListar]
	@IdClienteInformacionAdmin INT = NULL

	AS BEGIN
	SET NOCOUNT ON

	SELECT 
			IdClienteInformacionAdmin,
			Tarifa,
			SesionesRayosUVA,
			FechaProximaRenovacion=CONVERT(VARCHAR,FechaProximaRenovacion,103),
			Casillero,
			SaldoMonederoVirtual,
			TieneHijos

	FROM dbo.ClienteInformacionAdministrativa
	WHERE
		(@IdClienteInformacionAdmin IS NULL OR IdClienteInformacionAdmin=@IdClienteInformacionAdmin)
		and
		TieneHijos=1
	
	ORDER BY IdClienteInformacionAdmin
END
