CREATE TABLE [dbo].[ClienteInformacionAdministrativa]
(
	IdClienteInformacionAdmin INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_ClienteInformacionAdmin PRIMARY KEY CLUSTERED(IdClienteInformacionAdmin),
	IdCliente INT NOT NULL CONSTRAINT FK_ClienteInformacionAdmin_Cliente FOREIGN KEY(IdCliente) REFERENCES dbo.Cliente(IdCliente),
	Tarifa INT NOT NULL,
	SesionesRayosUVA INT NOT NULL,
	FechaProximaRenovacion DATE,
	Casillero INT NOT NULL,
	SaldoMonederoVirtual INT NOT NULL,
)