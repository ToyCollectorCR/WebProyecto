CREATE PROCEDURE [dbo].[ProductosObtener]
	@IdProductos INT =NULL
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
	WHERE
		(@IdProductos IS NULL OR IdProductos=@IdProductos)
		and
		EstadoProducto=1
END