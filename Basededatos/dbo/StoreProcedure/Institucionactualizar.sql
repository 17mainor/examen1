CREATE PROCEDURE [dbo].[Institucionactualizar]
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
UPDATE  dbo.Institucion SET 

     Id_Institucion =  @Id_Institucion
     ,Nombre =@Nombre
     ,Telefono=@Telefono
     ,Telefono = @Telefono
     ,Estado =@Estado
 
     WHERE 
     Id_Institucion=@Id_Institucion
	
    COMMIT TRANSACTION TRASA
   SELECT 0 AS CodeError,''AS  MsgError
   ENd TRY

   BEGIN CATCH
   SELECT 
   ERROR_NUMBER()AS CodeError,
   ERROR_MESSAGE() AS MsgError
  END CATCH

END
