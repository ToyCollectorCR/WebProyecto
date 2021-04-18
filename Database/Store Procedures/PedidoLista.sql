CREATE PROCEDURE [dbo].[PedidoLista]
	
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdPedidos,
			Pedidos

	FROM dbo.Pedidos
	--WHERE
		--(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)
		--and
		--EstadoBebe=1

	ORDER BY Pedidos

END
