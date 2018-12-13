namespace eCat.Repository.Mapped
{
    public class AplicacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Aplicacione>
    {
        public AplicacioneConfiguration()
            : this("dbo")
        {
        }

        public AplicacioneConfiguration(string schema)
        {
            ToTable("Aplicaciones", schema);
            HasKey(x => x.IdAplicacion);

            Property(x => x.IdAplicacion).HasColumnName(@"IDAplicacion").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Aplicacion).HasColumnName(@"Aplicacion").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}