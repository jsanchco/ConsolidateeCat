namespace eCat.Service.Services
{
    #region Using

    using Data.Entities;
    using Interfaces;
    using System.Collections.Generic;
    using IRepository;
    using Data.Parameters;
    using System;

    #endregion

    public class ServiceTCampanas : IServiceTCampanas
    {
        private bool _disposed;
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

        public object Get_pa_TCampanas(DataCampana dataCampana)
        {
            return _repositoryTCampanas.Get_pa_TCampanas(dataCampana);
        }

        object IServiceTCampanas.Get_pa_TCampanas(int nIdLineaP, int nPagina, int nCantidad, string sFechaInicio)
        {
            return _repositoryTCampanas.Get_pa_TCampanas(nIdLineaP, nPagina, nCantidad, sFechaInicio);
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _repositoryTCampanas.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
