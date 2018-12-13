namespace eCat.Repository.Mapped
{
    public class E2GeRamaslibroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeRamaslibro>
    {
        public E2GeRamaslibroConfiguration()
            : this("dbo")
        {
        }

        public E2GeRamaslibroConfiguration(string schema)
        {
            ToTable("E2_GE_RAMASLIBROS", schema);
            HasKey(x => new { x.IdCatalogo, x.IdClasificacion, x.IdInterno });

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInterno).HasColumnName(@"ID_INTERNO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Destacado).HasColumnName(@"Destacado").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.E2GeCatalogo).WithMany(b => b.E2GeRamaslibro).HasForeignKey(c => c.IdCatalogo).WillCascadeOnDelete(false); // FK_E2_GE_RAMASLIBROS_E2_GE_CATALOGOS
            HasRequired(a => a.E2GeRamasarbol).WithMany(b => b.E2GeRamaslibro).HasForeignKey(c => new { c.IdCatalogo, c.IdClasificacion }).WillCascadeOnDelete(false); // FK_E2_GE_RAMASLIBROS_E2_GE_RAMASARBOL
            HasRequired(a => a.FichasBase).WithMany(b => b.E2GeRamaslibro).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_GE_RAMASLIBROS_FichasBase
        }
    }
}