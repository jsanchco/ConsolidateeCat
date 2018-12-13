namespace eCat.Repository.Mapped
{
    public class PeComponentesDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesDocumento>
    {
        public PeComponentesDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesDocumentoConfiguration(string schema)
        {
            ToTable("PE_Componentes_Documentos", schema);
            HasKey(x => new { x.IdComponente, x.IdDocumento });

            Property(x => x.IdComponente).HasColumnName(@"IdComponente").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeComponente).WithMany(b => b.PeComponentesDocumentoes).HasForeignKey(c => c.IdComponente).WillCascadeOnDelete(false); // FK_PE_Componentes_Documentos_PE_Componentes
            HasRequired(a => a.PeDocumento).WithMany(b => b.PeComponentesDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_Componentes_Documentos_PE_Documentos
        }
    }
}