CREATE PROCEDURE [dbo].[ProveedoresObtener]
	@IdProveedores INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdProveedores,
			IDProve,
			NombreProveedores,
			TelefonoProveedores,
			CorreoProveedores,
			EstadoProveedores

	FROM dbo.Proveedores
	WHERE
		(@IdProveedores IS NULL OR IdProveedores=@IdProveedores)
		
		
END