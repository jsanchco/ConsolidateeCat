namespace eCat.Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using eCat.Data.Entities;

    #endregion

    public interface IServiceIdiomas
    {
        IEnumerable<Idioma> GetAll();
        Idioma Get(int id);
        Idioma SaveIdioma(Idioma idioma);
        bool DeleteIdioma(int id);
    }
}
