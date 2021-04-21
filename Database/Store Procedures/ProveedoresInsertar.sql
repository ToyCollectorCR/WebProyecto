CREATE PROCEDURE [dbo].[ProveedoresInsertar]
	@NombreProveedores VARCHAR(50),
	@IDProve VARCHAR(50),
	@TelefonoProveedores VARCHAR(50),
	@CorreoProveedores VARCHAR(50),
	@EstadoProveedores BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Proveedores
		(
			NombreProveedores,
			IDProve,
			TelefonoProveedores,
			CorreoProveedores,
			EstadoProveedores
		)
		VALUES
		(
			@NombreProveedores,
			@IDProve,
			@TelefonoProveedores,
			@CorreoProveedores,
			@EstadoProveedores
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
