// ReSharper disable InconsistentNaming
namespace eCat.Data.VMEntities
{
    #region Using

    using Entities;

    #endregion
    
    public class VM_PCMFichasBase
    {
        public string Codigo { get; set; }
        public short? Pais { get; set; }
        public byte? LineaDeNegocio { get; set; }
        public string TituloeCat { get; set; }
        public string TituloDistribuidora { get; set; }
        public string Subtitulo { get; set; }
        public int? Coeditorial { get; set; }
        public byte? LenguaPrincipal { get; set; }
        public string LenguasSecundarias { get; set; }
        public string Rol { get; set; }
        public string Persona { get; set; }
        public string Autor { get; set; }
        public byte? EdadMinima { get; set; }
        public byte? ZonaGeografica { get; set; }
        public byte? TipoMaterialEducativo { get; set; }
        public int? Coleccion { get; set; }
        public int? Serie { get; set; }
        public int? N_Coleccion { get; set; }
        public int? N_Serie { get; set; }
        public int? Genero { get; set; }
        public int? DRM { get; set; }
        public int? Accesibilidad { get; set; }
        public string ISBN { get; set; }
        public string EAN13 { get; set; }
        public int? Encuadernacion { get; set; }
        public string Estado { get; set; }
        public int EjemplaresPorCaja { get; set; }
        public short? NumeroDePaginas { get; set; }
        public decimal? Alto { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Grosor { get; set; }
        public decimal? PrecioSinImpuestos { get; set; }
        public decimal? PrecioConImpuestos { get; set; }
        public decimal? Impuestos { get; set; }
        public string Edicion { get; set; }
        public string Fecha { get; set; }
        public string Tirada { get; set; }
        public string DepositoLegal { get; set; }
        public string LineaDeProducto { get; set; }
        public string Soporte { get; set; }

        public VM_PCMFichasBase()
        {

        }

        public VM_PCMFichasBase(FichasBase fichasBase)
        {
            Codigo = fichasBase.IdInterno;
            Pais = fichasBase.IdPais;
            LineaDeNegocio = fichasBase.IdLineaNegocio;
            TituloeCat = fichasBase.Titulo;
            TituloDistribuidora = fichasBase.TituloDistribuidora;
            Subtitulo = fichasBase.Subtitulo;
            Coeditorial = fichasBase.Coeditorial;
            LenguaPrincipal = fichasBase.Idioma;

            // LenguasSecundarias
            foreach (var item in fichasBase.FichasBaseIdiomasSecundarios)
            {
                LenguasSecundarias += $"{item.IdIdioma},";
            }
            if (!string.IsNullOrEmpty(LenguasSecundarias))
                LenguasSecundarias = LenguasSecundarias.Substring(0, LenguasSecundarias.Length - 1);

            // Rol
            foreach (var item in fichasBase.RelFichasPersonas)
            {
                Rol += $"{item.IdRol},";
            }
            if (!string.IsNullOrEmpty(Rol))
                Rol = Rol.Substring(0, Rol.Length - 1);

            // Persona
            foreach (var item in fichasBase.RelFichasPersonas)
            {
                Persona += $"{item.IdPersona},";
            }
            if (!string.IsNullOrEmpty(Persona))
                Persona = Persona.Substring(0, Persona.Length - 1);

            // Autor
            foreach (var item in fichasBase.RelFichasPersonas)
            {
                if (item.IdRol == "AUT")
                    Autor += $"{item.IdPersona},";
            }
            if (!string.IsNullOrEmpty(Autor))
                Autor = Autor.Substring(0, Autor.Length - 1);

            EdadMinima = fichasBase.EdadMinima;
            ZonaGeografica = fichasBase.IdZonaGeografica;
            TipoMaterialEducativo = fichasBase.IdTipoMaterialEducativo;
            Coleccion = fichasBase.IdColeccion;
            Serie = fichasBase.IdSerie;
            N_Coleccion = fichasBase.NumeroColeccion;
            N_Serie = fichasBase.NumeroSerie;
            Genero = fichasBase.IdGenero;
            DRM = fichasBase.IdDrm;
            Accesibilidad = fichasBase.IdAccesibilidad;
            ISBN = fichasBase.Isbn;
            EAN13 = fichasBase.Ean13;
            Encuadernacion = fichasBase.TipoEncuadernacion;
            Estado = fichasBase.IdEstadoSap;
            EjemplaresPorCaja = fichasBase.NEjemplaresCaja;
            NumeroDePaginas = fichasBase.NumeroPaginas;
            Alto = fichasBase.Alto;
            Ancho = fichasBase.Ancho;
            Grosor = fichasBase.Grosor;
            PrecioSinImpuestos = fichasBase.PrecioSinIvae;
            PrecioConImpuestos = fichasBase.PrecioConIvae;
            Impuestos = fichasBase.IvaPorCiento;

            // Edicion
            foreach (var item in fichasBase.E2Tiradasedicion)
            {
                Edicion += $"{item.NumeroEdicion},";
            }
            if (!string.IsNullOrEmpty(Edicion))
                Edicion = Edicion.Substring(0, Edicion.Length - 1);

            // Fecha
            foreach (var item in fichasBase.E2Tiradasedicion)
            {
                if (item.Fecha.HasValue)
                    Edicion += $"{item.Fecha.Value:ddMMyyyy},";
            }
            if (!string.IsNullOrEmpty(Fecha))
                Fecha = Fecha.Substring(0, Fecha.Length - 1);

            // Tirada
            foreach (var item in fichasBase.E2Tiradasedicion)
            {
                Tirada += $"{item.Tirada},";
            }
            if (!string.IsNullOrEmpty(Tirada))
                Tirada = Tirada.Substring(0, Tirada.Length - 1);

            // DepositoLegal
            foreach (var item in fichasBase.E2Tiradasedicion)
            {
                DepositoLegal += $"{item.DepositoLegal},";
            }
            if (!string.IsNullOrEmpty(Tirada))
                DepositoLegal = DepositoLegal.Substring(0, DepositoLegal.Length - 1);

            LineaDeProducto = fichasBase.CodLineaP;

            // Soporte
            foreach (var item in fichasBase.FichasBaseSoportes)
            {
                Soporte += $"{item.IdSoporte},";
            }
            if (!string.IsNullOrEmpty(Soporte))
                Soporte = Soporte.Substring(0, Soporte.Length - 1);

        }

        public string ToCSV()
        {
            var lineCSV = $"{Codigo};";

            lineCSV += $"{Pais};";
            lineCSV += $"{LineaDeNegocio};";
            lineCSV += $"{TituloeCat};";
            lineCSV += $"{TituloDistribuidora};";
            lineCSV += $"{Subtitulo};";
            lineCSV += $"{Coeditorial};";
            lineCSV += $"{LenguaPrincipal};";
            lineCSV += $"{LenguasSecundarias};";
            lineCSV += $"{Rol};";
            lineCSV += $"{Persona};";
            lineCSV += $"{Autor};";
            lineCSV += $"{EdadMinima};";
            lineCSV += $"{ZonaGeografica};";
            lineCSV += $"{TipoMaterialEducativo};";
            lineCSV += $"{Coleccion};";
            lineCSV += $"{Serie};";
            lineCSV += $"{N_Coleccion};";
            lineCSV += $"{N_Serie};";
            lineCSV += $"{Genero};";
            lineCSV += $"{DRM};";
            lineCSV += $"{Accesibilidad};";
            lineCSV += $"{ISBN};";
            lineCSV += $"{EAN13};";
            lineCSV += $"{Encuadernacion};";
            lineCSV += $"{Estado};";
            lineCSV += $"{EjemplaresPorCaja};";
            lineCSV += $"{NumeroDePaginas};";
            lineCSV += $"{Alto};";
            lineCSV += $"{Ancho};";
            lineCSV += $"{Grosor};";
            lineCSV += $"{PrecioSinImpuestos};";
            lineCSV += $"{PrecioConImpuestos};";
            lineCSV += $"{Impuestos};";
            lineCSV += $"{Edicion};";
            lineCSV += $"{Fecha};";
            lineCSV += $"{Tirada};";
            lineCSV += $"{DepositoLegal};";
            lineCSV += $"{LineaDeProducto};";
            lineCSV += $"{Soporte};";

            return lineCSV;
        }
    }
}
