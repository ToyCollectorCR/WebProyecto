CREATE TABLE [dbo].[EmpleadoInformacionAdministrativa]
(
	IdEmpleadoInformacionAdministrativa INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_EmpleadoInformacionAdministrativa PRIMARY KEY CLUSTERED(IdEmpleadoInformacionAdministrativa),
	NumeroSeguroSocial VARCHAR(50),
	CuentaBanco VARCHAR(50),
	RetencionCCSS INT NOT NULL,
	GeneracionDePagos VARCHAR(50),
	CategoriaProfesional VARCHAR(50),
	AsignarActividades VARCHAR(50),
	AsignarGuarderias VARCHAR(50),
)