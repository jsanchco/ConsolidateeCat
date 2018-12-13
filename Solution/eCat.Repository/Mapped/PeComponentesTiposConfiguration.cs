namespace eCat.Repository.Mapped
{
    public class PeComponentesTiposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesTipos>
    {
        public PeComponentesTiposConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesTiposConfiguration(string schema)
        {
            ToTable("PE_Componentes_Tipos", schema);
            HasKey(x => x.IdTipo);

            Property(x => x.IdTipo).HasColumnName(@"IdTipo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DescripcionCorta).HasColumnName(@"DescripcionCorta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
        }
    }
}