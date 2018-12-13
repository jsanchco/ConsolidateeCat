namespace eCat.Repository.Mapped
{
    public class TDigitalAccesibilidadIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDigitalAccesibilidadIdioma>
    {
        public TDigitalAccesibilidadIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TDigitalAccesibilidadIdiomaConfiguration(string schema)
        {
            ToTable("T_Digital_Accesibilidad_Idioma", schema);
            HasKey(x => new { x.IdAccesibilidad, x.IdIdiomaInterface });

            Property(x => x.IdAccesibilidad).HasColumnName(@"IdAccesibilidad").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TDigitalAccesibilidad).WithMany(b => b.TDigitalAccesibilidadIdiomas).HasForeignKey(c => c.IdAccesibilidad).WillCascadeOnDelete(false); // FK_T_Digital_Accesibilidad_Idioma_T_Digital_Accesibilidad
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TDigitalAccesibilidadIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Digital_Accesibilidad_Idioma_T_Idiomas_Plataforma
        }
    }
}