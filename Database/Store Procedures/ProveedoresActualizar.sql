CREATE PROCEDURE [dbo].[ProveedoresActualizar]
	@IdProveedores INT,
	@NombreProveedores VARCHAR(50),
	@TelefonoProveedores VARCHAR(50),
	@CorreoProveedores VARCHAR(50),
	@EstadoProveedores BIT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		UPDATE Proveedores SET
		NombreProveedores=@NombreProveedores,
		TelefonoProveedores=@TelefonoProveedores,
		CorreoProveedores=@CorreoProveedores,
		EstadoProveedores=@EstadoProveedores
		
		WHERE IdProveedores=@IdProveedores
		
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