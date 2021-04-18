CREATE TABLE [dbo].[ClienteInformacionAdministrativa]
(
	IdClienteInformacionAdmin INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_ClienteInformacionAdmin PRIMARY KEY CLUSTERED(IdClienteInformacionAdmin),
	Tarifa INT NOT NULL,
	SesionesRayosUVA INT NOT NULL,
	FechaProximaRenovacion DATE,
	Casillero INT NOT NULL,
	SaldoMonederoVirtual INT NOT NULL,
)