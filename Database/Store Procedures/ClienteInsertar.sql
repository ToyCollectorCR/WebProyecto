CREATE PROCEDURE [dbo].[ClienteInsertar]
	--@IdCliente INT,
	@IdBebe INT,
	@IdClases INT,
	@IdSalas INT,
	@IdTarifa INT,
	@IdProductos INT,
	@NombreCliente VARCHAR(50),
	@Apellido1Cliente VARCHAR(50),
	@Apellido2Cliente VARCHAR(50),
	@DireccionCliente VARCHAR(200),
	@FechaNacimientoCliente varchar(50),
	@TelefonoCliente varchar(50),
	@DNICliente varchar(50),
	@EstadoCliente BIT

	AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Cliente
		(
		--	IdCliente
			IdBebe
		,	IdClases
		,	IdSalas
		,	IdTarifa
		,	IdProductos
		,	NombreCliente
		,   Apellido1Cliente
		,   Apellido2Cliente
		,   DireccionCliente
		,   FechaNacimientoCliente
		,   TelefonoCliente
		,   DNICliente
		,	EstadoCliente
		
		)
		VALUES
		(
		  @IdBebe
		, @IdClases
		, @IdSalas
		, @IdTarifa
		, @IdProductos
		, @NombreCliente
	    , @Apellido1Cliente
	    , @Apellido2Cliente 
		, @DireccionCliente
		, @FechaNacimientoCliente
		, @TelefonoCliente
		, @DNICliente
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