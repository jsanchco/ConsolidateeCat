namespace eCat.Repository.Mapped
{
    public class TGenerosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TGenerosIdioma>
    {
        public TGenerosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TGenerosIdiomaConfiguration(string schema)
        {
            ToTable("T_Generos_Idioma", schema);
            HasKey(x => new { x.IdGenero, x.IdIdiomaInterface });

            Property(x => x.IdGenero).HasColumnName(@"IdGenero").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TGenerosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Generos_Idioma_T_Idiomas_Plataforma
        }
    }
}