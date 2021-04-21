CREATE PROCEDURE [dbo].[ProductosObtener]
	@IdProductos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			Prod.IdProductos,
			Prod.IdProveedores,
			Prod.NombreProductos,
			Prod.SesionesRayosUVA,
			RenovacionCuota=CONVERT(VARCHAR,RenovacionCuota,103),
			Prod.ProductosConsumidos,
			Prod.EstadoProducto,
			Prov.NombreProveedores

	FROM dbo.Productos Prod

--LEFT JOIN 
	INNER JOIN  dbo.Proveedores Prov
		ON Prod.IdProveedores = Prov.IdProveedores
	
	WHERE (@IdProductos IS NULL OR IdProductos=@IdProductos)	

END