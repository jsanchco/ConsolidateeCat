namespace eCat.Repository.Mapped
{
    public class SinliAudienciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliAudiencia>
    {
        public SinliAudienciaConfiguration()
            : this("dbo")
        {
        }

        public SinliAudienciaConfiguration(string schema)
        {
            ToTable("SINLI_AUDIENCIAS", schema);
            HasKey(x => x.CodAudi);

            Property(x => x.CodAudi).HasColumnName(@"COD_AUDI").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
        }
    }
}