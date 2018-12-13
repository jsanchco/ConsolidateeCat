namespace eCat.Repository.Mapped
{
    public class IdiomasIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.IdiomasIdioma>
    {
        public IdiomasIdiomaConfiguration()
            : this("dbo")
        {
        }

        public IdiomasIdiomaConfiguration(string schema)
        {
            ToTable("Idiomas_Idioma", schema);
            HasKey(x => new { x.IdIdioma, x.IdIdiomaInterface });

            Property(x => x.IdIdioma).HasColumnName(@"IDIdioma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.IdiomasIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_Idiomas_Idioma_T_Idiomas_Plataforma
        }
    }
}