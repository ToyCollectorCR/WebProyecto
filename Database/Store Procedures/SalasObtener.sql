CREATE PROCEDURE [dbo].[SalasObtener]
	@IdSalas INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdSalas
		,	NombreSalas
		,	CantidadSalas
		,	EstadoSalas

	FROM dbo.Salas
	WHERE
		(@IdSalas IS NULL OR IdSalas=@IdSalas)
		and
		EstadoSalas=1
END
