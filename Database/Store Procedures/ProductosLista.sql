CREATE PROCEDURE [dbo].[ProductosLista]
@IdProductos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT

			IdProductos,
			IdProveedores,
			NombreProductos,
			SesionesRayosUVA,
			RenovacionCuota=CONVERT(VARCHAR,RenovacionCuota,103),
			ProductosConsumidos,
			EstadoProducto

	FROM dbo.Productos
	WHERE
		(@IdProductos IS NULL OR IdProductos=@IdProductos)
		and
		EstadoProducto=1

	ORDER BY IdProductos
END
