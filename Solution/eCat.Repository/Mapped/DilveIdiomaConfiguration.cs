namespace eCat.Repository.Mapped
{
    public class DilveIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveIdioma>
    {
        public DilveIdiomaConfiguration()
            : this("dbo")
        {
        }

        public DilveIdiomaConfiguration(string schema)
        {
            ToTable("DILVE_Idiomas", schema);
            HasKey(x => x.IdIdioma);

            Property(x => x.IdIdioma).HasColumnName(@"IdIdioma").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoIdiomaDilve).HasColumnName(@"CodigoIdiomaDilve").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodigoIdiomaAnele).HasColumnName(@"CodigoIdiomaAnele").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            HasMany(t => t.Idiomas).WithMany(t => t.DilveIdiomas).Map(m =>
            {
                m.ToTable("DILVE_Idiomas_Equivalencias", "dbo");
                m.MapLeftKey("IdIdiomaDilve");
                m.MapRightKey("IdIdiomaECat");
            });
        }
    }
}