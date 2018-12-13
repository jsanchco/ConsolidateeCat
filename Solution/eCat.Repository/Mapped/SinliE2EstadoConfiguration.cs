namespace eCat.Repository.Mapped
{
    public class SinliE2EstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliE2Estado>
    {
        public SinliE2EstadoConfiguration()
            : this("dbo")
        {
        }

        public SinliE2EstadoConfiguration(string schema)
        {
            ToTable("SINLI_E2_ESTADOS", schema);
            HasKey(x => x.IdEstadoSap);

            Property(x => x.CodSitu).HasColumnName(@"COD_SITU").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.IdEstadoSap).HasColumnName(@"IDEstadoSAP").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}