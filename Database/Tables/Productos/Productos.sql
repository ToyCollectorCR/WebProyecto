CREATE TABLE [dbo].[Productos]
(
	IdProductos INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Productos PRIMARY KEY CLUSTERED(IdProductos),
	IdProveedores INT NOT NULL CONSTRAINT FK_Productos_IdProveedores FOREIGN KEY(IdProveedores) REFERENCES dbo.Proveedores(IdProveedores),  
	NombreProductos VARCHAR(50) NOT NULL,
	SesionesRayosUVA INT,
	RenovacionCuota DATETIME,
	ProductosConsumidos VARCHAR(50) NOT NULL,
	EstadoProducto BIT NOT NULL CONSTRAINT DF_Producto_EstadoProducto DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)
