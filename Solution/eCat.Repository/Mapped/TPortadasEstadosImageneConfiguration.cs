namespace eCat.Repository.Mapped
{
    public class TPortadasEstadosImageneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPortadasEstadosImagene>
    {
        public TPortadasEstadosImageneConfiguration()
            : this("dbo")
        {
        }

        public TPortadasEstadosImageneConfiguration(string schema)
        {
            ToTable("T_Portadas_EstadosImagenes", schema);
            HasKey(x => x.IdEstado);

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();
        }
    }
}