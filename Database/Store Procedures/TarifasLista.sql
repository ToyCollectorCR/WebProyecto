CREATE PROCEDURE [dbo].[TarifasLista]

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdTarifa,
			Tarifas,
			Ofertas,
			MesesDuracion,
			InclusionBebes,
			PrecioTarifa,
			DescripcionOfertas,
			EstadoOfertas

	FROM dbo.Tarifas

	ORDER BY MesesDuracion

END
