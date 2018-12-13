namespace eCat.Repository.Mapped
{
    public class SinliEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliEstado>
    {
        public SinliEstadoConfiguration()
            : this("dbo")
        {
        }

        public SinliEstadoConfiguration(string schema)
        {
            ToTable("SINLI_ESTADOS", schema);
            HasKey(x => x.CodSitu);

            Property(x => x.CodSitu).HasColumnName(@"COD_SITU").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}