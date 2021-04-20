CREATE PROCEDURE [dbo].[ClienteActualizar]
	@IdCliente INT,
	@IdClienteInformacionAdmin INT,
	@NombreCliente VARCHAR(50),
	@Apellido1Cliente VARCHAR(50),
	@Apellido2Cliente VARCHAR(50),
	@DireccionCliente VARCHAR(200),
	@FechaNacimientoCliente varchar(50),
	@TelefonoCliente varchar(50),
	@TarifaTieneHijos BIT,
	@TarifaCantidadHijos VARCHAR(1000)=NULL,
	@EstadoCliente BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.Cliente SET

			IdClienteInformacionAdmin=@IdClienteInformacionAdmin
		,	NombreCliente=@NombreCliente
		,   Apellido1Cliente=@Apellido1Cliente
		,   Apellido2Cliente=@Apellido2Cliente
		,   DireccionCliente=@DireccionCliente
		,   FechaNacimientoCliente=@FechaNacimientoCliente
		,   TelefonoCliente=@TelefonoCliente
		,	TarifaTieneHijos=@TarifaTieneHijos
		,	TarifaCantidadHijos=@TarifaCantidadHijos
		,	EstadoCliente=@EstadoCliente	
	
	WHERE IdCliente=@IdCliente

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