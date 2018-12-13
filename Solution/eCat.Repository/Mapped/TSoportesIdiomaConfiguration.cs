namespace eCat.Repository.Mapped
{
    public class TSoportesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TSoportesIdioma>
    {
        public TSoportesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TSoportesIdiomaConfiguration(string schema)
        {
            ToTable("T_Soportes_Idioma", schema);
            HasKey(x => new { x.IdSoporte, x.IdIdiomaInterface });

            Property(x => x.IdSoporte).HasColumnName(@"IdSoporte").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TSoportesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Soportes_Idioma_T_Idiomas_Plataforma
        }
    }
}