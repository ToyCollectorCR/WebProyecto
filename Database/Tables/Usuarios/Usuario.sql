﻿CREATE TABLE [dbo].[Usuario]
(
	IdUsuario INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED(IdUsuario)
   ,	Usuario VARCHAR(150) NOT NULL
   ,	Nombre VARCHAR(250) NOT NULL
   ,	Contrasena Varbinary(100) NOT NULL
   ,	Estado BIT NOT NULL CONSTRAINT DF_Usuario_Estado DEFAULT(1)
)
GO
CREATE UNIQUE NONCLUSTERED INDEX IDX_Usuario_usuario
ON  dbo.Usuario (Usuario)

GO