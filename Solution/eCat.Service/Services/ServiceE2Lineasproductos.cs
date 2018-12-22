namespace eCat.Service.Services
{
    #region Using

    using Data.Entities;
    using Interfaces;
    using IRepository;

    #endregion

    public class ServiceE2Lineasproductos : IServiceE2Lineasproductos
    {
        private readonly IRepositoryE2Lineasproductos _repositoryE2Lineasproductos;

        #region Constructor

        public ServiceE2Lineasproductos(IRepositoryE2Lineasproductos repositoryE2Lineasproductos)
        {
            _repositoryE2Lineasproductos = repositoryE2Lineasproductos;
        }

        #endregion

        public E2Lineasproducto GetByCOD_LineaP(string codLineaP)
        {
            return _repositoryE2Lineasproductos.GetByCOD_LineaP(codLineaP);
        }
    }
}
