CREATE PROCEDURE [dbo].[ClienteInformacionAdministrativaObtener]
	@IdClienteInformacionAdmin INT = null
	AS BEGIN
	SET NOCOUNT ON
	
	select 
		CIA.IdClienteInformacionAdmin,
		CIA.IdCliente,
		CIA.Tarifa,
		CIA.SesionesRayosUVA,
		FechaProximaRenovacion = CONVERT(VARCHAR,CIA.FechaProximaRenovacion,103),
		CIA.Casillero,
		CIA.SaldoMonederoVirtual

FROM dbo.ClienteInformacionAdministrativa CIA
INNER JOIN Cliente C
ON CIA.IdCliente=C.IdCliente

--INNER JOIN Provincia P
--ON IP.IdProvincia=P.IdProvincia

--INNER JOIN Canton C
--ON IP.IdCanton=C.IdCanton
--and P.IdProvincia=P.IdProvincia

--INNER JOIN Distrito D
--ON IP.IdDistrito=D.IdDistrito
--AND C.IdCanton=C.IdCanton

WHERE (@IdClienteInformacionAdmin IS NULL OR IdClienteInformacionAdmin=@IdClienteInformacionAdmin)

END
