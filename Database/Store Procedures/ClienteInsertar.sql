CREATE PROCEDURE [dbo].[ClienteInsertar]
	@IdTarifa INT,
	@IdClienteInformacionAdmin INT,
	@NombreCliente VARCHAR(50),
	@Apellido1Cliente VARCHAR(50),
	@Apellido2Cliente VARCHAR(50),
	@DireccionCliente VARCHAR(200),
	@FechaNacimientoCliente VARCHAR(50),
	@TelefonoCliente VARCHAR(50),
	@TarifaTieneHijos BIT,
	@TarifaCantidadHijos VARCHAR(1000)=NULL,
	@EstadoCliente BIT

	AS BEGIN
	SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Cliente
		(
			IdClienteInformacionAdmin
		,	NombreCliente
		,   Apellido1Cliente
		,   Apellido2Cliente
		,   DireccionCliente
		,   FechaNacimientoCliente
		,   TelefonoCliente
		,	TarifaTieneHijos
		,	TarifaCantidadHijos
		,	EstadoCliente
		
		)
		VALUES
		(
			  @IdClienteInformacionAdmin
			, @NombreCliente
			, @Apellido1Cliente
			, @Apellido2Cliente 
			, @DireccionCliente
			, @FechaNacimientoCliente
			, @TelefonoCliente
			, @TarifaTieneHijos
			, @TarifaCantidadHijos
			, @EstadoCliente
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