namespace eCat.Service.Interfaces
{
    #region Using

    using Data.Entities;
    using System.Collections.Generic;

    #endregion

    public interface IServiceTCampanas
    {
        IEnumerable<TCampañas> Get();
        IEnumerable<TCampañas> Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio);
    }
}
