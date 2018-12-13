namespace eCat.Repository.Mapped
{
    public class E2GeRamasarbolConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeRamasarbol>
    {
        public E2GeRamasarbolConfiguration()
            : this("dbo")
        {
        }

        public E2GeRamasarbolConfiguration(string schema)
        {
            ToTable("E2_GE_RAMASARBOL", schema);
            HasKey(x => new { x.IdCatalogo, x.IdClasificacion });

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPadre).HasColumnName(@"ID_PADRE").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.IdPlantilla).HasColumnName(@"ID_PLANTILLA").HasColumnType("int").IsOptional();
            Property(x => x.IdTiponodo).HasColumnName(@"ID_TIPONODO").HasColumnType("int").IsOptional();
            Property(x => x.FoneticaClasif).HasColumnName(@"FONETICA_CLASIF").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.PendientePublicar).HasColumnName(@"PendientePublicar").HasColumnType("bit").IsRequired();
            Property(x => x.Publicado).HasColumnName(@"Publicado").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaPublicacion).HasColumnName(@"FechaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioPublicacion).HasColumnName(@"UsuarioPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaUltimaPublicacion).HasColumnName(@"FechaUltimaPublicacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioUltimaPublicacion).HasColumnName(@"UsuarioUltimaPublicacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaActualizacion).HasColumnName(@"FechaActualizacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioActualizacion).HasColumnName(@"UsuarioActualizacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaRetirada).HasColumnName(@"FechaRetirada").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioRetirada).HasColumnName(@"UsuarioRetirada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.EstadoPublicacion).HasColumnName(@"EstadoPublicacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.GuidContenido).HasColumnName(@"GUIDContenido").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdCmsContenido).HasColumnName(@"IdCMSContenido").HasColumnType("bigint").IsOptional();

            // Foreign keys
            HasOptional(a => a.E2GePlantillanodo).WithMany(b => b.E2GeRamasarbol).HasForeignKey(c => c.IdPlantilla).WillCascadeOnDelete(false); // FK_E2_GE_RAMASARBOL_E2_GE_PLANTILLANODO
            HasOptional(a => a.E2GeTiponodo).WithMany(b => b.E2GeRamasarbol).HasForeignKey(c => c.IdTiponodo).WillCascadeOnDelete(false); // FK_E2_GE_RAMASARBOL_E2_GE_TIPONODO
            HasRequired(a => a.E2GeCatalogo).WithMany(b => b.E2GeRamasarbol).HasForeignKey(c => c.IdCatalogo).WillCascadeOnDelete(false); // FK_E2_GE_RAMASARBOL_E2_GE_CATALOGOS
        }
    }
}