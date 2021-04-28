CREATE PROCEDURE [dbo].[EmpleadoObtener]
	@IdEmpleado INT =NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			E.IdEmpleado
		,	E.TipoEmpleado
		,	E.NombreEmpleado
		,	E.Apellido1Empleado
		,	E.Apellido2Empleado
		,	E.DireccionEmpleado
		,	E.TelefonoEmpleado
		,	E.DNIEmpleado	
		,	E.EstadoEmpleado
		,	EIA.IdEmpleadoInformacionAdministrativa
		,	EIA.CategoriaProfesional
		,	EIA.NumeroSeguroSocial
		,	EIA.GeneracionDePagos
		,	EIA.RetencionCCSS
		,	EIA.CuentaBanco
		,   EIA.AsignarGuarderias
		,	EIA.AsignarActividades
		

	FROM dbo.Empleado E
	INNER JOIN  dbo.EmpleadoInformacionAdministrativa EIA
		ON E.IdEmpleadoInformacionAdministrativa = EIA.IdEmpleadoInformacionAdministrativa

	WHERE
		(@IdEmpleado IS NULL OR IdEmpleado=@IdEmpleado)

END

