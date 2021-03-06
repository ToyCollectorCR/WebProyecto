CREATE PROCEDURE [dbo].[EmpleadoActualizar]
	@IdEmpleado INT,
	@IdEmpleadoInformacionAdministrativa INT,
	@TipoEmpleado VARCHAR(50),
	@NombreEmpleado VARCHAR(50),
	@Apellido1Empleado VARCHAR(50),
	@Apellido2Empleado VARCHAR(50),
	@DireccionEmpleado VARCHAR(50),
	@TelefonoEmpleado VARCHAR(50),
	@DNIEmpleado VARCHAR(50),
	@EstadoEmpleado INT

AS BEGIN

SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	update dbo.Empleado set

	IdEmpleadoInformacionAdministrativa=@IdEmpleadoInformacionAdministrativa,
	TipoEmpleado=@TipoEmpleado, 
	NombreEmpleado=@NombreEmpleado, 
	Apellido1Empleado=@Apellido1Empleado,
	Apellido2Empleado=@Apellido2Empleado, 
	DireccionEmpleado=@DireccionEmpleado, 
	TelefonoEmpleado=@TelefonoEmpleado,
	DNIEmpleado=@DNIEmpleado,
	EstadoEmpleado=@EstadoEmpleado 

	where IdEmpleado=@IdEmpleado

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END