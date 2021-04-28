CREATE PROCEDURE [dbo].[PedidoObtener]
	@IdPedidos INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			 PD.Descripcion,
			 FechaCompra=CONVERT(VARCHAR,PD.FechaCompra,103),
			 FechaRecepcion=CONVERT(VARCHAR,FechaRecepcion,103),
			 PD.MontoCompra, 
			 PD.CantidadUnidades,
			 FechaCaducidad=CONVERT(VARCHAR,PD.FechaCaducidad,103),
			 PD.MotivoDevolucion,
			 PD.EstadoPedidos,
			 PT.NombreProductos,
			 PV.NombreProveedores

	FROM dbo.Pedidos PD

		INNER JOIN dbo.Productos PT
			ON PD.IdProductos = PT.IdProductos
		INNER JOIN dbo.Proveedores PV
			ON PD.IdProveedores = PV.IdProveedores

	WHERE
		(@IdPedidos IS NULL OR IdPedidos=@IdPedidos)
		
		

END