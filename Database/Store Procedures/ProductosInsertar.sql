CREATE PROCEDURE [dbo].[ProductosInsertar]
	@NombreProductos VARCHAR(50),
	@SesionesRayosUVA INT NOT NULL,
	@RenovacionCuota VARCHAR(MAX),
	@ProductosConsumidos VARCHAR(50),
	@CompraProveedores VARCHAR(50),
	@EstadoProducto BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Productos
		(
			NombreProductos,
			SesionesRayosUVA,
			RenovacionCuota,
			ProductosConsumidos,
			CompraProveedores,
			EstadoProducto
		)
		VALUES
		(
			@NombreProductos,
			@SesionesRayosUVA,
			@RenovacionCuota,
			@ProductosConsumidos,
			@CompraProveedores,
			@EstadoProducto
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
