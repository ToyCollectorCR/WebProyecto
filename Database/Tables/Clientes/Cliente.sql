CREATE TABLE [dbo].[Cliente]
(
	  IdCliente INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdCliente PRIMARY KEY CLUSTERED(IdCliente),
	  IdBebe INT NOT NULL CONSTRAINT FK_Cliente_Bebe FOREIGN KEY(IdBebe) REFERENCES dbo.Bebe(IdBebe),
	  IdClases INT NOT NULL CONSTRAINT FK_Cliente_Clases FOREIGN KEY(IdClases) REFERENCES dbo.Clases(IdClases),
	  IdSalas INT NOT NULL CONSTRAINT FK_Cliente_Salas FOREIGN KEY(IdSalas) REFERENCES dbo.Salas(IdSalas),
	  IdTarifa INT NOT NULL CONSTRAINT FK_Cliente_Tarifas FOREIGN KEY(IdTarifa) REFERENCES dbo.Tarifas(IdTarifa),
	  IdProductos INT NOT NULL CONSTRAINT FK_Cliente_Productos FOREIGN KEY(IdProductos) REFERENCES dbo.Productos(IdProductos),
	  NombreCliente VARCHAR(50) NOT NULL,
	  Apellido1Cliente VARCHAR(50) NOT NULL,
	  Apellido2Cliente VARCHAR(50) NOT NULL,
	  DireccionCliente VARCHAR(200) NOT NULL,
	  FechaNacimientoCliente DATE,
	  TelefonoCliente VARCHAR(50) NOT NULL,
	  DNICliente INT NOT NULL CONSTRAINT FK_Cliente_Ventas FOREIGN KEY (DNICliente) REFERENCES dbo.Ventas(IdVentas),
	  --DNIVentas INT NOT NULL, CONSTRAINT FK_Cliente_Ventas FOREIGN KEY (DNICliente) REFERENCES dbo.Ventas(IdVentas),
	  EstadoCliente BIT NOT NULL CONSTRAINT DF_Cliente_Estado DEFAULT(0)
)
