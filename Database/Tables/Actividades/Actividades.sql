CREATE TABLE [dbo].[Actividades]
(
	IdActividades INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdActividades PRIMARY KEY CLUSTERED(IdActividades),
	NombreActividad VARCHAR(50) NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,
	Salas INT NOT NULL,
)