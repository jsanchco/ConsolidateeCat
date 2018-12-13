namespace eCat.Repository.Mapped
{
    public class PeComponentesDestinoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesDestino>
    {
        public PeComponentesDestinoConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesDestinoConfiguration(string schema)
        {
            ToTable("PE_Componentes_Destinos", schema);
            HasKey(x => x.IdDestino);

            Property(x => x.IdDestino).HasColumnName(@"IdDestino").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DescripcionCorta).HasColumnName(@"DescripcionCorta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
        }
    }
}