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

	ORDER BY Tarifas

END
