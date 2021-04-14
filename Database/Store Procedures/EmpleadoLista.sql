CREATE PROCEDURE [dbo].[EmpleadoLista]
	@IdEmpleado INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdEmpleado,
			TipoEmpleado,
			NombreEmpleado,
			Apellido1Empleado,
			Apellido2Empleado,
			DireccionEmpleado,
			TelefonoEmpleado,
			DNIEmpleado

	FROM dbo.Empleado
	WHERE
		(@IdEmpleado IS NULL OR IdEmpleado=@IdEmpleado)

	ORDER BY TipoEmpleado

END
