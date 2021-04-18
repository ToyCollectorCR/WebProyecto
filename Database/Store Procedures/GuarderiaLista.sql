CREATE PROCEDURE [dbo].[GuarderiaLista]
	@IdGuarderia INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdGuarderia,
			NombreGuarderia,
			DiaDeLaSemanaGuarderia,
			HoraDeComienzoGuarderia,
			ProfesorResponsableGuarderia
	FROM dbo.Guarderia

	ORDER BY NombreGuarderia

END
