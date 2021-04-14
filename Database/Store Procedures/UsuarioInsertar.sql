CREATE PROCEDURE [dbo].[UsuarioInsertar]
@Usuario VARCHAR(150),
@Nombre VARCHAR(250),
@Contrasena VARCHAR(100)
AS
BEGIN 
SET NOCOUNT ON


BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
DECLARE @vcontrasena varbinary(100)=CAST(HASHBYTES('SHA1',@Contrasena) as varbinary(100))


		INSERT INTO Usuario (
		Usuario,
		Nombre,
		Contrasena,
		Estado
		) VALUES(
		@Usuario,
		@Nombre,
		@vcontrasena,
		1
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