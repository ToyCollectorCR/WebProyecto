CREATE TABLE [dbo].[Guarderia]
(
	IdGuarderia INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdGuarderia PRIMARY KEY CLUSTERED(IdGuarderia),
	NombreGuarderia VARCHAR(50) NOT NULL,
	DiaDeLaSemanaGuarderia DATE,
	HoraDeComienzoGuarderia TIME,
	ProfesorResponsableGuarderia VARCHAR(50) NOT NULL,
)
