namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Common;
    using IRepository;
    using System.Linq;
    using System.Data.Entity;

    #endregion

    public class RepositoryFichasBase : RepositoryBase, IRepositoryFichasBase
    {
        public IEnumerable<FichasBase> GetAll()
        {
            return Context.FichasBases;
        }

        public IEnumerable<FichasBase> GetByIdPais(short idPais, bool all = true)
        {
            if (all)
            {
                return Context.FichasBases
                    .Include(x => x.FichasBaseIdiomasSecundarios)
                    .Include(x => x.RelFichasPersonas)
                    .Include(x => x.FichasBaseSoportes)
                    .Include(x => x.E2RamasclasifFicha)
                    .Include(x => x.FichasAplicacions)
                    .Include(x => x.RelFrasesDescriptivas)
                    .Include(x => x.E2FichasBasePremio)
                    .Include(x => x.E2FichasBasePalabrasClave)
                    .Include(x => x.FichasBaseTesauroes)
                    .Include(x => x.FichasBaseCodigoCdus)
                    .Include(x => x.FichasBaseClasificacionEcis)
                    .Include(x => x.TitulosAfines)
                    .Include(x => x.TitulosAnejoes)
                    .Include(x => x.TFichasBaseMaterialesReferencias_IdInterno)
                    .Include(x => x.TFichasBaseMaterialesReferencias_IdInternoReferencia)
                    .Include(x => x.TFichasBaseAmbitosCesions)
                    .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionValores))
                    .Where(x => x.IdPais == idPais);
            }

            return Context.FichasBases
                .Include(x => x.FichasBaseIdiomasSecundarios)
                .Include(x => x.RelFichasPersonas)
                .Include(x => x.FichasBaseSoportes)
                .Include(x => x.E2RamasclasifFicha)
                .Include(x => x.FichasAplicacions)
                .Include(x => x.RelFrasesDescriptivas)
                .Include(x => x.E2FichasBasePremio)
                .Include(x => x.E2FichasBasePalabrasClave)
                .Include(x => x.FichasBaseTesauroes)
                .Include(x => x.FichasBaseCodigoCdus)
                .Include(x => x.FichasBaseClasificacionEcis)
                .Include(x => x.TitulosAfines)
                .Include(x => x.TitulosAnejoes)
                .Include(x => x.TFichasBaseMaterialesReferencias_IdInterno)
                .Include(x => x.TFichasBaseMaterialesReferencias_IdInternoReferencia)
                .Include(x => x.TFichasBaseAmbitosCesions)
                .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionValores))
                .Where(x => x.IdPais == idPais && x.Baja == false);
        }

        public FichasBase Get(string id)
        {
            return Context.FichasBases
                .FirstOrDefault(x => x.IdInterno == id);
        }
    }
}
