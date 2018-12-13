namespace eCat.Repository.Mapped
{
    public class SinliPaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliPais>
    {
        public SinliPaisConfiguration()
            : this("dbo")
        {
        }

        public SinliPaisConfiguration(string schema)
        {
            ToTable("SINLI_PAISES", schema);
            HasKey(x => x.CodPais);

            Property(x => x.CodPais).HasColumnName(@"COD_PAIS").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(35);
        }
    }
}