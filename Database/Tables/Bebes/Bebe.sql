CREATE TABLE [dbo].[Bebe]
(
	IdBebe INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Bebe PRIMARY KEY CLUSTERED(IdBebe),
	NombreBebe VARCHAR(50) not null,
	Apellido1Bebe VARCHAR(50) not null,
	Apellido2Bebe VARCHAR(50) not null,
	NombrePadreMadreBebe VARCHAR(50),
	FechaNaciminetoBebe date,
	InscripcionClasesBebe INT NOT NULL,
	AforoDisponibleBebe INT NOT NULL,
	EstadoBebe BIT NOT NULL CONSTRAINT DF_Bebe_Estado DEFAULT(0), 
)
