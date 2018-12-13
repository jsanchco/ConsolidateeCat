namespace eCat.Repository.Mapped
{
    public class E2GeCatalogosCompartidoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeCatalogosCompartido>
    {
        public E2GeCatalogosCompartidoConfiguration()
            : this("dbo")
        {
        }

        public E2GeCatalogosCompartidoConfiguration(string schema)
        {
            ToTable("E2_GE_CATALOGOS_COMPARTIDOS", schema);
            HasKey(x => new { x.IdCatalogo, x.IdUsuario });

            Property(x => x.IdCatalogo).HasColumnName(@"ID_CATALOGO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsuario).HasColumnName(@"IDUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2GeCatalogo).WithMany(b => b.E2GeCatalogosCompartido).HasForeignKey(c => c.IdCatalogo).WillCascadeOnDelete(false); // FK_E2_GE_CATALOGOS_COMPARTIDOS_E2_GE_CATALOGOS
        }
    }
}