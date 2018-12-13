namespace eCat.Repository.Mapped
{
    public class VwPortadaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.VwPortada>
    {
        public VwPortadaConfiguration()
            : this("dbo")
        {
        }

        public VwPortadaConfiguration(string schema)
        {
            ToTable("vw_Portadas", schema);
            HasKey(x => new { x.IdInterno, x.Portada });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Portada).HasColumnName(@"Portada").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}