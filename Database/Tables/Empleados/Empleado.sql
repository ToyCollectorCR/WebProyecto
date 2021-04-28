CREATE TABLE [dbo].[Empleado]
(
	IdEmpleado INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdEmpleado PRIMARY KEY CLUSTERED(IdEmpleado),
	IdEmpleadoInformacionAdministrativa INT NOT NULL CONSTRAINT FK_Empleado_EmpleadoInformacionAdministrativa FOREIGN KEY(IdEmpleadoInformacionAdministrativa) REFERENCES dbo.EmpleadoInformacionAdministrativa(IdEmpleadoInformacionAdministrativa),  
	TipoEmpleado VARCHAR(50),
	NombreEmpleado VARCHAR(50) NOT NULL,
	Apellido1Empleado VARCHAR(50) NOT NULL,
	Apellido2Empleado VARCHAR(50) NOT NULL,
	DireccionEmpleado VARCHAR(200) NOT NULL,
	TelefonoEmpleado VARCHAR(50) NOT NULL,
	DNIEmpleado VARCHAR(50) NOT NULL,
	EstadoEmpleado BIT NOT NULL CONSTRAINT DF_Empleado_Estado DEFAULT(0)
)WITH (DATA_COMPRESSION = PAGE)
