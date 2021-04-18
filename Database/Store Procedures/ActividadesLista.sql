CREATE PROCEDURE [dbo].[ActividadesLista]
	
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdActividades,
			NombreActividad,
			Descripcion,
			Salas

	FROM dbo.Actividades

	ORDER BY NombreActividad

END