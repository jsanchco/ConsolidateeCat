namespace eCat.Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using System.Linq;

    #endregion

    public interface IServiceFichasBase
    {
        IEnumerable<FichasBase> GetAll();
        IEnumerable<FichasBase> GetByIdPais(short idPais, bool originalProducts, bool all);
        IQueryable GetByIdPaisQ(short idPais, bool originalProducts, bool all);
        FichasBase Get(string id);
    }
}
