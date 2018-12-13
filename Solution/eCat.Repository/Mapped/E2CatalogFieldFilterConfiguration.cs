namespace eCat.Repository.Mapped
{
    public class E2CatalogFieldFilterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2CatalogFieldFilter>
    {
        public E2CatalogFieldFilterConfiguration()
            : this("dbo")
        {
        }

        public E2CatalogFieldFilterConfiguration(string schema)
        {
            ToTable("E2_CatalogFieldFilters", schema);
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Tag).HasColumnName(@"Tag").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("smallint").IsRequired();
            Property(x => x.Calculo).HasColumnName(@"Calculo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }
}