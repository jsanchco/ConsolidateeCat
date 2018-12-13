namespace eCat.Repository.Mapped
{
    public class EdadesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.EdadesIdioma>
    {
        public EdadesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public EdadesIdiomaConfiguration(string schema)
        {
            ToTable("Edades_Idioma", schema);
            HasKey(x => new { x.IdEdad, x.IdIdiomaInterface });

            Property(x => x.IdEdad).HasColumnName(@"IdEdad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.EdadesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_Edades_Idioma_T_Idiomas_Plataforma
        }
    }
}