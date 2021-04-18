CREATE TABLE [dbo].[Productos]
(
	IdProductos INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Productos PRIMARY KEY CLUSTERED(IdProductos),
	NombreProductos VARCHAR(50) NOT NULL,
	SesionesRayosUVA INT,
	RenovacionCuota DATE,
	ProductosConsumidos VARCHAR(50) NOT NULL,
	CompraProveedores VARCHAR(50) NOT NULL,
	EstadoProducto BIT NOT NULL CONSTRAINT DF_Producto_EstadoProducto DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)
