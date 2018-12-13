namespace eCat.Repository.Mapped
{
    public class TActualizacionesEstadosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesEstadosIdioma>
    {
        public TActualizacionesEstadosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesEstadosIdiomaConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Estados_Idioma", schema);
            HasKey(x => new { x.IdEstadoActualizacion, x.IdIdiomaInterface });

            Property(x => x.IdEstadoActualizacion).HasColumnName(@"IdEstadoActualizacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TActualizacionesEstado).WithMany(b => b.TActualizacionesEstadosIdiomas).HasForeignKey(c => c.IdEstadoActualizacion).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Estados_Idioma_T_Actualizaciones_Estados
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TActualizacionesEstadosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Estados_Idioma_T_Idiomas_Plataforma
        }
    }
}