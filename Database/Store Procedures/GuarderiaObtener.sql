CREATE PROCEDURE [dbo].[GuarderiaObtener]
	@IdGuarderia INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdGuarderia
		,	NombreGuarderia
		,	DiaDeLaSemanaGuarderia
		,	HoraDeComienzoGuarderia
		,	ProfesorResponsableGuarderia

	FROM dbo.Guarderia
	WHERE
		(@IdGuarderia IS NULL OR IdGuarderia=@IdGuarderia)

END
