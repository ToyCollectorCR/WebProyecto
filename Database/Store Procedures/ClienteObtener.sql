CREATE PROCEDURE [dbo].[ClienteObtener]
@IdCliente INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			Cli.IdCliente
		,	Cli.NombreCliente
		,   Cli.Apellido1Cliente
		,   Cli.Apellido2Cliente
		,   Cli.DireccionCliente
		,   Cli.FechaNacimientoCliente
		,   Cli.TelefonoCliente
		,	Cli.TarifaTieneHijos
		,	Cli.TarifaCantidadHijos
		,	Cli.EstadoCliente
		,   Cli.IdClienteInformacionAdmin
		,	CIA.SesionesRayosUVA
		,	CIA.FechaProximaRenovacion
		,	CIA.Casillero
		,	CIA.SaldoMonederoVirtual

	FROM dbo.Cliente Cli

	--LEFT JOIN 
	INNER JOIN  dbo.ClienteInformacionAdministrativa CIA
		ON Cli.IdClienteInformacionAdmin = CIA.IdClienteInformacionAdmin
	
	WHERE (@IdCliente IS NULL OR IdCliente=@IdCliente)

END