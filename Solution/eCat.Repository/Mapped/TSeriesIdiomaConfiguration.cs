namespace eCat.Repository.Mapped
{
    public class TSeriesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TSeriesIdioma>
    {
        public TSeriesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TSeriesIdiomaConfiguration(string schema)
        {
            ToTable("T_Series_Idioma", schema);
            HasKey(x => new { x.IdSerie, x.IdIdiomaInterface });

            Property(x => x.IdSerie).HasColumnName(@"IdSerie").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TSeriesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Series_Idioma_T_Idiomas_Plataforma
        }
    }
}