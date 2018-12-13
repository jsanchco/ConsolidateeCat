namespace eCat.Repository.Mapped
{
    public class TActualizacionesTiposActualizacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesTiposActualizacion>
    {
        public TActualizacionesTiposActualizacionConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesTiposActualizacionConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_TiposActualizacion", schema);
            HasKey(x => x.IdTipoActualizacion);

            Property(x => x.IdTipoActualizacion).HasColumnName(@"IdTipoActualizacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}