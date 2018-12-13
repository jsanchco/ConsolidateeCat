namespace eCat.Repository.Mapped
{
    public class TDigitalPlataformaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDigitalPlataforma>
    {
        public TDigitalPlataformaConfiguration()
            : this("dbo")
        {
        }

        public TDigitalPlataformaConfiguration(string schema)
        {
            ToTable("T_Digital_Plataformas", schema);
            HasKey(x => x.IdPlataforma);

            Property(x => x.IdPlataforma).HasColumnName(@"IdPlataforma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Plataforma).HasColumnName(@"Plataforma").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}