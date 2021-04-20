CREATE TABLE [dbo].[Bebe]
(
	IdBebe INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Bebe PRIMARY KEY CLUSTERED(IdBebe),
	NombreBebe VARCHAR(50) NOT NULL,
	Apellido1Bebe VARCHAR(50) NOT NULL,
	Apellido2Bebe VARCHAR(50) NOT NULL,
	NombrePadreMadreBebe VARCHAR(50)NOT NULL,
	FechaNacimientoBebe DATETIME,
	InscripcionClasesBebe INT NOT NULL,
	AforoDisponibleBebe INT NOT NULL,
	EstadoBebe BIT NOT NULL CONSTRAINT DF_Bebe_EstadoBebe DEFAULT(0), 
)
