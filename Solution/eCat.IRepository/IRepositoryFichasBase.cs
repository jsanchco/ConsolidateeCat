namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using eCat.Data.Entities;

    #endregion

    public interface IRepositoryFichasBase
    {
        IEnumerable<FichasBase> GetAll();
        IEnumerable<FichasBase> GetByIdPais(short idPais, bool all = true);
        FichasBase Get(string id);
    }
}
