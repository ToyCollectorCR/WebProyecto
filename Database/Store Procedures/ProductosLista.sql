CREATE PROCEDURE [dbo].[ProductosLista]

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdProductos,
			NombreProductos,
			SesionesRayosUVA,
			RenovacionCuota,
			ProductosConsumidos,
			CompraProveedores,
			EstadoProducto

	FROM dbo.Productos
	--WHERE
		--(@IdProductos IS NULL OR IdProductos=@IdProductos)
		--and
		--EstadoBebe=1

	ORDER BY NombreProductos

END
