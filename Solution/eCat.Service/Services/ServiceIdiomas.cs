namespace eCat.Service.Services
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Interfaces;

    #endregion

    public class ServiceIdiomas : IServiceIdiomas
    {
        private readonly IRepositoryIdiomas _repositoryIdiomas;

        #region Constructor

        public ServiceIdiomas(IRepositoryIdiomas repositoryIdiomas)
        {
            _repositoryIdiomas = repositoryIdiomas;
        }

        #endregion

        public IEnumerable<Idioma> GetAll()
        {
            return _repositoryIdiomas.GetAll();
        }

        public Idioma Get(int id)
        {
            return _repositoryIdiomas.Get(id);
        }

        public Idioma SaveIdioma(Idioma idioma)
        {
            return _repositoryIdiomas.SaveIdioma(idioma);
        }

        public bool DeleteIdioma(int id)
        {
            return _repositoryIdiomas.DeleteIdioma(id);
        }
    }
}
