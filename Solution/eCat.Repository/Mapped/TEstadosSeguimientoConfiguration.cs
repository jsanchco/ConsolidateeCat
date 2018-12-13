namespace eCat.Repository.Mapped
{
    public class TEstadosSeguimientoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TEstadosSeguimiento>
    {
        public TEstadosSeguimientoConfiguration()
            : this("dbo")
        {
        }

        public TEstadosSeguimientoConfiguration(string schema)
        {
            ToTable("T_EstadosSeguimiento", schema);
            HasKey(x => x.IdEstadoSeguimiento);

            Property(x => x.IdEstadoSeguimiento).HasColumnName(@"IdEstadoSeguimiento").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EstadoSeguimiento).HasColumnName(@"EstadoSeguimiento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}