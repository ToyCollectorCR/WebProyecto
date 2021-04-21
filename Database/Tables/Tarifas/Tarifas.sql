﻿CREATE TABLE [dbo].[Tarifas]
(
	IdTarifa INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Tarifa PRIMARY KEY CLUSTERED(IdTarifa),
	Tarifas VARCHAR(50) NOT NULL,
	Ofertas VARCHAR(50) NOT NULL,
	MesesDuracion INT NOT NULL,
	InclusionBebes INT NOT NULL,
	PrecioTarifa INT NOT NULL,
	DescripcionOfertas VARCHAR(50) NOT NULL,
	EstadoOfertas BIT NOT NULL CONSTRAINT DF_Tarifas_EstadoOfertas DEFAULT(0),
)WITH (DATA_COMPRESSION = PAGE)