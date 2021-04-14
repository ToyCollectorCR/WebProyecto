CREATE PROCEDURE [dbo].[UsuarioLogin]
	@Usuario VARCHAR(150),
@Contrasena VARCHAR(100)

AS 
BEGIN

SET NOCOUNT ON

DECLARE @vcontrasena varbinary(100)= CAST(HASHBYTES('SHA1',@Contrasena) as varbinary(100))

DECLARE @User INT=NULL,
		@Estado  BIT=NULL,
		@UsuarioNoExiste VARCHAR(150)=NULL


SELECT
@UsuarioNoExiste=Usuario
FROM Usuario
WHERE Usuario=@Usuario 


SELECT
@User=IdUsuario,
@Estado=Estado
FROM Usuario
WHERE Usuario=@Usuario 
AND	  Contrasena=@vcontrasena


IF @User IS NOT NULL AND @Estado =1 BEGIN

SELECT 
IdUsuario,
Nombre,
0 AS CodeError, '' AS MsgError
FROM Usuario
WHERE Usuario=@Usuario 
AND	  Contrasena=@vcontrasena


END


IF @User IS NOT NULL AND @Estado=0 BEGIN

SELECT 
-2 AS CodeError, 
'El Usuario no se encuentra activo!' AS MsgError


END


IF @User IS NULL AND @UsuarioNoExiste IS NOT NULL BEGIN 

SELECT -3 AS CodeError, 
'Contraseña incorrecta!' AS MsgError

END


IF @UsuarioNoExiste IS NULL BEGIN
SELECT -4 AS CodeError, 
'Usuario no existe!' AS MsgError

END





END