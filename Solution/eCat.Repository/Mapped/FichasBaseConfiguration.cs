namespace eCat.Repository.Mapped
{
    public class FichasBaseConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBase>
    {
        public FichasBaseConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseConfiguration(string schema)
        {
            ToTable("FichasBase", schema);
            HasKey(x => x.IdInterno);

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
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
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaActualizacion).HasColumnName(@"FechaActualizacion").HasColumnType("datetime").IsOptional();
            Property(x => x.IdPropietarioSubmateria).HasColumnName(@"IDPropietarioSubmateria").HasColumnType("numeric").IsOptional().HasPrecision(18,0);
            Property(x => x.UrlEditor).HasColumnName(@"URL_EDITOR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CodAudi).HasColumnName(@"COD_AUDI").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.CodNivel).HasColumnName(@"COD_NIVEL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1);
            Property(x => x.CodCaut).HasColumnName(@"COD_CAUT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.UsuarioActualizacion).HasColumnName(@"UsuarioActualizacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SoloIlustracion).HasColumnName(@"SoloIlustracion").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioPublicacion).HasColumnName(@"UsuarioPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaPublicacion).HasColumnName(@"FechaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioUltimaPublicacion).HasColumnName(@"UsuarioUltimaPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaUltimaPublicacion).HasColumnName(@"FechaUltimaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioRetirada).HasColumnName(@"UsuarioRetirada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaRetirada).HasColumnName(@"FechaRetirada").HasColumnType("datetime").IsOptional();
            Property(x => x.NEjemplaresCaja).HasColumnName(@"NEjemplaresCaja").HasColumnType("int").IsRequired();
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
            Property(x => x.Bilingue).HasColumnName(@"Bilingue").HasColumnType("bit").IsRequired();
            Property(x => x.IdFase).HasColumnName(@"IdFase").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdEstadoSeguimiento).HasColumnName(@"IdEstadoSeguimiento").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaCreacionProyectoPs).HasColumnName(@"FechaCreacionProyectoPS").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaRecepcionPrototipos).HasColumnName(@"FechaRecepcionPrototipos").HasColumnType("datetime").IsOptional();
            Property(x => x.IdZonaGeografica).HasColumnName(@"IdZonaGeografica").HasColumnType("tinyint").IsOptional();
            Property(x => x.TextoDerechos).HasColumnName(@"TextoDerechos").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdTipoMaterialEducativo).HasColumnName(@"IdTipoMaterialEducativo").HasColumnType("tinyint").IsOptional();
            Property(x => x.NumeroColeccion).HasColumnName(@"NumeroColeccion").HasColumnType("smallint").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
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
            Property(x => x.BajaSoloECat).HasColumnName(@"BajaSoloECat").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioBajaSoloECat).HasColumnName(@"UsuarioBajaSoloECat").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PublicoDilve).HasColumnName(@"PublicoDILVE").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioActualizacionPublicoDilve).HasColumnName(@"UsuarioActualizacionPublicoDILVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaActualizacionPublicoDilve).HasColumnName(@"FechaActualizacionPublicoDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.PorcentajeCoedicion).HasColumnName(@"PorcentajeCoedicion").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdDisponibilidadDilve).HasColumnName(@"IdDisponibilidadDILVE").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaDisponibilidadDilve).HasColumnName(@"FechaDisponibilidadDILVE").HasColumnType("datetime").IsOptional();
            Property(x => x.IdProyectoAdicional).HasColumnName(@"IdProyectoAdicional").HasColumnType("int").IsOptional();
            Property(x => x.IdProyectoGestion).HasColumnName(@"IdProyectoGestion").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CoEditoriale).WithMany(b => b.FichasBases).HasForeignKey(c => c.Coeditorial).WillCascadeOnDelete(false); // FK_FichasBase_CoEditoriales
            HasOptional(a => a.DilveDisponibilidad).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdDisponibilidadDilve).WillCascadeOnDelete(false); // FK_FichasBase_DILVE_Disponibilidad
            HasOptional(a => a.E2AclDominio).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_FichasBase_E2_ACL_DOMINIOS
            HasOptional(a => a.E2GruposArticulo).WithMany(b => b.FichasBases).HasForeignKey(c => c.CodigoGrupo).WillCascadeOnDelete(false); // FK_FichasBase_E2_GRUPOS_ARTICULOS
            HasOptional(a => a.EstadosSap).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdEstadoSap).WillCascadeOnDelete(false); // FK_FichasBase_EstadosSAP
            HasOptional(a => a.Idioma_Idioma).WithMany(b => b.FichasBases).HasForeignKey(c => c.Idioma).WillCascadeOnDelete(false); // FK_FichasBase_Idiomas
            HasOptional(a => a.LineaNegocio).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdLineaNegocio).WillCascadeOnDelete(false); // FK_FichasBase_LineaNegocio
            HasOptional(a => a.TCampañas).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdCampaña).WillCascadeOnDelete(false); // FK_FichasBase_T_Campañas
            HasOptional(a => a.TColeccione).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdColeccion).WillCascadeOnDelete(false); // FK_FichasBase_T_Colecciones
            HasOptional(a => a.TDigitalAccesibilidad).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdAccesibilidad).WillCascadeOnDelete(false); // FK_FichasBase_T_Digital_Accesibilidad
            HasOptional(a => a.TDrm).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdDrm).WillCascadeOnDelete(false); // FK_FichasBase_T_DRM
            HasOptional(a => a.TEstadosSeguimiento).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdEstadoSeguimiento).WillCascadeOnDelete(false); // FK_FichasBase_T_EstadosSeguimiento
            HasOptional(a => a.TFasesMaterial).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdFase).WillCascadeOnDelete(false); // FK_FichasBase_T_FasesMaterial
            HasOptional(a => a.TGenero).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdGenero).WillCascadeOnDelete(false); // FK_FichasBase_T_Generos
            HasOptional(a => a.TiposArticulo).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdTipoArticulo).WillCascadeOnDelete(false); // FK_FichasBase_TiposArticulos
            HasOptional(a => a.TiposEncuadernacion).WithMany(b => b.FichasBases).HasForeignKey(c => c.TipoEncuadernacion).WillCascadeOnDelete(false); // FK_FichasBase_TiposEncuadernacion
            HasOptional(a => a.TProyecto_IdProyecto).WithMany(b => b.FichasBases_IdProyecto).HasForeignKey(c => c.IdProyecto).WillCascadeOnDelete(false); // FK_FichasBase_T_Proyectos
            HasOptional(a => a.TProyecto_IdProyectoAdicional).WithMany(b => b.FichasBases_IdProyectoAdicional).HasForeignKey(c => c.IdProyectoAdicional).WillCascadeOnDelete(false); // FK_FichasBase_T_Proyectos_Adicional
            HasOptional(a => a.TProyectosGestion).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdProyectoGestion).WillCascadeOnDelete(false); // FK_FichasBase_T_ProyectosGestion
            HasOptional(a => a.TSeries).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdSerie).WillCascadeOnDelete(false); // FK_FichasBase_T_Series
            HasOptional(a => a.TTiposMateriale).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdTipoMaterialSap).WillCascadeOnDelete(false); // FK_FichasBase_T_TiposMateriales
            HasOptional(a => a.TTiposMaterialEducativo).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdTipoMaterialEducativo).WillCascadeOnDelete(false); // FK_FichasBase_T_TiposMaterialEducativo
            HasOptional(a => a.TTiposPublicacion).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdTipoPublicacion).WillCascadeOnDelete(false); // FK_FichasBase_T_TiposPublicacion
            HasOptional(a => a.TUsosComerciale).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdUsoComercial).WillCascadeOnDelete(false); // FK_FichasBase_T_UsosComerciales
            HasOptional(a => a.TZonasGeografica).WithMany(b => b.FichasBases).HasForeignKey(c => c.IdZonaGeografica).WillCascadeOnDelete(false); // FK_FichasBase_T_ZonasGeograficas
            HasOptional(a => a.Usuario_UsuarioPublicacion).WithMany(b => b.FichasBases_UsuarioPublicacion).HasForeignKey(c => c.UsuarioPublicacion).WillCascadeOnDelete(false); // FK_FichasBase_Usuarios
            HasOptional(a => a.Usuario_UsuarioRetirada).WithMany(b => b.FichasBases_UsuarioRetirada).HasForeignKey(c => c.UsuarioRetirada).WillCascadeOnDelete(false); // FK_FichasBase_Usuarios1
            HasMany(t => t.TDigitalPlataformas).WithMany(t => t.FichasBases).Map(m =>
            {
                m.ToTable("T_FichasBase_Digital_Plataformas", "dbo");
                m.MapLeftKey("IdInterno");
                m.MapRightKey("IdPlataforma");
            });
        }
    }
}