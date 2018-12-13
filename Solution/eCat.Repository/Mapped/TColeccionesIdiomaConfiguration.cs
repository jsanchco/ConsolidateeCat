namespace eCat.Repository.Mapped
{
    public class TColeccionesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TColeccionesIdioma>
    {
        public TColeccionesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TColeccionesIdiomaConfiguration(string schema)
        {
            ToTable("T_Colecciones_Idioma", schema);
            HasKey(x => new { x.IdColeccion, x.IdIdiomaInterface });

            Property(x => x.IdColeccion).HasColumnName(@"IdColeccion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
        }
    }
}