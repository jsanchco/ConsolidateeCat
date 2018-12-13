namespace eCat.Repository.Mapped
{
    public class SinliLenguaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliLengua>
    {
        public SinliLenguaConfiguration()
            : this("dbo")
        {
        }

        public SinliLenguaConfiguration(string schema)
        {
            ToTable("SINLI_LENGUAS", schema);
            HasKey(x => x.CodIso639);

            Property(x => x.CodIso639).HasColumnName(@"COD_ISO639").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }
}