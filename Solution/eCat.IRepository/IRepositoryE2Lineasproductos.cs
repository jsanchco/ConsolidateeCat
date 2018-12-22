namespace eCat.IRepository
{
    #region Using

    using Data.Entities;

    #endregion

    public interface IRepositoryE2Lineasproductos
    {
        E2Lineasproducto GetByCOD_LineaP(string codLineaP);
    }
}
