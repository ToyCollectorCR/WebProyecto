CREATE PROCEDURE [dbo].[GuarderiaObtener]
	@IdGuarderia INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdGuarderia
		,	NombreGuarderia
		,   DiaDeLaSemanaGuarderia=CONVERT(VARCHAR,DiaDeLaSemanaGuarderia,103) 
		,	HoraDeComienzoGuarderia=CONVERT(VARCHAR,HoraDeComienzoGuarderia,108) 
		,	ProfesorResponsableGuarderia

	FROM dbo.Guarderia
	WHERE
		(@IdGuarderia IS NULL OR IdGuarderia=@IdGuarderia)

END
