CREATE PROCEDURE [dbo].[InstitucionAgregar]
 @Id_Institucion INT  ,
    @Codigo VARCHAR(250) ,
	@Nombre VARCHAR(250) ,
	@Telefono VARCHAR(250) ,
	@Estado bit 

	

     
    
    
AS

BEGIN
SET NOCOUNT ON

BEGIN TRANSACTION TRASA

BEGIN TRY
INSERT INTO dbo.Institucion 
(
      Id_Institucion
     ,Codigo
     ,Nombre
     ,Telefono
     ,Estado


)
VALUES
(
     @Id_Institucion
     ,@Codigo
     ,@Nombre
     ,@Telefono
     ,@Estado

)
	
    COMMIT TRANSACTION TRASA
   SELECT 0 AS CodeError,''AS  MsgError
   ENd TRY

   BEGIN CATCH
   SELECT 
   ERROR_NUMBER()AS CodeError,
   ERROR_MESSAGE() AS MsgError
  END CATCH

END