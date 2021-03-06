CREATE PROCEDURE [dbo].[SalasActualizar]
	@IdSalas INT,
	@NombreSalas VARCHAR(50),
	@CantidadSalas INT,
	@EstadoSalas BIT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		UPDATE Salas SET
		NombreSalas=@NombreSalas,
		CantidadSalas=@CantidadSalas,
		EstadoSalas=@EstadoSalas
		
		WHERE IdSalas=@IdSalas
		
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