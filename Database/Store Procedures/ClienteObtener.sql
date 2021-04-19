CREATE PROCEDURE [dbo].[ClienteObtener]
@IdCliente INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT

		Cli.NombreCliente
		,   Cli.Apellido1Cliente
		,   Cli.Apellido2Cliente
		,   Cli.DireccionCliente
		,   Cli.FechaNacimientoCliente
		,   Cli.TelefonoCliente
		,	Cli.EstadoCliente



	FROM dbo.Cliente Cli
	
	WHERE (@IdCliente IS NULL OR IdCliente=@IdCliente)



END