CREATE PROCEDURE [dbo].[EmpleadoInformacionAdministrativaActualizar]
	@IdEmpleadoInformacionAdministrativa INT,
	@NumeroSeguroSocial VARCHAR(50),
	@CuentaBanco VARCHAR(50),
	@RetencionCCSS INT,
	@GeneracionDePagos VARCHAR(50),
	@CategoriaProfesional VARCHAR(50),
	@AsignarActividades VARCHAR(50),
	@AsignarGuarderias VARCHAR(50)
AS BEGIN

SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
	UPDATE dbo.EmpleadoInformacionAdministrativa SET
	NumeroSeguroSocial=@NumeroSeguroSocial, 
	CuentaBanco=@CuentaBanco, 
	RetencionCCSS=@RetencionCCSS,
	GeneracionDePagos=@GeneracionDePagos, 
	CategoriaProfesional=@CategoriaProfesional, 
	AsignarActividades=@AsignarActividades ,
	@AsignarGuarderias=@AsignarGuarderias
	
	where IdEmpleadoInformacionAdministrativa=@IdEmpleadoInformacionAdministrativa

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END