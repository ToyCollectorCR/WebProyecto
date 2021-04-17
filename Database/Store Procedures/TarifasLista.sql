CREATE PROCEDURE [dbo].[TarifasLista]

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdTarifa,
			Tarifas,
			Ofertas,
			MesesDuracion,
			InclusionBebes,
			PrecioTarifa

	FROM dbo.Tarifas
	--WHERE
		--(@IdTarifa IS NULL OR IdTarifa=@IdTarifa)
		--and
		--EstadoSalas=1

	ORDER BY Tarifas

END
