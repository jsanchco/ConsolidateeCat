namespace eCat.Service.Interfaces
{
    #region Using

    using Data.Entities;
    using System.Collections.Generic;
    using Data.Parameters;
    using System;

    #endregion

    public interface IServiceTCampanas : IDisposable
    {
        IEnumerable<TCampañas> Get();
        object Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio);
        object Get_pa_TCampanas(DataCampana dataCampana);
        long pa_Insert_T_Campanas(DataInsertTCampana dataInsertTCampana);
    }
}
