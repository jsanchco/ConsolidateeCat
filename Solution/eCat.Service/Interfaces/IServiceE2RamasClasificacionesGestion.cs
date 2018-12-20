using eCat.Data.Entities;

namespace eCat.Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using IRepository;

    #endregion

    public interface IServiceE2RamasClasificacionesGestion
    {
        IEnumerable<E2RamasClasificacionesGestion> GetAll();
    }
}
