namespace eCat.Service.Services
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Interfaces;
    using IRepository;
    using System.Linq;

    #endregion

    public class ServiceFichasBase : IServiceFichasBase
    {
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
    }
}
