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

    public class RepositoryIdiomas : RepositoryBase, IRepositoryIdiomas
    {
        public IEnumerable<Idioma> GetAll()
        {
            return Context.Idiomas;
        }

        public Idioma Get(int id)
        {
            return Context.Idiomas
                .FirstOrDefault(x => x.IdIdioma == id);
        }

        public Idioma SaveIdioma(Idioma idioma)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {
                    Context.Idiomas.AddOrUpdate(idioma);
                    Context.SaveChanges();

                    dbContextTransaction.Commit();

                    return idioma;

                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();

                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool DeleteIdioma(int id)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var idiomaFind = Context.Idiomas.Find(id);
                    if (idiomaFind == null)
                        return false;

                    Context.Idiomas.Remove(idiomaFind);
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
