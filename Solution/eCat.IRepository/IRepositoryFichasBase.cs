namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using System.Linq;

    #endregion

    public interface IRepositoryFichasBase
    {
        IEnumerable<FichasBase> GetAll();
        IEnumerable<FichasBase> GetByIdPais(short idPais, bool all = true);
        IQueryable GetByIdPaisQ(short idPais, bool all = true);
        FichasBase Get(string id);
    }
}
