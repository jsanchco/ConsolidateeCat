namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IRepositoryTGeneroes
    {
        IEnumerable<TGenero> GetAll();
        TGenero Get(byte id);
        TGenero SaveTGenero(TGenero tGenero);
        bool DeleteTGenero(byte id);
    }
}
