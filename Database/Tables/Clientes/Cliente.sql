CREATE TABLE [dbo].[Cliente]
(
	  IdCliente INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdCliente PRIMARY KEY CLUSTERED(IdCliente),
	  IdTarifa INT NOT NULL CONSTRAINT FK_Cliente_Tarifas FOREIGN KEY(IdTarifa) REFERENCES dbo.Tarifas(IdTarifa),
	  IdClienteInformacionAdmin INT NOT NULL CONSTRAINT FK_Cliente_ClienteInformacionAdministrativa FOREIGN KEY(IdClienteInformacionAdmin) REFERENCES dbo.ClienteInformacionAdministrativa(IdClienteInformacionAdmin),
	  NombreCliente VARCHAR(50) NOT NULL,
	  Apellido1Cliente VARCHAR(50) NOT NULL,
	  Apellido2Cliente VARCHAR(50) NOT NULL,
	  DireccionCliente VARCHAR(200) NOT NULL,
	  FechaNacimientoCliente DATE,
	  TelefonoCliente VARCHAR(50) NOT NULL,
	  EstadoCliente BIT NOT NULL CONSTRAINT DF_Cliente_Estado DEFAULT(0)
)WITH (DATA_COMPRESSION = PAGE)
