namespace eCat.Repository.Mapped
{
    public class TActualizacionesEstadosMaterialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesEstadosMateriale>
    {
        public TActualizacionesEstadosMaterialeConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesEstadosMaterialeConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Estados_Materiales", schema);
            HasKey(x => x.IdEstadoActualizacionMaterial);

            Property(x => x.IdEstadoActualizacionMaterial).HasColumnName(@"IdEstadoActualizacionMaterial").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}