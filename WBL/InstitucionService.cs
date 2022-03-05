using BD;
using Entity;
using Entity.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IInstitucionService
    {
        Task<DBEntity> CREATE(InstitucionEntity entity);
        Task<DBEntity> DELETE(InstitucionEntity entity);
        Task<IEnumerable<InstitucionEntity>> GET();
        Task<InstitucionEntity> GETBYID(InstitucionEntity entity);
        Task<DBEntity> UPDATE(InstitucionEntity entity);
    }

    public class InstitucionService : IInstitucionService
    {
        private readonly IDataAccess sql;

        public InstitucionService(IDataAccess sql)
        {
            this.sql = sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<InstitucionEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<InstitucionEntity>("dbo.InstitucionObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //MetodoGetById
        public async Task<InstitucionEntity> GETBYID(InstitucionEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<InstitucionEntity>("dbo.InstitucionObtener", new { entity.Id_Institucion });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo Create
        public async Task<DBEntity> CREATE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionAgregar", new
                {
                    entity.Id_Institucion,
                    entity.Codigo,
                    entity.Nombre,
                    entity.Telefono,
                    entity.Estado,

                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Metodo Update
        public async Task<DBEntity> UPDATE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.Institucionactualizar", new
                {

                    entity.Id_Institucion,
                    entity.Codigo,
                    entity.Nombre,
                    entity.Telefono,
                    entity.Estado,
                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> DELETE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.IInstitucionEliminar", new
                {
                    entity.Id_Institucion

                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

    }
}
