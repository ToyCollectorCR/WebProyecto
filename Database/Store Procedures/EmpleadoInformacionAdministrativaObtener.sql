CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaObtener]
	@IdInformacionAdministrativaEmpleado INT = null
	AS BEGIN
	SET NOCOUNT ON
	
	select 
		EIA.IdInformacionAdministrativaEmpleado,
		EIA.IdEmpleado,
		EIA.NumeroSeguroSocial,
		EIA.CuentaBanco,
		EIA.RetencionCCSS,
		EIA.GeneracionDePagos,
		EIA.CategoriaProfesional,
		EIA.AsignarActividades,
		EIA.AsignarGuarderias,
		E.NombreEmpleado,
		E.TipoEmpleado


FROM dbo.EmpleadoInformacionAdministrativa EIA
INNER JOIN Empleado E
ON EIA.IdEmpleado=E.IdEmpleado

--INNER JOIN Provincia P
--ON IP.IdProvincia=P.IdProvincia

--INNER JOIN Canton C
--ON IP.IdCanton=C.IdCanton
--and P.IdProvincia=P.IdProvincia

--INNER JOIN Distrito D
--ON IP.IdDistrito=D.IdDistrito
--AND C.IdCanton=C.IdCanton


WHERE (@IdInformacionAdministrativaEmpleado IS NULL OR IdInformacionAdministrativaEmpleado=@IdInformacionAdministrativaEmpleado)

END

