namespace eCat.Repository.Mapped
{
    public class TActualizacionesEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesEstado>
    {
        public TActualizacionesEstadoConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesEstadoConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Estados", schema);
            HasKey(x => x.IdEstadoActualizacion);

            Property(x => x.IdEstadoActualizacion).HasColumnName(@"IdEstadoActualizacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}