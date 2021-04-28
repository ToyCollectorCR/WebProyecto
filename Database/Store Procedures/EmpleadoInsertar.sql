CREATE PROCEDURE [dbo].[EmpleadoInsertar]
	
	@IdEmpleadoInformacionAdministrativa INT,
	@TipoEmpleado VARCHAR(50),
	@NombreEmpleado VARCHAR(50),
	@Apellido1Empleado VARCHAR(50),
	@Apellido2Empleado VARCHAR(50),
	@DireccionEmpleado VARCHAR(50),
	@TelefonoEmpleado VARCHAR(50),
	@DNIEmpleado VARCHAR(50),
	@EstadoEmpleado BIT

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Empleado
		(
			IdEmpleadoInformacionAdministrativa,
			TipoEmpleado,
			NombreEmpleado,
			Apellido1Empleado,
			Apellido2Empleado,
			DireccionEmpleado,
			TelefonoEmpleado,
			DNIEmpleado,
			EstadoEmpleado
		)
		VALUES
		(
			@IdEmpleadoInformacionAdministrativa,
			@TipoEmpleado,
			@NombreEmpleado,
			@Apellido1Empleado,
			@Apellido2Empleado,
			@DireccionEmpleado,
			@TelefonoEmpleado,
			@DNIEmpleado,
			@EstadoEmpleado
		)


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