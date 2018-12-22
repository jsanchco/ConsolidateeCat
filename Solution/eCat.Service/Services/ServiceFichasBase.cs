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

        public IEnumerable<FichasBase> GetByIdPais(short idPais, bool all = true)
        {
            return _repositoryFichasBase.GetByIdPais(idPais, all);
        }

        public IQueryable GetByIdPaisQ(short idPais, bool all = true)
        {
            return _repositoryFichasBase.GetByIdPaisQ(idPais, all);
        }

        public FichasBase Get(string id)
        {
            return _repositoryFichasBase.Get(id);
        }
    }
}
