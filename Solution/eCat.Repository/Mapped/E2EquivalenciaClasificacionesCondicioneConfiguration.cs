namespace eCat.Repository.Mapped
{
    public class E2EquivalenciaClasificacionesCondicioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2EquivalenciaClasificacionesCondicione>
    {
        public E2EquivalenciaClasificacionesCondicioneConfiguration()
            : this("dbo")
        {
        }

        public E2EquivalenciaClasificacionesCondicioneConfiguration(string schema)
        {
            ToTable("E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES", schema);
            HasKey(x => x.IdEquivalenciaClasificacionCondicion);

            Property(x => x.IdEquivalenciaClasificacionCondicion).HasColumnName(@"IdEquivalenciaClasificacionCondicion").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCatalogoGest).HasColumnName(@"ID_CATALOGO_GEST").HasColumnType("int").IsRequired();
            Property(x => x.IdClasifGest).HasColumnName(@"ID_CLASIF_GEST").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.IdCatalogoPres).HasColumnName(@"ID_CATALOGO_PRES").HasColumnType("int").IsRequired();
            Property(x => x.IdClasifPres).HasColumnName(@"ID_CLASIF_PRES").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CodigoCampo).HasColumnName(@"CodigoCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.IncluirExcluir).HasColumnName(@"IncluirExcluir").HasColumnType("bit").IsRequired();
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();
            Property(x => x.AndOr).HasColumnName(@"AndOr").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2EquivalenciaClasificacione).WithMany(b => b.E2EquivalenciaClasificacionesCondicione).HasForeignKey(c => new { c.IdCatalogoGest, c.IdClasifGest, c.IdCatalogoPres, c.IdClasifPres }).WillCascadeOnDelete(false); // FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_EQUIVALENCIA_CLASIFICACIONES
            HasRequired(a => a.E2RamasClasificacionesGestion).WithMany(b => b.E2EquivalenciaClasificacionesCondicione).HasForeignKey(c => new { c.IdCatalogoGest, c.IdClasifGest }).WillCascadeOnDelete(false); // FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_RAMAS_CLASIFICACIONES_GESTION
        }
    }
}