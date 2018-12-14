namespace eCat.Service.Services
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Interfaces;

    #endregion

    public class ServiceTGeneroes : IServiceTGeneroes
    {
        private readonly IRepositoryTGeneroes _repositoryTGeneroes;

        #region Constructor

        public ServiceTGeneroes(IRepositoryTGeneroes repositoryTGeneroes)
        {
            _repositoryTGeneroes = repositoryTGeneroes;
        }

        #endregion

        public IEnumerable<TGenero> GetAll()
        {
            return _repositoryTGeneroes.GetAll();
        }

        public TGenero Get(byte id)
        {
            return _repositoryTGeneroes.Get(id);
        }

        public TGenero SaveTGenero(TGenero tGenero)
        {
            return _repositoryTGeneroes.SaveTGenero(tGenero);
        }

        public bool DeleteTGenero(byte id)
        {
            return _repositoryTGeneroes.DeleteTGenero(id);
        }
    }
}
