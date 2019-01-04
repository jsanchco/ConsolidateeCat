namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Common;
    using System.Data.SqlClient;

    #endregion

    public class RepositoryTCampanas : RepositoryBase, IRepositoryTCampanas
    {
        public IEnumerable<TCampañas> Get()
        {
            return Context.TCampañas;
        }

        public IEnumerable<TCampañas> Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio)
        {
            var result = Context.Database.SqlQuery<TCampañas>(
                "exec dbo.[pa_Get_T_Campañas] @nIdLineaP, @nPagina, @nCantidad, @sFechaInicio",
                new SqlParameter("@nIdLineaP", nIdLineaP),
                new SqlParameter("@nPagina", nPagina),
                new SqlParameter("@nCantidad", nCantidad),
                new SqlParameter("@sFechaInicio", sFechaInicio)
            );

            return null;
        }
    }
}
