namespace eCat.Repository.Mapped
{
    public class E2GePlantillanodoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GePlantillanodo>
    {
        public E2GePlantillanodoConfiguration()
            : this("dbo")
        {
        }

        public E2GePlantillanodoConfiguration(string schema)
        {
            ToTable("E2_GE_PLANTILLANODO", schema);
            HasKey(x => x.IdPlantilla);

            Property(x => x.IdPlantilla).HasColumnName(@"ID_PLANTILLA").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.NombreFichero).HasColumnName(@"NombreFichero").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}