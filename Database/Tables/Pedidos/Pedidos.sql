CREATE TABLE [dbo].[Pedidos]
(
	IdPedidos INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Pedidos PRIMARY KEY CLUSTERED(IdPedidos),
	IdProductos INT NOT NULL CONSTRAINT FK_Pedidos_IdProductos FOREIGN KEY(IdProductos) REFERENCES dbo.Productos(IdProductos),
	Descripcion VARCHAR(200) NOT NULL,
	IdProveedores INT NOT NULL CONSTRAINT FK_Pedidos_IdProveedores FOREIGN KEY(IdProveedores) REFERENCES dbo.Proveedores(IdProveedores),
	FechaCompra DATE,
	FechaRecepcion DATE,
	MontoCompra INT NOT NULL,
	CantidadUnidades INT NOT NULL,
	FechaCaducidad DATE,
	MotivoDevolucion VARCHAR(200),
	EstadoPedidos BIT NOT NULL CONSTRAINT DF_Pedidos_EstadoPedidos DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)