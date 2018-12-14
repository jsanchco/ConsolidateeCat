namespace eCat.Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IServiceTGeneroes
    {
        IEnumerable<TGenero> GetAll();
        TGenero Get(byte id);
        TGenero SaveTGenero(TGenero tGenero);
        bool DeleteTGenero(byte id);
    }
}
