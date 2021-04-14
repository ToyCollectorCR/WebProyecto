CREATE TABLE [dbo].[Productos]
(
	IdProductos INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdProductos PRIMARY KEY CLUSTERED(IdProductos),
	NombreProductos VARCHAR(50) NOT NULL,
	SesionesRayosUVA VARCHAR(50) NOT NULL,
	RenovacionCuota VARCHAR(50) NOT NULL,
	ProductosConsumidos VARCHAR(50) NOT NULL,
	CompraProveedores VARCHAR(50) NOT NULL,
	EstadoProducto BIT,
)
