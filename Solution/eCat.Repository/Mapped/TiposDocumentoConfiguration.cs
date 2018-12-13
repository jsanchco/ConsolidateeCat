namespace eCat.Repository.Mapped
{
    public class TiposDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposDocumento>
    {
        public TiposDocumentoConfiguration()
            : this("dbo")
        {
        }

        public TiposDocumentoConfiguration(string schema)
        {
            ToTable("TiposDocumentos", schema);
            HasKey(x => x.IdTipoDocumento);

            Property(x => x.IdTipoDocumento).HasColumnName(@"IDTipoDocumento").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Extensiones).HasColumnName(@"Extensiones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }
}