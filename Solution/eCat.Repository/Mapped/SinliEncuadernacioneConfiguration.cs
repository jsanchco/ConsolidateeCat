namespace eCat.Repository.Mapped
{
    public class SinliEncuadernacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliEncuadernacione>
    {
        public SinliEncuadernacioneConfiguration()
            : this("dbo")
        {
        }

        public SinliEncuadernacioneConfiguration(string schema)
        {
            ToTable("SINLI_ENCUADERNACIONES", schema);
            HasKey(x => x.CodEnc);

            Property(x => x.CodEnc).HasColumnName(@"COD_ENC").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(35);
        }
    }
}