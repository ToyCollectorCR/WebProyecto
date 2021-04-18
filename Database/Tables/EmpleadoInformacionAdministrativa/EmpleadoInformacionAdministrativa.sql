CREATE TABLE [dbo].[EmpleadoInformacionAdministrativa]
(
	IdInformacionAdministrativaEmpleado INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_InformacionAdministrativaEmpleado PRIMARY KEY CLUSTERED(IdInformacionAdministrativaEmpleado),
	NumeroSeguroSocial VARCHAR(50),
	CuentaBanco VARCHAR(50),
	RetencionCCSS INT NOT NULL,
	GeneracionDePagos VARCHAR(50),
	CategoriaProfesional VARCHAR(50),
	--CategoriaProfesional INT NOT NULL, CONSTRAINT FK_Cliente_Ventas FOREIGN KEY (CategoriaProfesional) REFERENCES dbo.Empleado(IdVentas),
	AsignarActividades VARCHAR(50),
	AsignarGuarderias VARCHAR(50),
)