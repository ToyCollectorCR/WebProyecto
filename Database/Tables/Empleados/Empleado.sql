CREATE TABLE [dbo].[Empleado]
(
	IdEmpleado INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdEmpleado PRIMARY KEY CLUSTERED(IdEmpleado),
	TipoEmpleado VARCHAR(50),
	NombreEmpleado VARCHAR(50) NOT NULL,
	Apellido1Empleado VARCHAR(50) NOT NULL,
	Apellido2Empleado VARCHAR(50) NOT NULL,
	DireccionEmpleado VARCHAR(200) NOT NULL,
	TelefonoEmpleado VARCHAR(50) NOT NULL,
	DNIEmpleado VARCHAR(50) NOT NULL,

)
