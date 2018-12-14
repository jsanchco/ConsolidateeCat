namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using IRepository;
    using Common;
    using System.Linq;
    using System;
    using System.Data.Entity.Migrations;

    #endregion

    public class RepositoryTGeneroes : RepositoryBase, IRepositoryTGeneroes
    {
        public IEnumerable<TGenero> GetAll()
        {
            return Context.TGeneroes;
        }

        public TGenero Get(byte id)
        {
            return Context.TGeneroes
                .FirstOrDefault(x => x.IdGenero == id);
        }

        public TGenero SaveTGenero(TGenero tGenero)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {
                    Context.TGeneroes.AddOrUpdate(tGenero);
                    Context.SaveChanges();

                    dbContextTransaction.Commit();

                    return tGenero;

                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();

                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool DeleteTGenero(byte id)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var tGeneroFind = Context.TGeneroes.Find(id);
                    if (tGeneroFind == null)
                        return false;

                    Context.TGeneroes.Remove(tGeneroFind);
                    Context.SaveChanges();

                    dbContextTransaction.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();

                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
