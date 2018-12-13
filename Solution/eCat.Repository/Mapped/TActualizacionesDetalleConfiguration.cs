namespace eCat.Repository.Mapped
{
    public class TActualizacionesDetalleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesDetalle>
    {
        public TActualizacionesDetalleConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesDetalleConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Detalle", schema);
            HasKey(x => new { x.IdActualizacion, x.IdInterno });

            Property(x => x.IdActualizacion).HasColumnName(@"IdActualizacion").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEstadoActualizacionMaterial).HasColumnName(@"IdEstadoActualizacionMaterial").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TActualizacionesDetalles).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_T_actualizaciones_Detalle_FichasBase
            HasRequired(a => a.TActualizacionesCabecera).WithMany(b => b.TActualizacionesDetalles).HasForeignKey(c => c.IdActualizacion).WillCascadeOnDelete(false); // FK_T_actualizaciones_Detalle_T_Actualizaciones_Cabecera
            HasRequired(a => a.TActualizacionesEstadosMateriale).WithMany(b => b.TActualizacionesDetalles).HasForeignKey(c => c.IdEstadoActualizacionMaterial).WillCascadeOnDelete(false); // FK_T_actualizaciones_Detalle_T_Actualizaciones_Estados_Materiales
        }
    }
}