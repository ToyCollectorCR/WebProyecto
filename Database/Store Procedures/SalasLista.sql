CREATE PROCEDURE [dbo].[SalasLista]

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdSalas,
			NombreSalas,
			CantidadSalas,
			EstadoSalas

	FROM dbo.Salas

	ORDER BY NombreSalas

END
