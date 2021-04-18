CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaObtener]
	@IdInformacionAdministrativaEmpleado INT = null
	AS BEGIN
	SET NOCOUNT ON
	
	select 
		IdInformacionAdministrativaEmpleado,
		NumeroSeguroSocial,
		CuentaBanco,
		RetencionCCSS,
		GeneracionDePagos,
		CategoriaProfesional,
		AsignarActividades,
		AsignarGuarderias
		--NombreEmpleado,
		--TipoEmpleado


FROM dbo.EmpleadoInformacionAdministrativa 



WHERE (@IdInformacionAdministrativaEmpleado IS NULL OR IdInformacionAdministrativaEmpleado=@IdInformacionAdministrativaEmpleado)

END

