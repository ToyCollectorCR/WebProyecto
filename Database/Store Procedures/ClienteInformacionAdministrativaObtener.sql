CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaObtener]
	@IdClienteInformacionAdmin INT = null
	AS BEGIN
	SET NOCOUNT ON
	
	select 
		IdClienteInformacionAdmin,
		Tarifa,
		SesionesRayosUVA,
		FechaProximaRenovacion, 
		Casillero,
		SaldoMonederoVirtual

FROM dbo.ClienteInformacionAdministrativa	

WHERE (@IdClienteInformacionAdmin IS NULL OR IdClienteInformacionAdmin=@IdClienteInformacionAdmin)

END
