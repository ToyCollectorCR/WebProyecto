CREATE PROCEDURE [dbo].[ProductosLista]
	@IdProductos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			NombreProductos,
			SesionesRayosUVA,
			RenovacionCuota,
			ProductosConsumidos,
			CompraProveedores,
			EstadoProducto

	FROM dbo.Productos
	WHERE
		(@IdProductos IS NULL OR IdProductos=@IdProductos)
		--and
		--EstadoBebe=1

	ORDER BY NombreProductos

END
