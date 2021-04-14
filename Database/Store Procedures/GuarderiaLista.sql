CREATE PROCEDURE [dbo].[GuarderiaLista]
	@IdGuarderia INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			NombreGuarderia,
			DiaDeLaSemanaGuarderia,
			HoraDeComienzoGuarderia,
			ProfesorResponsableGuarderia
	FROM dbo.Guarderia
	WHERE
		(@IdGuarderia IS NULL OR IdGuarderia=@IdGuarderia)
		--and
		--EstadoBebe=1

	ORDER BY NombreGuarderia

END
