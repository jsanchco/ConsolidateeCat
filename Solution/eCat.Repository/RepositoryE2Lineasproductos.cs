namespace eCat.Repository
{
    #region Using

    using Data.Entities;
    using IRepository;
    using Common;
    using System.Linq;

    #endregion

    public class RepositoryE2Lineasproductos : RepositoryBase, IRepositoryE2Lineasproductos
    {
        public E2Lineasproducto GetByCOD_LineaP(string codLineaP)
        {
            return Context.E2Lineasproducto
                .FirstOrDefault(x => x.CodLineaP == codLineaP);
        }
    }
}
