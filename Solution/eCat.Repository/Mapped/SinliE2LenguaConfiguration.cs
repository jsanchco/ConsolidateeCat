namespace eCat.Repository.Mapped
{
    public class SinliE2LenguaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliE2Lengua>
    {
        public SinliE2LenguaConfiguration()
            : this("dbo")
        {
        }

        public SinliE2LenguaConfiguration(string schema)
        {
            ToTable("SINLI_E2_LENGUAS", schema);
            HasKey(x => x.IdIdioma);

            Property(x => x.CodIso639).HasColumnName(@"COD_ISO639").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.IdIdioma).HasColumnName(@"IDIdioma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}