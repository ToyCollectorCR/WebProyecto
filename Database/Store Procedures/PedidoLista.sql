CREATE PROCEDURE [dbo].[PedidoLista]
	@IdPedidos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			Pedidos

	FROM dbo.Pedidos
	WHERE
		(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)
		--and
		--EstadoBebe=1

	ORDER BY Pedidos

END
