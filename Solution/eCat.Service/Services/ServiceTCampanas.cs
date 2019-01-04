namespace eCat.Service.Services
{
    #region Using

    using Data.Entities;
    using Interfaces;
    using System.Collections.Generic;
    using IRepository;

    #endregion

    public class ServiceTCampanas : IServiceTCampanas
    {
        private readonly IRepositoryTCampanas _repositoryTCampanas;

        #region Constructor

        public ServiceTCampanas(IRepositoryTCampanas repositoryTCampanas)
        {
            _repositoryTCampanas = repositoryTCampanas;
        }

        #endregion

        public IEnumerable<TCampañas> Get()
        {
            return _repositoryTCampanas.Get();
        }

        IEnumerable<TCampañas> IServiceTCampanas.Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio)
        {
            return _repositoryTCampanas.Get_pa_TCampanas(nIdLineaP, nPagina, nCantidad, sFechaInicio);
        }
    }
}
