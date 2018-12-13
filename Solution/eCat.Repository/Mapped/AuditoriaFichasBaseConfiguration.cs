namespace eCat.Repository.Mapped
{
    public class AuditoriaFichasBaseConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.AuditoriaFichasBase>
    {
        public AuditoriaFichasBaseConfiguration()
            : this("dbo")
        {
        }

        public AuditoriaFichasBaseConfiguration(string schema)
        {
            ToTable("Auditoria_FichasBase", schema);
            HasKey(x => x.IdAuditoriaFichasBase);

            Property(x => x.IdAuditoriaFichasBase).HasColumnName(@"IdAuditoriaFichasBase").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FechaAuditoria).HasColumnName(@"FechaAuditoria").HasColumnType("datetime").IsRequired();
            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Isbn).HasColumnName(@"ISBN").HasColumnType("nvarchar").IsOptional().HasMaxLength(13);
            Property(x => x.Ean13).HasColumnName(@"EAN13").HasColumnType("nvarchar").IsOptional().HasMaxLength(13);
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Subtitulo).HasColumnName(@"Subtitulo").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Numero).HasColumnName(@"Numero").HasColumnType("smallint").IsOptional();
            Property(x => x.Idioma).HasColumnName(@"Idioma").HasColumnType("tinyint").IsOptional();
            Property(x => x.Coeditorial).HasColumnName(@"Coeditorial").HasColumnType("int").IsOptional();
            Property(x => x.Ancho).HasColumnName(@"Ancho").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.Alto).HasColumnName(@"Alto").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.Grosor).HasColumnName(@"Grosor").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.Peso).HasColumnName(@"Peso").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.NumeroPaginas).HasColumnName(@"NumeroPaginas").HasColumnType("smallint").IsOptional();
            Property(x => x.TipoEncuadernacion).HasColumnName(@"TipoEncuadernacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdTipoArticulo).HasColumnName(@"IDTipoArticulo").HasColumnType("tinyint").IsOptional();
            Property(x => x.PrecioSinIvae).HasColumnName(@"PrecioSinIVAE").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.PrecioConIvae).HasColumnName(@"PrecioConIVAE").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.EditorialOriginal).HasColumnName(@"EditorialOriginal").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TituloOriginal).HasColumnName(@"TituloOriginal").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdiomaOriginal).HasColumnName(@"IdiomaOriginal").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdEstadoSap).HasColumnName(@"IDEstadoSAP").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.PublicableWeb).HasColumnName(@"PublicableWeb").HasColumnType("int").IsOptional();
            Property(x => x.EdadMinima).HasColumnName(@"EdadMinima").HasColumnType("tinyint").IsOptional();
            Property(x => x.EdadMaxima).HasColumnName(@"EdadMaxima").HasColumnType("tinyint").IsOptional();
            Property(x => x.CodLineaP).HasColumnName(@"COD_LineaP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.PvpsSivaTnac).HasColumnName(@"PVPS_SIVA_TNAC").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.PvpsCivaTnac).HasColumnName(@"PVPS_CIVA_TNAC").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.PvpsSivaTextra).HasColumnName(@"PVPS_SIVA_TEXTRA").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.IvaPorCiento).HasColumnName(@"IvaPorCiento").HasColumnType("decimal").IsOptional().HasPrecision(24,2);
            Property(x => x.CodPais).HasColumnName(@"COD_PAIS").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaActualizacion).HasColumnName(@"FechaActualizacion").HasColumnType("datetime").IsOptional();
            Property(x => x.IdPropietarioSubmateria).HasColumnName(@"IDPropietarioSubmateria").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.UrlEditor).HasColumnName(@"URL_EDITOR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CodAudi).HasColumnName(@"COD_AUDI").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.CodNivel).HasColumnName(@"COD_NIVEL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.CodCaut).HasColumnName(@"COD_CAUT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.UsuarioActualizacion).HasColumnName(@"UsuarioActualizacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SoloIlustracion).HasColumnName(@"SoloIlustracion").HasColumnType("bit").IsOptional();
            Property(x => x.UsuarioPublicacion).HasColumnName(@"UsuarioPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaPublicacion).HasColumnName(@"FechaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioUltimaPublicacion).HasColumnName(@"UsuarioUltimaPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaUltimaPublicacion).HasColumnName(@"FechaUltimaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioRetirada).HasColumnName(@"UsuarioRetirada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaRetirada).HasColumnName(@"FechaRetirada").HasColumnType("datetime").IsOptional();
            Property(x => x.NEjemplaresCaja).HasColumnName(@"NEjemplaresCaja").HasColumnType("int").IsOptional();
            Property(x => x.FechaAltaLogistica).HasColumnName(@"FechaAltaLogistica").HasColumnType("datetime").IsOptional();
            Property(x => x.CodigoGrupo).HasColumnName(@"CodigoGrupo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(9);
            Property(x => x.FechaDisponibilidadComercial).HasColumnName(@"FechaDisponibilidadComercial").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaNecesidadInformacion).HasColumnName(@"FechaNecesidadInformacion").HasColumnType("datetime").IsOptional();
            Property(x => x.IncluirEnDilve).HasColumnName(@"IncluirEnDILVE").HasColumnType("bit").IsOptional();
            Property(x => x.FechaCreacionDilve).HasColumnName(@"FechaCreacionDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaRetiradaDilve).HasColumnName(@"FechaRetiradaDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.IdColeccion).HasColumnName(@"IdColeccion").HasColumnType("int").IsOptional();
            Property(x => x.IdSerie).HasColumnName(@"IdSerie").HasColumnType("int").IsOptional();
            Property(x => x.IdCampaña).HasColumnName(@"IdCampaña").HasColumnType("smallint").IsOptional();
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsOptional();
            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsOptional();
            Property(x => x.TituloDistribuidora).HasColumnName(@"TituloDistribuidora").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.TituloIsbn).HasColumnName(@"TituloISBN").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdTipoMaterialSap).HasColumnName(@"IdTipoMaterialSAP").HasColumnType("smallint").IsOptional();
            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("int").IsOptional();
            Property(x => x.IdTipoPublicacion).HasColumnName(@"IdTipoPublicacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdUsoComercial).HasColumnName(@"IdUsoComercial").HasColumnType("tinyint").IsOptional();
            Property(x => x.Bilingue).HasColumnName(@"Bilingue").HasColumnType("bit").IsOptional();
            Property(x => x.IdFase).HasColumnName(@"IdFase").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdEstadoSeguimiento).HasColumnName(@"IdEstadoSeguimiento").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaCreacionProyectoPs).HasColumnName(@"FechaCreacionProyectoPS").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaRecepcionPrototipos).HasColumnName(@"FechaRecepcionPrototipos").HasColumnType("datetime").IsOptional();
            Property(x => x.IdZonaGeografica).HasColumnName(@"IdZonaGeografica").HasColumnType("tinyint").IsOptional();
            Property(x => x.TextoDerechos).HasColumnName(@"TextoDerechos").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdTipoMaterialEducativo).HasColumnName(@"IdTipoMaterialEducativo").HasColumnType("tinyint").IsOptional();
            Property(x => x.NumeroColeccion).HasColumnName(@"NumeroColeccion").HasColumnType("smallint").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsOptional();
            Property(x => x.IdInternoOrigen).HasColumnName(@"IDInternoOrigen").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.IdInternoOrigenSap).HasColumnName(@"IDInternoOrigenSAP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.NumeroSerie).HasColumnName(@"NumeroSerie").HasColumnType("smallint").IsOptional();
            Property(x => x.IdGenero).HasColumnName(@"IdGenero").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaFinProcesadoInteriores).HasColumnName(@"FechaFinProcesadoInteriores").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaPuestaEnMarchaFabricacion).HasColumnName(@"FechaPuestaEnMarchaFabricacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdDrm).HasColumnName(@"IdDRM").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdAccesibilidad).HasColumnName(@"IdAccesibilidad").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaActualizacionParaDilve).HasColumnName(@"FechaActualizacionParaDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaUltimaActualizacionDilve).HasColumnName(@"FechaUltimaActualizacionDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioMarcaDilve).HasColumnName(@"UsuarioMarcaDILVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.UsuarioSubidaDilve).HasColumnName(@"UsuarioSubidaDILVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.UsuarioRetiradaDilve).HasColumnName(@"UsuarioRetiradaDILVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BajaSoloECat).HasColumnName(@"BajaSoloECat").HasColumnType("bit").IsOptional();
            Property(x => x.UsuarioBajaSoloECat).HasColumnName(@"UsuarioBajaSoloECat").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PublicoDilve).HasColumnName(@"PublicoDILVE").HasColumnType("bit").IsOptional();
            Property(x => x.UsuarioActualizacionPublicoDilve).HasColumnName(@"UsuarioActualizacionPublicoDILVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaActualizacionPublicoDilve).HasColumnName(@"FechaActualizacionPublicoDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.PorcentajeCoedicion).HasColumnName(@"PorcentajeCoedicion").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdDisponibilidadDilve).HasColumnName(@"IdDisponibilidadDILVE").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaDisponibilidadDilve).HasColumnName(@"FechaDisponibilidadDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.IdProyectoAdicional).HasColumnName(@"IdProyectoAdicional").HasColumnType("int").IsOptional();
            Property(x => x.IdProyectoGestion).HasColumnName(@"IdProyectoGestion").HasColumnType("int").IsOptional();
        }
    }
}