// ReSharper disable InconsistentNaming
namespace eCat.Data.Parameters
{
    #region Using

    using System;
    using System.Web;

    #endregion

    public class DataFichasBase : IData
    {
        public string IdInterno { get; set; }
        public string Titulo { get; set; }
        public int IdLineaNegocio { get; set; }
        public int? Coeditorial { get; set; }
        public int? PorcentajeCoedicion { get; set; }
        public int Idioma { get; set; }
        public string CodLinea_P { get; set; }
        public int IdTipoMaterialSAP { get; set; }
        public string CodigoGrupo { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdProyectoAdicional { get; set; }
        public int? IdProyectoGestion { get; set; }
        public int IdCampana { get; set; }
        public int? IdUsoComercial { get; set; }
        public DateTime FechaComerializacion { get; set; }
        public string NecesidadInfo { get; set; }
        public int? IdColeccion { get; set; }
        public int NumColeccion { get; set; }
        public int? IdSerie { get; set; }
        public int NumSerie { get; set; }
        public int? ZGeografica { get; set; }
        public string UsuarioCreacion { get; set; }
        public string IdInternoOrigen { get; set; }
        public string IdInternoOrigenSAP { get; set; }
        public int IdPais { get; set; }        
        public int? TipoMaterialEducativo { get; set; }

        public string ToUri()
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["IdInterno"] = IdInterno;
            query["Titulo"] = Titulo;
            query["IdLineaNegocio"] = IdLineaNegocio.ToString();
            query["Coeditorial"] = Coeditorial?.ToString();
            query["Idioma"] = Idioma.ToString();
            query["CodLinea_P"] = CodLinea_P;
            query["IdTipoMaterialSAP"] = IdTipoMaterialSAP.ToString();
            query["CodigoGrupo"] = CodigoGrupo;
            query["IdProyecto"] = IdProyecto?.ToString();
            query["IdProyectoAdicional"] = IdProyectoAdicional?.ToString();
            query["IdProyectoGestion"] = IdProyectoGestion?.ToString();
            query["IdCampana"] = IdCampana.ToString();
            query["IdUsoComercial"] = IdUsoComercial?.ToString();
            query["FechaComerializacion"] = FechaComerializacion.ToString("yyyy-MM-dd");
            query["NecesidadInfo"] = NecesidadInfo;
            query["IdColeccion"] = IdColeccion?.ToString();
            query["IdSerie"] = IdSerie?.ToString();
            query["ZGeografica"] = ZGeografica?.ToString();
            query["UsuarioCreacion"] = UsuarioCreacion;
            query["IdInternoOrigen"] = IdInternoOrigen;
            query["IdInternoOrigenSAP"] = IdInternoOrigenSAP;
            query["IdPais"] = IdPais.ToString();
            query["PorcentajeCoedicion"] = PorcentajeCoedicion?.ToString();
            query["TipoMaterialEducativo"] = TipoMaterialEducativo?.ToString();

            return query.ToString();
        }
    }
}
