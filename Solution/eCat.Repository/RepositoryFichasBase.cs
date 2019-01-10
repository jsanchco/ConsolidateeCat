// ReSharper disable InconsistentNaming
namespace eCat.Repository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Common;
    using IRepository;
    using System.Linq;
    using System.Data.Entity;
    using System;
    using System.Data.SqlClient;
    using Data.Parameters;
    using System.Reflection;
    using eCat.Data.Common;

    #endregion

    public class RepositoryFichasBase : RepositoryBase, IRepositoryFichasBase
    {        
        public IEnumerable<FichasBase> GetAll()
        {
            return Context.FichasBases;
        }

        public IEnumerable<FichasBase> GetByIdPais(short idPais, bool originalProducts, bool all)
        {
            IEnumerable<FichasBase> fichasBase;
            if (all)
            {
                fichasBase = Context.FichasBases
                    .Include(x => x.E2GruposArticulo)
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
                    .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionRestricciones))
                    .Include(x => x.Documentoes)
                    .Where(x => x.IdPais == idPais);

                if (originalProducts)
                {
                    fichasBase = fichasBase.Where(x => x.IdInternoOrigen == null);
                }

                return fichasBase;
            }

            fichasBase = Context.FichasBases
                .Include(x => x.E2GruposArticulo)
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
                .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionRestricciones))
                .Include(x => x.TFichasBaseAmbitosCesions)
                .Include(x => x.Documentoes)
                .Where(x => x.IdPais == idPais && x.Baja == false);

            if (originalProducts)
            {
                fichasBase = fichasBase.Where(x => x.IdInternoOrigen == null);
            }

            return fichasBase;
        }

        public IQueryable GetByIdPaisQ(short idPais, bool originalProducts, bool all)
        {
            IQueryable<FichasBase> fichasBase;

            if (all)
            {
                fichasBase = Context.FichasBases
                    .Include(x => x.E2GruposArticulo)
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
                    .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionRestricciones))
                    .Include(x => x.Documentoes)
                    .Where(x => x.IdPais == idPais);

                if (originalProducts)
                {
                    fichasBase = fichasBase.Where(x => x.IdInternoOrigen == null);
                }

                return fichasBase;
            }

            fichasBase = Context.FichasBases
                .Include(x => x.E2GruposArticulo)
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
                .Include(x => x.TFichasBaseAmbitosCesions.Select(y => y.TFichasBaseAmbitosCesionRestricciones))
                .Include(x => x.TFichasBaseAmbitosCesions)
                .Include(x => x.Documentoes)
                .Where(x => x.IdPais == idPais && x.Baja == false);

            if (originalProducts)
            {
                fichasBase = fichasBase.Where(x => x.IdInternoOrigen == null);
            }

            return fichasBase;
        }

        public FichasBase Get(string id)
        {
            return Context.FichasBases
                .FirstOrDefault(x => x.IdInterno == id);
        }

        public long pa_InsertFichasBase(string idInterno, string Titulo, int idLineaNegocio, int coeditorial, int idioma,
            string codLinea_P, int idTipoMaterialSAP, string codigoGrupo, int idProyecto, int idProyectoAdicional,
            int idProyectoGestion, int idCampaña, int idUsoComercial, DateTime fechaComerializacion,
            string necesidadInfo,
            int idColeccion, int numColeccion, int idSerie, int numSerie, int zGeografica, string usuarioCreacion,
            string idInternoOrigen, string idInternoOrigenSAP, int idPais, int porcentajeCoedicion,
            int tipoMaterialEducativo)
        {
            throw new NotImplementedException();
        }

        public long pa_InsertFichasBase(DataFichasBase dataFichasBase)
        {
            var resultStoreProcedure = new ResultStoreProcedure(MethodBase.GetCurrentMethod(), dataFichasBase.ToUri());

            try
            {
                var result = Context.Database.SqlQuery<long>("exec dbo.[pa_InsertFichasBase] " +
                                                            "@sIdInterno, " +
                                                            "@nsTitulo, " +
                                                            "@nIdLineaNegocio, " +
                                                            "@nCoeditorial, " +
                                                            "@nIdioma, " +
                                                            "@sCodLinea_P, " +
                                                            "@nIdTipoMaterialSAP, " +
                                                            "@sCodigoGrupo, " +
                                                            "@nIdProyecto, " +
                                                            "@nIdProyectoAdicional, " +
                                                            "@nIdProyectoGestion, " +
                                                            "@nIdCampaña, " +
                                                            "@nIdUsoComercial, " +
                                                            "@dtFechaComerializacion, " +
                                                            "@dtNecesidadInfo, " +
                                                            "@nIdColeccion, " +
                                                            "@nNumColeccion, " +
                                                            "@nIdSerie, " +
                                                            "@nNumSerie, " +
                                                            "@nZGeografica, " +
                                                            "@nsUsuarioCreacion, " +
                                                            "@sIdInternoOrigen, " +
                                                            "@sIdInternoOrigenSAP, " +
                                                            "@iIdPais, " +
                                                            "@nPorcentajeCoedicion, " +
                                                            "@nTipoMaterialEducativo",
                    new SqlParameter("@sIdInterno", dataFichasBase.IdInterno),
                    new SqlParameter("@nsTitulo", dataFichasBase.Titulo),
                    new SqlParameter("@nIdLineaNegocio", dataFichasBase.IdLineaNegocio),
                    new SqlParameter("@nCoeditorial", dataFichasBase.Coeditorial ?? (object)DBNull.Value),
                    new SqlParameter("@nIdioma", dataFichasBase.Idioma),
                    new SqlParameter("@sCodLinea_P", dataFichasBase.CodLinea_P),
                    new SqlParameter("@nIdTipoMaterialSAP", dataFichasBase.IdTipoMaterialSAP),
                    new SqlParameter("@sCodigoGrupo", dataFichasBase.CodigoGrupo),
                    new SqlParameter("@nIdProyecto", dataFichasBase.IdProyecto ?? (object)DBNull.Value),
                    new SqlParameter("@nIdProyectoAdicional", dataFichasBase.IdProyectoAdicional ?? (object)DBNull.Value),
                    new SqlParameter("@nIdProyectoGestion", dataFichasBase.IdProyectoGestion ?? (object)DBNull.Value),
                    new SqlParameter("@nIdCampaña", dataFichasBase.IdCampana),
                    new SqlParameter("@nIdUsoComercial", dataFichasBase.IdUsoComercial ?? (object)DBNull.Value),
                    new SqlParameter("@dtFechaComerializacion", dataFichasBase.FechaComerializacion),
                    new SqlParameter("@dtNecesidadInfo", dataFichasBase.NecesidadInfo ?? string.Empty),
                    new SqlParameter("@nIdColeccion", dataFichasBase.IdColeccion ?? (object)DBNull.Value),
                    new SqlParameter("@nNumColeccion", dataFichasBase.NumColeccion),
                    new SqlParameter("@nIdSerie", dataFichasBase.IdSerie ?? (object)DBNull.Value),
                    new SqlParameter("@nNumSerie", dataFichasBase.NumSerie),
                    new SqlParameter("@nZGeografica", dataFichasBase.ZGeografica ?? (object)DBNull.Value),
                    new SqlParameter("@nsUsuarioCreacion", dataFichasBase.UsuarioCreacion),
                    new SqlParameter("@sIdInternoOrigen", dataFichasBase.IdInternoOrigen ?? string.Empty),
                    new SqlParameter("@sIdInternoOrigenSAP", dataFichasBase.IdInternoOrigenSAP ?? string.Empty),
                    new SqlParameter("@iIdPais", dataFichasBase.IdPais),
                    new SqlParameter("@nPorcentajeCoedicion", dataFichasBase.PorcentajeCoedicion ?? (object)DBNull.Value),
                    new SqlParameter("@nTipoMaterialEducativo", dataFichasBase.TipoMaterialEducativo ?? (object)DBNull.Value));

                var code = result.Single();
                resultStoreProcedure.Code = code;

                resultStoreProcedure.Status = code == 1 ? Status.Ok : Status.Error;

                return code;
            }
            catch (Exception e)
            {
                resultStoreProcedure.Status = Status.Exception;
                resultStoreProcedure.Description = e.Message;

                throw;
            }
            finally
            {
                var fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\log.txt";
                using (var sw = new System.IO.StreamWriter(fileName, true))
                {
                    sw.WriteLine(resultStoreProcedure.ToString());
                }
            }
        }
    }
}
