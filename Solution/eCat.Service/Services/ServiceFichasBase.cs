namespace eCat.Service.Services
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Interfaces;
    using IRepository;
    using System.Linq;
    using Data.Parameters;
    using System;

    #endregion

    public class ServiceFichasBase : IServiceFichasBase
    {
        private bool _disposed;
        private readonly IRepositoryFichasBase _repositoryFichasBase;

        #region Constructor

        public ServiceFichasBase(IRepositoryFichasBase repositoryFichasBase)
        {
            _repositoryFichasBase = repositoryFichasBase;
        }

        #endregion

        public IEnumerable<FichasBase> GetAll()
        {
            return _repositoryFichasBase.GetAll();
        }

        public IEnumerable<FichasBase> GetByIdPais(short idPais, bool originalProducts, bool all)
        {
            return _repositoryFichasBase.GetByIdPais(idPais, originalProducts, all);
        }

        public IQueryable GetByIdPaisQ(short idPais, bool originalProducts, bool all)
        {
            return _repositoryFichasBase.GetByIdPaisQ(idPais, originalProducts, all);
        }

        public FichasBase Get(string id)
        {
            return _repositoryFichasBase.Get(id);
        }

        public long pa_InsertFichasBase(DataFichasBase dataFichasBase)
        {
            return _repositoryFichasBase.pa_InsertFichasBase(dataFichasBase);
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _repositoryFichasBase.Dispose();
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
