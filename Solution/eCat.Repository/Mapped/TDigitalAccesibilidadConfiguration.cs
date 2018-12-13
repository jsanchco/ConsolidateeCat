namespace eCat.Repository.Mapped
{
    public class TDigitalAccesibilidadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDigitalAccesibilidad>
    {
        public TDigitalAccesibilidadConfiguration()
            : this("dbo")
        {
        }

        public TDigitalAccesibilidadConfiguration(string schema)
        {
            ToTable("T_Digital_Accesibilidad", schema);
            HasKey(x => x.IdAccesibilidad);

            Property(x => x.IdAccesibilidad).HasColumnName(@"IdAccesibilidad").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Accesibilidad).HasColumnName(@"Accesibilidad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}