namespace eCat.Repository.Mapped
{
    public class CodigoCduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.CodigoCdu>
    {
        public CodigoCduConfiguration()
            : this("dbo")
        {
        }

        public CodigoCduConfiguration(string schema)
        {
            ToTable("Codigo_CDU", schema);
            HasKey(x => x.IdCodigoCdu);

            Property(x => x.IdCodigoCdu).HasColumnName(@"IDCodigoCDU").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPadre).HasColumnName(@"IDPadre").HasColumnType("int").IsOptional();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(256);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(256);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();
            Property(x => x.Nivelador).HasColumnName(@"Nivelador").HasColumnType("bit").IsRequired();
        }
    }
}