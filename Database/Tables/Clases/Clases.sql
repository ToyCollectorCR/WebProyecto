CREATE TABLE [dbo].[Clases]
(
	IdClases INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Clases PRIMARY KEY CLUSTERED(IdClases),
	SalaImpartidaClases VARCHAR(50) NOT NULL,
	DiaDeLaSemanaClases date,
	HoraDeComienzoClases TIME,
	ActividadImpartidaClases VARCHAR(50) NOT NULL,
	ProfesorResponsableClases VARCHAR(50) NOT NULL,
	EstadoClases BIT NOT NULL CONSTRAINT DF_Clases_EstadoClases DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)
