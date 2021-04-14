CREATE TABLE [dbo].[Proveedores]
(
	IdProveedores INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdProveedores PRIMARY KEY CLUSTERED(IdProveedores),
	NombreProveedores VARCHAR(50) NOT NULL,
	TelefonoProveedores VARCHAR(50) NOT NULL,
	CorreoProveedores VARCHAR(50) NOT NULL,
	EstadoProveedores BIT NOT NULL DEFAULT(0),
	
)
