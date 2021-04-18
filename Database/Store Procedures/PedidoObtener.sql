CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedidos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdPedidos
		,	Pedidos
		,	EstadoPedidos

	FROM dbo.Pedidos
	WHERE
		(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)
		and
		EstadoPedidos=1

END