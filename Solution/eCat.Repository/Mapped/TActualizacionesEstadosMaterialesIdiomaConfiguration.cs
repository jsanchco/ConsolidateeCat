namespace eCat.Repository.Mapped
{
    public class TActualizacionesEstadosMaterialesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TActualizacionesEstadosMaterialesIdioma>
    {
        public TActualizacionesEstadosMaterialesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TActualizacionesEstadosMaterialesIdiomaConfiguration(string schema)
        {
            ToTable("T_Actualizaciones_Estados_Materiales_Idioma", schema);
            HasKey(x => new { x.IdEstadoActualizacionMaterial, x.IdIdiomaInterface });

            Property(x => x.IdEstadoActualizacionMaterial).HasColumnName(@"IdEstadoActualizacionMaterial").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TActualizacionesEstadosMateriale).WithMany(b => b.TActualizacionesEstadosMaterialesIdiomas).HasForeignKey(c => c.IdEstadoActualizacionMaterial).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Actualizaciones_Estados_Materiales
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TActualizacionesEstadosMaterialesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Idiomas_Plataforma
        }
    }
}