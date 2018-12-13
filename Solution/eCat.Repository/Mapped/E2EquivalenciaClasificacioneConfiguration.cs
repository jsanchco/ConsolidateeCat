namespace eCat.Repository.Mapped
{
    public class E2EquivalenciaClasificacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2EquivalenciaClasificacione>
    {
        public E2EquivalenciaClasificacioneConfiguration()
            : this("dbo")
        {
        }

        public E2EquivalenciaClasificacioneConfiguration(string schema)
        {
            ToTable("E2_EQUIVALENCIA_CLASIFICACIONES", schema);
            HasKey(x => new { x.IdCatalogoGest, x.IdClasifGest, x.IdCatalogoPres, x.IdClasifPres });

            Property(x => x.IdCatalogoGest).HasColumnName(@"ID_CATALOGO_GEST").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasifGest).HasColumnName(@"ID_CLASIF_GEST").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCatalogoPres).HasColumnName(@"ID_CATALOGO_PRES").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasifPres).HasColumnName(@"ID_CLASIF_PRES").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2ClasificacionesGestion).WithMany(b => b.E2EquivalenciaClasificacione).HasForeignKey(c => c.IdCatalogoGest).WillCascadeOnDelete(false); // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_CLASIFICACIONES_GESTION
            HasRequired(a => a.E2GeCatalogo).WithMany(b => b.E2EquivalenciaClasificacione).HasForeignKey(c => c.IdCatalogoPres).WillCascadeOnDelete(false); // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_GE_CATALOGOS
            HasRequired(a => a.E2RamasClasificacionesGestion).WithMany(b => b.E2EquivalenciaClasificacione).HasForeignKey(c => new { c.IdCatalogoGest, c.IdClasifGest }).WillCascadeOnDelete(false); // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_RAMAS_CLASIFICACIONES_GESTION
        }
    }
}