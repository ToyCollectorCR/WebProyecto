CREATE PROCEDURE [dbo].[BebeObtener]
	@IdBebe INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdBebe
		,	NombreBebe
		,	Apellido1Bebe
		,	Apellido2Bebe
		,	NombrePadreMadreBebe
		,   FechaNacimientoBebe=CONVERT(VARCHAR,FechaNacimientoBebe,103)
		,	InscripcionClasesBebe
		,	AforoDisponibleBebe
		,	EstadoBebe	

	FROM dbo.Bebe
	WHERE
		(@IdBebe IS NULL OR IdBebe=@IdBebe)

END