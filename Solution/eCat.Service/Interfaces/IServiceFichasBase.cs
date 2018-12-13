namespace eCat.Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IServiceFichasBase
    {
        IEnumerable<FichasBase> GetAll();
        IEnumerable<FichasBase> GetByIdPais(short idPais, bool all = true);
        FichasBase Get(string id);
    }
}
