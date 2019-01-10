namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Common;
    using System.Data.SqlClient;
    using Data.Parameters;

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
}
