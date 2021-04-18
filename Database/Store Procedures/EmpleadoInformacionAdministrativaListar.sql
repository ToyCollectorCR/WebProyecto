CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaListar]
	
	AS BEGIN
	SET NOCOUNT ON

	SELECT 
		IdEmpleadoInformacionAdministrativa
		NumeroSeguroSocial,
		CuentaBanco,
		RetencionCCSS,
		GeneracionDePagos,
		CategoriaProfesional,
		AsignarActividades,
		AsignarGuarderias

	FROM dbo.EmpleadoInformacionAdministrativa

	ORDER BY IdEmpleadoInformacionAdministrativa
END