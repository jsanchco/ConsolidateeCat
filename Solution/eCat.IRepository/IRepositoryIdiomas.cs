namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IRepositoryIdiomas
    {
        IEnumerable<Idioma> GetAll();
        Idioma Get(int id);
        Idioma SaveIdioma(Idioma idioma);
        bool DeleteIdioma(int id);
    }
}
