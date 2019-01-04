namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IRepositoryTCampanas
    {
        IEnumerable<TCampañas> Get();
        IEnumerable<TCampañas> Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio);
    }
}
