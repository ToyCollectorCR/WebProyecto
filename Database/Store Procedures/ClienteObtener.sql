CREATE PROCEDURE [dbo].[ClienteObtener]
@IdCliente INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			Cli.IdCliente
		,	Cli.NombreCliente
		,	Cli.DNICliente
		,   Cli.Apellido1Cliente
		,   Cli.Apellido2Cliente
		,   Cli.DireccionCliente
		,   FechaNacimientoCliente=CONVERT(VARCHAR,Cli.FechaNacimientoCliente,103)
		,   Cli.TelefonoCliente
		,	Cli.EstadoCliente
		,   Cli.IdClienteInformacionAdmin
		,	CIA.SesionesRayosUVA
		,	FechaProximaRenovacion=CONVERT(VARCHAR,CIA.FechaProximaRenovacion,103)
		,	CIA.Casillero
		,	CIA.SaldoMonederoVirtual

	FROM dbo.Cliente Cli

	--LEFT JOIN 
	INNER JOIN  dbo.ClienteInformacionAdministrativa CIA
		ON Cli.IdClienteInformacionAdmin = CIA.IdClienteInformacionAdmin
	
	WHERE (@IdCliente IS NULL OR IdCliente=@IdCliente)

END