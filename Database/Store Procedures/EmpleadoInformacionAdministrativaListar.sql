CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaListar]
	AS BEGIN
	SET NOCOUNT ON

	SELECT 
		NumeroSeguroSocial,
		CuentaBanco,
		RetencionCCSS,
		GeneracionDePagos,
		CategoriaProfesional,
		AsignarActividades,
		AsignarGuarderias

	FROM dbo.EmpleadoInformacionAdministrativa

	ORDER BY IdInformacionAdministrativaEmpleado
END
