CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaObtener]
	@IdEmpleadoInformacionAdministrativa INT = null
	AS BEGIN
	SET NOCOUNT ON
	
	select 
		IdEmpleadoInformacionAdministrativa,
		NumeroSeguroSocial,
		CuentaBanco,
		RetencionCCSS,
		GeneracionDePagos,
		CategoriaProfesional,
		AsignarActividades,
		AsignarGuarderias

FROM dbo.EmpleadoInformacionAdministrativa 

WHERE (@IdEmpleadoInformacionAdministrativa IS NULL OR IdEmpleadoInformacionAdministrativa=@IdEmpleadoInformacionAdministrativa)

END