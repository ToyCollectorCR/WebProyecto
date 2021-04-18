CREATE TABLE [dbo].[Guarderia]
(
	IdGuarderia INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Guarderia PRIMARY KEY CLUSTERED(IdGuarderia),
	NombreGuarderia VARCHAR(50) NOT NULL,
	DiaDeLaSemanaGuarderia DATE,
	HoraDeComienzoGuarderia TIME,
	ProfesorResponsableGuarderia VARCHAR(50) NOT NULL,
)WITH (DATA_COMPRESSION = PAGE)
