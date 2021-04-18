CREATE PROCEDURE [dbo].[ClasesLista]
	@IdClases INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdClases,
			SalaImpartidaClases,
			DiaDeLaSemanaClases=CONVERT(VARCHAR,DiaDeLaSemanaClases,103),
			HoraDeComienzoClases=CONVERT(VARCHAR,HoraDeComienzoClases,103),
			ActividadImpartidaClases,
			ProfesorResponsableClases,
			EstadoClases
	FROM dbo.Clases
	WHERE
		(@IdClases IS NULL OR IdClases=@IdClases)
		and
		EstadoClases=1

	ORDER BY DiaDeLaSemanaClases

END