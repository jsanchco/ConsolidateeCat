namespace eCat.Service.Interfaces
{
    #region Using

    using eCat.Data.Entities;

    #endregion

    public interface IServiceE2Lineasproductos
    {
        E2Lineasproducto GetByCOD_LineaP(string codLineaP);
    }
}
