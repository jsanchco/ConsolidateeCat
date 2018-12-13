namespace eCat.Repository.Mapped
{
    public class PeDocumentosExtensionesPermitidaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeDocumentosExtensionesPermitida>
    {
        public PeDocumentosExtensionesPermitidaConfiguration()
            : this("dbo")
        {
        }

        public PeDocumentosExtensionesPermitidaConfiguration(string schema)
        {
            ToTable("PE_Documentos_ExtensionesPermitidas", schema);
            HasKey(x => x.Extension);

            Property(x => x.Extension).HasColumnName(@"Extension").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}