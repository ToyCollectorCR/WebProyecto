CREATE PROCEDURE [dbo].[ActividadesObtener]
	@IdActividades INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdActividades
		,	NombreActividad
		,	Descripcion
		,	Salas

	FROM dbo.Actividades
	WHERE
		(@IdActividades IS NULL OR IdActividades=@IdActividades)

END