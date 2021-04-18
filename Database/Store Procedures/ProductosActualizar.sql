CREATE PROCEDURE [dbo].[ProductosActualizar]
	@IdProductos INT,
	@NombreProductos VARCHAR(50),
	@SesionesRayosUVA INT,
	@RenovacionCuota DATE,
	@ProductosConsumidos VARCHAR(50),
	@CompraProveedores VARCHAR(50),
	@EstadoProducto BIT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		UPDATE Productos SET
		NombreProductos=@NombreProductos,
		SesionesRayosUVA=@SesionesRayosUVA,
		RenovacionCuota=@RenovacionCuota,--=CONVERT(VARCHAR,RenovacionCuota,103),
		ProductosConsumidos=@ProductosConsumidos,
		CompraProveedores=@CompraProveedores,
		EstadoProducto=@EstadoProducto
		
		WHERE IdProductos=@IdProductos
		
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