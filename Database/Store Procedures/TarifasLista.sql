CREATE PROCEDURE [dbo].[TarifasLista]
	@IdTarifa INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			Tarifas,
			Ofertas,
			MesesDuracion,
			InclusionBebes,
			PrecioTarifa

	FROM dbo.Tarifas
	WHERE
		(@IdTarifa IS NULL OR IdTarifa=@IdTarifa)
		--and
		--EstadoSalas=1

	ORDER BY Tarifas

END
