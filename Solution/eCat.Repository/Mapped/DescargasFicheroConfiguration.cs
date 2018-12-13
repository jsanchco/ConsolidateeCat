namespace eCat.Repository.Mapped
{
    public class DescargasFicheroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DescargasFichero>
    {
        public DescargasFicheroConfiguration()
            : this("dbo")
        {
        }

        public DescargasFicheroConfiguration(string schema)
        {
            ToTable("DescargasFicheros", schema);
            HasKey(x => x.IdDescarga);

            Property(x => x.IdDescarga).HasColumnName(@"IDDescarga").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdDocumento).HasColumnName(@"IDDocumento").HasColumnType("numeric").IsRequired().HasPrecision(18,0);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(1000);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}