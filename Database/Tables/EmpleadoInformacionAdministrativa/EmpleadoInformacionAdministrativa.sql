CREATE TABLE [dbo].[EmpleadoInformacionAdministrativa]
(
	IdInformacionAdministrativaEmpleado INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_IdInformacionAdministrativaEmpleado PRIMARY KEY CLUSTERED(IdInformacionAdministrativaEmpleado),
	IdEmpleado INT NOT NULL CONSTRAINT FK_InformacionAdministrativa_Empleado FOREIGN KEY(IdEmpleado) REFERENCES dbo.Empleado(IdEmpleado),
	NumeroSeguroSocial VARCHAR(50),
	CuentaBanco VARCHAR(50),
	RetencionCCSS INT NOT NULL,
	GeneracionDePagos VARCHAR(50),
	CategoriaProfesional VARCHAR(50),
	--CategoriaProfesional INT NOT NULL, CONSTRAINT FK_Cliente_Ventas FOREIGN KEY (CategoriaProfesional) REFERENCES dbo.Empleado(IdVentas),
	AsignarActividades VARCHAR(50),
	AsignarGuarderias VARCHAR(50),
)