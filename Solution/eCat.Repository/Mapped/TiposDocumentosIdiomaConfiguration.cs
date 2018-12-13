namespace eCat.Repository.Mapped
{
    public class TiposDocumentosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposDocumentosIdioma>
    {
        public TiposDocumentosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TiposDocumentosIdiomaConfiguration(string schema)
        {
            ToTable("TiposDocumentos_Idioma", schema);
            HasKey(x => new { x.IdTipoDocumento, x.IdIdiomaInterface });

            Property(x => x.IdTipoDocumento).HasColumnName(@"IDTipoDocumento").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TiposDocumentosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_TiposDocumentos_Idioma_T_Idiomas_Plataforma
        }
    }
}