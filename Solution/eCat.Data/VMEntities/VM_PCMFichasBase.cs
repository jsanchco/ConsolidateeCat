// ReSharper disable InconsistentNaming
namespace eCat.Data.VMEntities
{
    #region Using

    using Entities;
    using System;

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
        public short? TipoMaterialSAP { get; set; }
        public string GrupoArticulo { get; set; }
        public byte? UsoComercial { get; set; }
        public short? Campana { get; set; }
        public int? Proyecto { get; set; }
        public int? ProyectoDeGestion { get; set; }
        public string JerarquiaTotal { get; set; }
        public string Sinopsis { get; set; }
        public string Resumen { get; set; }
        public string Indice { get; set; }
        public string FraseDescriptivaEspecial_Ninos { get; set; }
        public string FraseDescriptivaGeneral { get; set; }
        public string FraseDescriptivaEspecial_Chavales { get; set; }
        public string Premio { get; set; }
        public string PremioAno { get; set; }
        public string PremioComentarios { get; set; }
        public string PalabraClave { get; set; }
        public string Valores { get; set; }
        public string ClasificacionCDU { get; set; }
        public string ClasificacionBIC { get; set; }
        public DateTime FechaAltaEnElSistema { get; set; }
        public DateTime? FechaNecesidadDeInformacion { get; set; }
        public DateTime? FechaCreacionProyectoPS { get; set; }
        public DateTime? FechaRecepcionDePrototipos { get; set; }
        public DateTime? FechaPuestaEnMarchaDeFabricacion { get; set; }
        public DateTime? FechaFinProcesoInteriores { get; set; }
        public DateTime? FechaAltaEnLogistica { get; set; }
        public DateTime? FechaComercializacion { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public string UsuarioDeCreacion { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
        public string UsuarioDeModificacion { get; set; }
        public DateTime? FechaDePublicacion { get; set; }
        public string UsuarioDePublicacion { get; set; }
        public DateTime? FechaDeDespublicacion { get; set; }
        public string UsuarioDeDespublicacion { get; set; }
        public DateTime? FechaLibroDisponibleEnWeb { get; set; }
        public DateTime? FechaLibroDisponibleEnDILVE { get; set; }
        public string TituloOriginal { get; set; }
        public string EditorialOriginal { get; set; }
        public byte? IdiomaOriginal { get; set; }
        public string TitulosAfines { get; set; }
        public string MaterialesAnejos { get; set; }
        public string MaterialesReferencia { get; set; }
        public string MaterialesAuxiliares { get; set; }
        public string MaterialesAuxiliaresTipoDeDocumento { get; set; }
        public string FechaContrato { get; set; }
        public string EstadoAmbitos { get; set; }
        public string TerritoriosVenta { get; set; }
        public string TerritoriosExcluidos { get; set; }
        public string RestriccionesVenta { get; set; }
        public string DisponibleVentaDerechos { get; set; }
        public string Restrictivo { get; set; }
        public string ComentariosInternos { get; set; }
        public string MasInformacion { get; set; }

        public int? MarcaPublicado { get; set; }

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

            TipoMaterialSAP = fichasBase.IdTipoMaterialSap;
            GrupoArticulo = fichasBase.CodigoGrupo;
            UsoComercial = fichasBase.IdUsoComercial;
            Campana = fichasBase.IdCampaña;
            Proyecto = fichasBase.IdProyecto;
            ProyectoDeGestion = fichasBase.IdProyectoGestion;

            // JerarquiaTotal
            foreach (var item in fichasBase.E2RamasclasifFicha)
            {
                JerarquiaTotal += $"{item.IdClasificacion},";
            }
            if (!string.IsNullOrEmpty(JerarquiaTotal))
                JerarquiaTotal = JerarquiaTotal.Substring(0, JerarquiaTotal.Length - 1);

            // Sinopsis
            foreach (var item in fichasBase.FichasAplicacions)
            {
                Sinopsis += $"{item.Sinopsis},";
            }
            if (!string.IsNullOrEmpty(Sinopsis))
                Sinopsis = Sinopsis.Substring(0, Sinopsis.Length - 1);

            // Resumen
            foreach (var item in fichasBase.FichasAplicacions)
            {
                Resumen += $"{item.Resumen},";
            }
            if (!string.IsNullOrEmpty(Resumen))
                Resumen = Resumen.Substring(0, Resumen.Length - 1);

            // Indice
            foreach (var item in fichasBase.FichasAplicacions)
            {
                Indice += $"{item.Indice},";
            }
            if (!string.IsNullOrEmpty(Indice))
                Indice = Indice.Substring(0, Indice.Length - 1);

            // FraseDescriptivaEspecial_Ninos
            foreach (var item in fichasBase.RelFrasesDescriptivas)
            {
                if (item.IdPublicoObjetivo == 0)
                    FraseDescriptivaEspecial_Ninos += $"{item.FraseDescriptiva},";
            }
            if (!string.IsNullOrEmpty(FraseDescriptivaEspecial_Ninos))
                FraseDescriptivaEspecial_Ninos = FraseDescriptivaEspecial_Ninos.Substring(0, FraseDescriptivaEspecial_Ninos.Length - 1);

            // FraseDescriptivaGeneral
            foreach (var item in fichasBase.RelFrasesDescriptivas)
            {
                if (item.IdPublicoObjetivo == 1)
                    FraseDescriptivaGeneral += $"{item.FraseDescriptiva},";
            }
            if (!string.IsNullOrEmpty(FraseDescriptivaGeneral))
                FraseDescriptivaGeneral = FraseDescriptivaGeneral.Substring(0, FraseDescriptivaGeneral.Length - 1);

            // FraseDescriptivaEspecial_Chavales
            foreach (var item in fichasBase.RelFrasesDescriptivas)
            {
                if (item.IdPublicoObjetivo == 3)
                    FraseDescriptivaEspecial_Chavales += $"{item.FraseDescriptiva},";
            }
            if (!string.IsNullOrEmpty(FraseDescriptivaEspecial_Chavales))
                FraseDescriptivaEspecial_Chavales = FraseDescriptivaEspecial_Chavales.Substring(0, FraseDescriptivaEspecial_Chavales.Length - 1);

            // Premio
            foreach (var item in fichasBase.E2FichasBasePremio)
            {
                Premio += $"{item.IdPremio},";
            }
            if (!string.IsNullOrEmpty(Premio))
                Premio = Premio.Substring(0, Premio.Length - 1);

            // PremioAno
            foreach (var item in fichasBase.E2FichasBasePremio)
            {
                PremioAno += $"{item.Anyo},";
            }
            if (!string.IsNullOrEmpty(PremioAno))
                PremioAno = PremioAno.Substring(0, PremioAno.Length - 1);

            // PremioComentarios
            foreach (var item in fichasBase.E2FichasBasePremio)
            {
                PremioComentarios += $"{item.Comentarios},";
            }
            if (!string.IsNullOrEmpty(PremioComentarios))
                PremioComentarios = PremioComentarios.Substring(0, PremioComentarios.Length - 1);

            // PalabraClave
            foreach (var item in fichasBase.E2FichasBasePalabrasClave)
            {
                PalabraClave += $"{item.IdPalabra},";
            }
            if (!string.IsNullOrEmpty(PalabraClave))
                PalabraClave = PalabraClave.Substring(0, PalabraClave.Length - 1);

            // Valores
            foreach (var item in fichasBase.FichasBaseTesauroes)
            {
                Valores += $"{item.IdTesauroLibro},";
            }
            if (!string.IsNullOrEmpty(Valores))
                Valores = Valores.Substring(0, Valores.Length - 1);

            // ClasificacionCDU
            foreach (var item in fichasBase.FichasBaseCodigoCdus)
            {
                ClasificacionCDU += $"{item.IdCodigoCdu},";
            }
            if (!string.IsNullOrEmpty(ClasificacionCDU))
                ClasificacionCDU = ClasificacionCDU.Substring(0, ClasificacionCDU.Length - 1);

            // ClasificacionBIC
            foreach (var item in fichasBase.FichasBaseClasificacionEcis)
            {
                ClasificacionBIC += $"{item.IdcLasificacionEci},";
            }
            if (!string.IsNullOrEmpty(ClasificacionBIC))
                ClasificacionBIC = ClasificacionBIC.Substring(0, ClasificacionBIC.Length - 1);

            FechaAltaEnElSistema = fichasBase.FechaCreacion;
            FechaNecesidadDeInformacion = fichasBase.FechaNecesidadInformacion;
            FechaCreacionProyectoPS = fichasBase.FechaCreacionProyectoPs;
            FechaRecepcionDePrototipos = fichasBase.FechaRecepcionPrototipos;
            FechaPuestaEnMarchaDeFabricacion = fichasBase.FechaPuestaEnMarchaFabricacion;
            FechaFinProcesoInteriores = fichasBase.FechaFinProcesadoInteriores;
            FechaAltaEnLogistica = fichasBase.FechaAltaLogistica;
            FechaComercializacion = fichasBase.FechaDisponibilidadComercial;
            FechaDeCreacion = fichasBase.FechaCreacion;
            UsuarioDeCreacion = fichasBase.UsuarioCreacion;
            FechaDeModificacion = fichasBase.FechaActualizacion;
            UsuarioDeModificacion = fichasBase.UsuarioActualizacion;
            FechaDePublicacion = fichasBase.FechaPublicacion;
            UsuarioDePublicacion = fichasBase.UsuarioPublicacion;
            FechaDeDespublicacion = fichasBase.FechaRetirada;
            UsuarioDeDespublicacion = fichasBase.UsuarioRetirada;
            FechaLibroDisponibleEnWeb = fichasBase.FechaPublicacion;
            FechaLibroDisponibleEnDILVE = fichasBase.FechaCreacionDilve;
            TituloOriginal = fichasBase.TituloOriginal;
            EditorialOriginal = fichasBase.EditorialOriginal;
            IdiomaOriginal = fichasBase.IdiomaOriginal;

            // TitulosAfines
            foreach (var item in fichasBase.TitulosAfines)
            {
                TitulosAfines += $"{item.IdTipoTituloAfin},";
            }
            if (!string.IsNullOrEmpty(TitulosAfines))
                TitulosAfines = TitulosAfines.Substring(0, TitulosAfines.Length - 1);

            // MaterialesAnejos
            foreach (var item in fichasBase.TitulosAnejoes)
            {
                MaterialesAnejos += $"{item.IdObraAneja},";
            }
            if (!string.IsNullOrEmpty(MaterialesAnejos))
                MaterialesAnejos = MaterialesAnejos.Substring(0, MaterialesAnejos.Length - 1);

            // MaterialesReferencia
            foreach (var item in fichasBase.TFichasBaseMaterialesReferencias_IdInternoReferencia)
            {
                MaterialesReferencia += $"{item.IdInternoReferencia},";
            }
            if (!string.IsNullOrEmpty(MaterialesReferencia))
                MaterialesReferencia = MaterialesReferencia.Substring(0, MaterialesReferencia.Length - 1);

            // MaterialesAuxiliares
            // MaterialesAuxiliaresTipoDeDocumento

            // FechaContrato
            // DisponibleVentaDerechos
            // Restrictivo
            // MasInformacion
            foreach (var item in fichasBase.TFichasBaseAmbitosCesions)
            {
                FechaContrato += $"{item.Fecha:ddMMyyyy},";
                DisponibleVentaDerechos += $"{Convert.ToInt16(item.DisponibleVentaDerechos)},";
                Restrictivo += $"{Convert.ToInt16(item.EsRestrictivo)},";
                ComentariosInternos += $"{item.ComentariosInternos},";
                MasInformacion += $"{item.MasInformacion},";

                //ValoresExclusivosPaises
                foreach (var valor in item.TFichasBaseAmbitosCesionValores)
                {
                    TerritoriosVenta += $"{valor.IdAmbitoCesion},";
                }                
            }
            if (!string.IsNullOrEmpty(FechaContrato))
                FechaContrato = FechaContrato.Substring(0, FechaContrato.Length - 1);
            if (!string.IsNullOrEmpty(DisponibleVentaDerechos))
                DisponibleVentaDerechos = DisponibleVentaDerechos.Substring(0, DisponibleVentaDerechos.Length - 1);
            if (!string.IsNullOrEmpty(TerritoriosVenta))
                TerritoriosVenta = TerritoriosVenta.Substring(0, TerritoriosVenta.Length - 1);

            // EstadoAmbitos
            foreach (var item in fichasBase.TFichasBaseAmbitosCesions)
            {
                EstadoAmbitos += $"{item.IdEstado},";
            }
            if (!string.IsNullOrEmpty(EstadoAmbitos))
                EstadoAmbitos = EstadoAmbitos.Substring(0, EstadoAmbitos.Length - 1);

            // RestriccionesVenta

            // MarcaPublicado
            MarcaPublicado = fichasBase.PublicableWeb;

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
            lineCSV += $"{TipoMaterialSAP};";
            lineCSV += $"{GrupoArticulo};";
            lineCSV += $"{UsoComercial};";
            lineCSV += $"{Campana};";
            lineCSV += $"{Proyecto};";
            lineCSV += $"{ProyectoDeGestion};";
            lineCSV += $"{JerarquiaTotal};";
            lineCSV += $"{Sinopsis};";
            lineCSV += $"{Resumen};";
            lineCSV += $"{Indice};";
            lineCSV += $"{FraseDescriptivaEspecial_Ninos};";
            lineCSV += $"{FraseDescriptivaGeneral};";
            lineCSV += $"{FraseDescriptivaEspecial_Chavales};";
            lineCSV += $"{Premio};";
            lineCSV += $"{PremioAno};";
            lineCSV += $"{PremioComentarios};";
            lineCSV += $"{PalabraClave};";
            lineCSV += $"{Valores};";
            lineCSV += $"{ClasificacionCDU};";
            lineCSV += $"{ClasificacionBIC};";
            lineCSV += $"{FechaAltaEnElSistema:ddMMyyyy};";
            lineCSV += $"{FechaNecesidadDeInformacion:ddMMyyyy};";
            lineCSV += $"{FechaCreacionProyectoPS:ddMMyyyy};";
            lineCSV += $"{FechaRecepcionDePrototipos:ddMMyyyy};";
            lineCSV += $"{FechaPuestaEnMarchaDeFabricacion:ddMMyyyy};";
            lineCSV += $"{FechaFinProcesoInteriores:ddMMyyyy};";
            lineCSV += $"{FechaAltaEnLogistica:ddMMyyyy};";
            lineCSV += $"{FechaDeCreacion:ddMMyyyy};";
            lineCSV += $"{UsuarioDeCreacion};";
            lineCSV += $"{FechaDeModificacion:ddMMyyyy};";
            lineCSV += $"{UsuarioDeModificacion};";
            lineCSV += $"{FechaDeModificacion:ddMMyyyy};";
            lineCSV += $"{UsuarioDePublicacion};";
            lineCSV += $"{FechaDeDespublicacion:ddMMyyyy};";
            lineCSV += $"{UsuarioDeDespublicacion};";
            lineCSV += $"{FechaLibroDisponibleEnWeb:ddMMyyyy};";
            lineCSV += $"{FechaLibroDisponibleEnDILVE:ddMMyyyy};";
            lineCSV += $"{TituloOriginal};";
            lineCSV += $"{EditorialOriginal};";
            lineCSV += $"{IdiomaOriginal};";
            lineCSV += $"{TitulosAfines};";
            lineCSV += $"{MaterialesAnejos};";
            lineCSV += $"{MaterialesReferencia};";
            lineCSV += $"{MaterialesAuxiliares};";
            lineCSV += $"{MaterialesAuxiliaresTipoDeDocumento};";
            lineCSV += $"{FechaContrato};";
            lineCSV += $"{EstadoAmbitos};";
            lineCSV += $"{TerritoriosVenta};";
            lineCSV += $"{TerritoriosExcluidos};";
            lineCSV += $"{RestriccionesVenta};";
            lineCSV += $"{DisponibleVentaDerechos};";
            lineCSV += $"{Restrictivo};";
            lineCSV += $"{ComentariosInternos};";
            lineCSV += $"{MasInformacion};";

            lineCSV += $"{MarcaPublicado};";

            return lineCSV;
        }
    }
}
