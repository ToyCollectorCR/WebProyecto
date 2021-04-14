CREATE PROCEDURE [dbo].[EmpleadoObtener]
	@IdEmpleado INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			TipoEmpleado
		,	NombreEmpleado
		,	Apellido1Empleado
		,	Apellido2Empleado
		,	DireccionEmpleado
		,	TelefonoEmpleado
		,	DNIEmpleado	

	FROM dbo.Empleado
	WHERE
		(@IdEmpleado IS NULL OR IdEmpleado=@IdEmpleado)

END

