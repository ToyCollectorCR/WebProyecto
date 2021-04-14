CREATE PROCEDURE [dbo].[ActividadesInsertar]
	@NombreActividad VARCHAR(50),
	@Descripcion VARCHAR(50),
	@Salas INT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Actividades
		(
			NombreActividad
		,	Descripcion
		,	Salas
		)
		VALUES
		(
			@NombreActividad
		,	@Descripcion
		,	@Salas
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
