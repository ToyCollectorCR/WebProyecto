CREATE PROCEDURE [dbo].[ProductosLista]
@IdProductos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdProductos,
			NombreProductos,
			SesionesRayosUVA,
			RenovacionCuota=CONVERT(VARCHAR,RenovacionCuota,103),
			ProductosConsumidos,
			CompraProveedores,
			EstadoProducto

	FROM dbo.Productos
	WHERE
		(@IdProductos IS NULL OR IdProductos=@IdProductos)
		and
		EstadoProducto=1

	ORDER BY NombreProductos
END

