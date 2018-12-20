namespace eCat.IRepository
{
    #region Using

    using Data.Entities;
    using System.Collections.Generic;

    #endregion

    public interface IRepositoryE2RamasClasificacionesGestion
    {
        IEnumerable<E2RamasClasificacionesGestion> GetAll();
    }
}
