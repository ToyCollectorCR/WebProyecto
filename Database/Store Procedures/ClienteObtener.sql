CREATE PROCEDURE [dbo].[ClienteObtener]
@IdCliente INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			Cli.IdCliente
		--,	Cli.IdBebe
		--,	Cli.IdClases
		--,	Cli.IdSalas
		--,	Cli.IdTarifa
		,	Cli.NombreCliente
		,   Cli.Apellido1Cliente
		,   Cli.Apellido2Cliente
		,   Cli.DireccionCliente
		,   Cli.FechaNacimientoCliente
		,   Cli.TelefonoCliente
		,   Cli.DNICliente
		,	Cli.EstadoCliente

		,   Bb.IdBebe
		,	Bb.NombreBebe

		,   Cla.IdClases
		,   Cla.ActividadImpartidaClases

		,   S.IdSalas
		,   S.NombreSalas
		
		,	Ta.IdTarifa
		,	Ta.PrecioTarifa

		,   Prod.IdProductos
		,	Prod.ProductosConsumidos
		

	FROM dbo.Cliente Cli
	left join dbo.Bebe Bb
		ON Cli.IdBebe = Bb.IdBebe
	left join dbo.Clases Cla
		ON Cli.IdClases = Cla.IdClases
	left join dbo.Salas S
		ON S.IdSalas = Cli.IdSalas
	left join dbo.Productos Prod
		ON Cli.IdProductos = Prod.IdProductos
	left join dbo.Tarifas Ta
		ON Cli.IdTarifa = Ta.IdTarifa
	WHERE (@IdCliente IS NULL OR IdCliente=@IdCliente)

	and
		EstadoCliente=1

END