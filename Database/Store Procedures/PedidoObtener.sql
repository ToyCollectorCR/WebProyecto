CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedidos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			Pedidos

	FROM dbo.Pedidos
	WHERE
		(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)

END