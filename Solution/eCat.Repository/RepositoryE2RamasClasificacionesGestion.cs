namespace eCat.Repository
{
    #region Using

    using Data.Entities;
    using IRepository;
    using Common;
    using System.Collections.Generic;
    using System.Data.Entity;

    #endregion

    public class RepositoryE2RamasClasificacionesGestion : RepositoryBase, IRepositoryE2RamasClasificacionesGestion
    {
        public IEnumerable<E2RamasClasificacionesGestion> GetAll()
        {
            return Context.E2RamasClasificacionesGestion
                .Include(x => x.TPropietario)
                .Include(x => x.TMercado)
                .Include(x => x.TNegocio)
                .Include(x => x.TEtapasRangoEdad)
                .Include(x => x.TCategoriasCiclo)
                .Include(x => x.TSubcategoriasMateria);
        }
    }
}
