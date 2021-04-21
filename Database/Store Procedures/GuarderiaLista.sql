CREATE PROCEDURE [dbo].[GuarderiaLista]
	@IdGuarderia INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdGuarderia,
			NombreGuarderia,
			DiaDeLaSemanaGuarderia=CONVERT(VARCHAR,DiaDeLaSemanaGuarderia,103),
			HoraDeComienzoGuarderia=CONVERT(VARCHAR,HoraDeComienzoGuarderia,103),
			ProfesorResponsableGuarderia
	FROM dbo.Guarderia

	ORDER BY NombreGuarderia

END
