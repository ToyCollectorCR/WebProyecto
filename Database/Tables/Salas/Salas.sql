﻿CREATE TABLE [dbo].[Salas]
(
	IdSalas INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdSalas PRIMARY KEY CLUSTERED(IdSalas),
	NombreSalas VARCHAR(50) NOT NULL,
	CantidadSalas INT NOT NULL,
	EstadoSalas BIT NOT NULL CONSTRAINT DF_Salas_Estado DEFAULT(0),
	
)
