namespace eCat.Service.Services
{
    #region Using

    using Interfaces;
    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;

    #endregion

    public class ServiceE2RamasClasificacionesGestion : IServiceE2RamasClasificacionesGestion
    {
        private readonly IRepositoryE2RamasClasificacionesGestion _repositoryE2RamasClasificacionesGestion;

        #region Constructor

        public ServiceE2RamasClasificacionesGestion(IRepositoryE2RamasClasificacionesGestion repositoryE2RamasClasificacionesGestion)
        {
            _repositoryE2RamasClasificacionesGestion = repositoryE2RamasClasificacionesGestion;
        }

        #endregion

        public IEnumerable<E2RamasClasificacionesGestion> GetAll()
        {
            return _repositoryE2RamasClasificacionesGestion.GetAll();
        }
    }
}
