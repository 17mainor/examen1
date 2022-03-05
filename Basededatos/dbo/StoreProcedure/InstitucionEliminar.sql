CREATE PROCEDURE [dbo].[InstitucionEliminar]
	@Id_Institucion int
	AS

BEGIN
SET NOCOUNT ON

BEGIN TRANSACTION TRASA

BEGIN TRY
     DELETE FROM dbo.Institucion 
	 where  Id_Institucion=@Id_Institucion

    COMMIT TRANSACTION TRASA
   SELECT 0 AS CodeError,''AS  MsgError
   ENd TRY

   BEGIN CATCH
   SELECT 
   ERROR_NUMBER()AS CodeError,
   ERROR_MESSAGE() AS MsgError
  END CATCH

END