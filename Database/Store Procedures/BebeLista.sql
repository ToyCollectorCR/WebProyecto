CREATE PROCEDURE [dbo].[BebeLista]
	@IdBebe INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdBebe,
			NombreBebe,
			Apellido1Bebe,
			Apellido2Bebe,
			NombrePadreMadreBebe,
			FechaNaciminetoBebe,
			InscripcionClasesBebe,
			AforoDisponibleBebe
			EstadoBebe
	FROM dbo.Bebe
	WHERE
		(@IdBebe IS NULL OR IdBebe=@IdBebe)
		and
		EstadoBebe=1

	ORDER BY NombreBebe

END