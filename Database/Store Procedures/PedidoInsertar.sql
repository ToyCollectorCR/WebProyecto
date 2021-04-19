CREATE PROCEDURE [dbo].[PedidoInsertar]
	@Pedidos VARCHAR(50),
	@EstadoPedidos BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Pedidos
		(
			Pedidos,
			EstadoPedidos
		
		)
		VALUES
		(
			@Pedidos,
			@EstadoPedidos
		
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