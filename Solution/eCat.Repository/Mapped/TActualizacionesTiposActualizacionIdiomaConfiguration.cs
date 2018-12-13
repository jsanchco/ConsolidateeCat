namespace eCat.Repository.Mapped
{
    public class TActualizacionesTiposActualizacionIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesTiposActualizacionIdioma>
    {
        public TActualizacionesTiposActualizacionIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesTiposActualizacionIdiomaConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_TiposActualizacion_Idioma", schema);
            HasKey(x => new { x.IdTipoActualizacion, x.IdIdiomaInterface });

            Property(x => x.IdTipoActualizacion).HasColumnName(@"IdTipoActualizacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TActualizacionesTiposActualizacion).WithMany(b => b.TActualizacionesTiposActualizacionIdiomas).HasForeignKey(c => c.IdTipoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Tipos_Idioma_T_Actualizaciones_Tipos
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TActualizacionesTiposActualizacionIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Actualizaciones_TiposActualizacion_Idioma_T_Idiomas_Plataforma
        }
    }
}