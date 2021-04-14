CREATE PROCEDURE [dbo].[SalasLista]
	@IdSalas INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			NombreSalas,
			CantidadSalas,
			EstadoSalas

	FROM dbo.Salas
	WHERE
		(@IdSalas IS NULL OR IdSalas=@IdSalas)
		and
		EstadoSalas=1

	ORDER BY NombreSalas

END
