namespace eCat.Repository.Mapped
{
    public class TDrmIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDrmIdioma>
    {
        public TDrmIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TDrmIdiomaConfiguration(string schema)
        {
            ToTable("T_DRM_Idioma", schema);
            HasKey(x => new { x.IdDrm, x.IdIdiomaInterface });

            Property(x => x.IdDrm).HasColumnName(@"IdDRM").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}