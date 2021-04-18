CREATE PROCEDURE [dbo].[ProveedoresLista]
@IdProveedores INT =NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdProveedores,
			NombreProveedores,
			TelefonoProveedores,
			CorreoProveedores,
			EstadoProveedores

	FROM dbo.Proveedores
	WHERE
		(@IdProveedores IS NULL OR IdProveedores=@IdProveedores)
		and
		EstadoProveedores=1

	ORDER BY NombreProveedores
END
