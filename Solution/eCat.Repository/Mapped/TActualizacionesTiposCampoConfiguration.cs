namespace eCat.Repository.Mapped
{
    public class TActualizacionesTiposCampoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesTiposCampo>
    {
        public TActualizacionesTiposCampoConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesTiposCampoConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_TiposCampo", schema);
            HasKey(x => x.IdTipoCampoActualizacion);

            Property(x => x.IdTipoCampoActualizacion).HasColumnName(@"IdTipoCampoActualizacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}