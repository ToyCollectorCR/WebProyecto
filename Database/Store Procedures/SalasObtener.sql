CREATE PROCEDURE [dbo].[SalasObtener]
	@IdSalas INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			NombreSalas
		,	CantidadSalas
		,	EstadoSalas

	FROM dbo.Salas
	WHERE
		(@IdSalas IS NULL OR IdSalas=@IdSalas)

END
