namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Data.Parameters;
    using System;

    #endregion

    public interface IRepositoryTCampanas : IDisposable
    {
        IEnumerable<TCampañas> Get();
        object Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio);
        object Get_pa_TCampanas(DataCampana dataCampana);
    }
}
