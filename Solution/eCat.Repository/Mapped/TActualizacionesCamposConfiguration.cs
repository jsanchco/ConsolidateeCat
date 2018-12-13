namespace eCat.Repository.Mapped
{
    public class TActualizacionesCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesCampos>
    {
        public TActualizacionesCamposConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesCamposConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Campos", schema);
            HasKey(x => x.CodigoCampoActualizacion);

            Property(x => x.CodigoCampoActualizacion).HasColumnName(@"CodigoCampoActualizacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Campo).HasColumnName(@"Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdTipoCampoActualizacion).HasColumnName(@"IdTipoCampoActualizacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.BModificar).HasColumnName(@"bModificar").HasColumnType("bit").IsRequired();
            Property(x => x.BAñadir).HasColumnName(@"bAñadir").HasColumnType("bit").IsRequired();
            Property(x => x.BVaciar).HasColumnName(@"bVaciar").HasColumnType("bit").IsRequired();
            Property(x => x.BEliminar).HasColumnName(@"bEliminar").HasColumnType("bit").IsRequired();
            Property(x => x.ConsultaValores).HasColumnName(@"ConsultaValores").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.TActualizacionesTiposCampo).WithMany(b => b.TActualizacionesCampos).HasForeignKey(c => c.IdTipoCampoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Campos_T_Actualizaciones_TiposCampo
        }
    }
}