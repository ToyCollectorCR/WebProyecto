CREATE PROCEDURE [dbo].[SalasLista]

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdSalas,
			NombreSalas,
			CantidadSalas,
			EstadoSalas

	FROM dbo.Salas
	--WHERE
		--(@IdSalas IS NULL OR IdSalas=@IdSalas)
		--and
		--EstadoSalas=1

	ORDER BY NombreSalas

END
