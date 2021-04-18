CREATE PROCEDURE [dbo].[ActividadesLista]
	
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdActividades,
			NombreActividad,
			Descripcion,
			Salas

	FROM dbo.Actividades
	--WHERE
		--(@IdActividades IS NULL OR IdActividades=@IdActividades)
		--and
		--EstadoBebe=1

	ORDER BY NombreActividad

END