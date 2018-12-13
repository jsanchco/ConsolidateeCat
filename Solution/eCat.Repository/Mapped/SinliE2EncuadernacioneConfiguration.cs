namespace eCat.Repository.Mapped
{
    public class SinliE2EncuadernacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliE2Encuadernacione>
    {
        public SinliE2EncuadernacioneConfiguration()
            : this("dbo")
        {
        }

        public SinliE2EncuadernacioneConfiguration(string schema)
        {
            ToTable("SINLI_E2_ENCUADERNACIONES", schema);
            HasKey(x => x.TipoEncuadernacion);

            Property(x => x.CodEncSl).HasColumnName(@"COD_ENC_SL").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.TipoEncuadernacion).HasColumnName(@"TipoEncuadernacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}