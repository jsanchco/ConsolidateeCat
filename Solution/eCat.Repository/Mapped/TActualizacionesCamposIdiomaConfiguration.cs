namespace eCat.Repository.Mapped
{
    public class TActualizacionesCamposIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesCamposIdioma>
    {
        public TActualizacionesCamposIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesCamposIdiomaConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Campos_Idiomas", schema);
            HasKey(x => new { x.CodigoCampoActualizacion, x.IdIdiomaInterface });

            Property(x => x.CodigoCampoActualizacion).HasColumnName(@"CodigoCampoActualizacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TActualizacionesCampos).WithMany(b => b.TActualizacionesCamposIdiomas).HasForeignKey(c => c.CodigoCampoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Campos_Idiomas_T_Actualizaciones_Campos
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TActualizacionesCamposIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Campos_Idiomas_T_Idiomas_Plataforma
        }
    }
}