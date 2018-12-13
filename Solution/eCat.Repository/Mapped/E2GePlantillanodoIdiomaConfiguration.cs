namespace eCat.Repository.Mapped
{
    public class E2GePlantillanodoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GePlantillanodoIdioma>
    {
        public E2GePlantillanodoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2GePlantillanodoIdiomaConfiguration(string schema)
        {
            ToTable("E2_GE_PLANTILLANODO_Idioma", schema);
            HasKey(x => new { x.IdPlantilla, x.IdIdiomaInterface });

            Property(x => x.IdPlantilla).HasColumnName(@"ID_PLANTILLA").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}