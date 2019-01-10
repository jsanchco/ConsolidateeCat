// ReSharper disable InconsistentNaming
namespace eCat.IRepository
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using System.Linq;
    using System;
    using Data.Parameters;

    #endregion

    public interface IRepositoryFichasBase : IDisposable
    {
        IEnumerable<FichasBase> GetAll();
        IEnumerable<FichasBase> GetByIdPais(short idPais, bool originalProducts, bool all);
        IQueryable GetByIdPaisQ(short idPais, bool originalProducts, bool all);
        FichasBase Get(string id);
        long pa_InsertFichasBase(
            string idInterno,
            string Titulo,
            int idLineaNegocio,
            int coeditorial,
            int idioma,
            string codLinea_P,
            int idTipoMaterialSAP,
            string codigoGrupo,
            int idProyecto,
            int idProyectoAdicional,
            int idProyectoGestion,
            int idCampaña,
            int idUsoComercial,
            DateTime fechaComerializacion,
            string necesidadInfo,
            int idColeccion,
            int numColeccion,
            int idSerie,
            int numSerie,
            int zGeografica,
            string usuarioCreacion,
            string idInternoOrigen,
            string idInternoOrigenSAP,
            int idPais,
            int porcentajeCoedicion,
            int tipoMaterialEducativo);

        long pa_InsertFichasBase(DataFichasBase dataFichasBase);
    }
}
