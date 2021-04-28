CREATE PROCEDURE [dbo].[PedidoLista]
@IdPedidos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			 Descripcion,
			 FechaCompra,
			 FechaRecepcion,
			 MontoCompra, 
			 CantidadUnidades,
			 FechaCaducidad,
			 MotivoDevolucion
	 
	FROM dbo.Pedidos
	WHERE
		(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)

	ORDER BY FechaCompra
END
