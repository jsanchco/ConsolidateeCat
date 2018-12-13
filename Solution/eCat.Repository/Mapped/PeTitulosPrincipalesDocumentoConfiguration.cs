namespace eCat.Repository.Mapped
{
    public class PeTitulosPrincipalesDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeTitulosPrincipalesDocumento>
    {
        public PeTitulosPrincipalesDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PeTitulosPrincipalesDocumentoConfiguration(string schema)
        {
            ToTable("PE_TitulosPrincipales_Documentos", schema);
            HasKey(x => new { x.IdTituloPrincipal, x.IdDocumento });

            Property(x => x.IdTituloPrincipal).HasColumnName(@"IdTituloPrincipal").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeDocumento).WithMany(b => b.PeTitulosPrincipalesDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Documentos_PE_Documentos
            HasRequired(a => a.PeTitulosPrincipale).WithMany(b => b.PeTitulosPrincipalesDocumentoes).HasForeignKey(c => c.IdTituloPrincipal).WillCascadeOnDelete(false); // FK_PE_TitulosPrincipales_Documentos_PE_TitulosPrincipales
        }
    }
}