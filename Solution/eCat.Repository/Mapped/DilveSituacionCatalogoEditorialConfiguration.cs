namespace eCat.Repository.Mapped
{
    public class DilveSituacionCatalogoEditorialConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveSituacionCatalogoEditorial>
    {
        public DilveSituacionCatalogoEditorialConfiguration()
            : this("dbo")
        {
        }

        public DilveSituacionCatalogoEditorialConfiguration(string schema)
        {
            ToTable("DILVE_SituacionCatalogoEditorial", schema);
            HasKey(x => x.IdSituacion);

            Property(x => x.IdSituacion).HasColumnName(@"IdSituacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoSituacion).HasColumnName(@"CodigoSituacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
        }
    }
}