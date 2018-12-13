namespace eCat.Repository.Mapped
{
    public class TDigitalPlataformasIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDigitalPlataformasIdioma>
    {
        public TDigitalPlataformasIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TDigitalPlataformasIdiomaConfiguration(string schema)
        {
            ToTable("T_Digital_Plataformas_Idioma", schema);
            HasKey(x => new { x.IdPlataforma, x.IdIdiomaInterface });

            Property(x => x.IdPlataforma).HasColumnName(@"IdPlataforma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TDigitalPlataforma).WithMany(b => b.TDigitalPlataformasIdiomas).HasForeignKey(c => c.IdPlataforma).WillCascadeOnDelete(false); // FK_T_Digital_Plataformas_Idioma_T_Digital_Plataformas
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TDigitalPlataformasIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Digital_Plataformas_Idioma_T_Idiomas_Plataforma
        }
    }
}