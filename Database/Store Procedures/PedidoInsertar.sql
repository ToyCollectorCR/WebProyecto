CREATE PROCEDURE [dbo].[PedidoInsertar]
	
	@IdPedidos INT,
	@IdProductos INT,
	@IdProveedores INT,
	@Descripcion VARCHAR(200),
	@FechaCompra VARCHAR(MAX),
	@FechaRecepcion VARCHAR(MAX),
	@MontoCompra INT,
	@CantidadUnidades INT,
	@FechaCaducidad VARCHAR(MAX),
	@MotivoDevolucion VARCHAR(200),
	@EstadoPedidos BIT



AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Pedidos
		(
			 Descripcion,
			 FechaCompra,
			 FechaRecepcion,
			 MontoCompra, 
			 CantidadUnidades,
			 FechaCaducidad,
			 MotivoDevolucion,
			 EstadoPedidos
		
		)
		VALUES
		(
			 @Descripcion,
			 @FechaCompra,
			 @FechaRecepcion,
			 @MontoCompra, 
			 @CantidadUnidades,
			 @FechaCaducidad,
			 @MotivoDevolucion,
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
