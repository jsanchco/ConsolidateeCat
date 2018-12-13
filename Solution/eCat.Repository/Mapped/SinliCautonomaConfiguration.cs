namespace eCat.Repository.Mapped
{
    public class SinliCautonomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliCautonoma>
    {
        public SinliCautonomaConfiguration()
            : this("dbo")
        {
        }

        public SinliCautonomaConfiguration(string schema)
        {
            ToTable("SINLI_CAUTONOMAS", schema);
            HasKey(x => x.CodCaut);

            Property(x => x.CodCaut).HasColumnName(@"COD_CAUT").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
        }
    }
}