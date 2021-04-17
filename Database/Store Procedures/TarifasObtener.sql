CREATE PROCEDURE [dbo].[TarifasObtener]
	@IdTarifa INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdTarifa
		,	Tarifas
		,	Ofertas
		,	MesesDuracion
		,	InclusionBebes
		,	PrecioTarifa	

	FROM dbo.Tarifas
	WHERE
		(@IdTarifa IS NULL OR IdTarifa=@IdTarifa)

END