
using System.Data;

namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Common;
    using System.Data.SqlClient;
    using Data.Parameters;
    using System;
    using System.Linq;
    using System.Reflection;
    using eCat.Data.Common;

    #endregion

    public class RepositoryTCampanas : RepositoryBase, IRepositoryTCampanas
    {
        public IEnumerable<TCampañas> Get()
        {
            return Context.TCampañas;
        }

        public object Get_pa_TCampanas(DataCampana dataCampana)
        {
            var result = Context.Database.SqlQuery<string>(
                "exec dbo.[pa_Get_T_Campañas] @nIdLineaP, @nPagina, @nCantidad, @sFechaInicio",
                new SqlParameter("@nIdLineaP", dataCampana.IdLineaP),
                new SqlParameter("@nPagina", dataCampana.Pagina),
                new SqlParameter("@nCantidad", dataCampana.Cantidad),
                new SqlParameter("@sFechaInicio", dataCampana.FechaInicio)
            );

            return result;
        }

        public long? pa_Insert_T_Campanas(DataInsertTCampana dataInsertTCampana)
        {
            var resultStoreProcedure =
                new ResultStoreProcedure(MethodBase.GetCurrentMethod(), dataInsertTCampana.ToUri());

            try
            {
                var returnParam = new SqlParameter
                {
                    ParameterName = "@return",
                    Direction = ParameterDirection.ReturnValue
                };

                Context.Database.SqlQuery<long>(
                    "exec dbo.[pa_Insert_T_Campañas] @nsDescripcion, @dtDesde, @dtHasta",
                    new SqlParameter("@nsDescripcion", dataInsertTCampana.Descripcion),
                    new SqlParameter("@dtDesde", dataInsertTCampana.Desde),
                    new SqlParameter("@dtHasta", dataInsertTCampana.Hasta),
                    returnParam);

                resultStoreProcedure.Code = Convert.ToInt64(returnParam.Value);

                resultStoreProcedure.Status = resultStoreProcedure.Code == 1 ? Status.Ok : Status.Error;

                return resultStoreProcedure.Code;
            }
            catch (Exception e)
            {
                resultStoreProcedure.Status = Status.Exception;
                resultStoreProcedure.Description = e.Message;

                throw;
            }
            finally
            {
                var fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\log.txt";
                using (var sw = new System.IO.StreamWriter(fileName, true))
                {
                    sw.WriteLine(resultStoreProcedure.ToString());
                }
            }
        }

        public object Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio)
        {
            var result = Context.Database.SqlQuery<string>(
                "exec dbo.[pa_Get_T_Campañas] @nIdLineaP, @nPagina, @nCantidad, @sFechaInicio",
                new SqlParameter("@nIdLineaP", nIdLineaP),
                new SqlParameter("@nPagina", nPagina),
                new SqlParameter("@nCantidad", nCantidad),
                new SqlParameter("@sFechaInicio", sFechaInicio)
            );

            return result;
        }
    }

    public class MyReturn
    {
        public long Value { get; set; }
    }
}
