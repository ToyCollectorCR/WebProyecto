CREATE TABLE [dbo].[Proveedores]
(
	IdProveedores INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Proveedores PRIMARY KEY CLUSTERED(IdProveedores),
	IDProve VARCHAR(50) NOT NULL,
	NombreProveedores VARCHAR(50) NOT NULL,
	TelefonoProveedores VARCHAR(50) NOT NULL,
	CorreoProveedores VARCHAR(50) NOT NULL,
	EstadoProveedores BIT NOT NULL CONSTRAINT DF_Proveedores_EstadoProveedores DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)
