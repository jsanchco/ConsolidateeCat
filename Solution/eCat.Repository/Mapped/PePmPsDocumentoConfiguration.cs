namespace eCat.Repository.Mapped
{
    public class PePmPsDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PePmPsDocumento>
    {
        public PePmPsDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PePmPsDocumentoConfiguration(string schema)
        {
            ToTable("PE_PMPs_Documentos", schema);
            HasKey(x => new { x.IdPmp, x.IdDocumento });

            Property(x => x.IdPmp).HasColumnName(@"IdPMP").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeDocumento).WithMany(b => b.PePmPsDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_PMPs_Documentos_PE_Documentos
            HasRequired(a => a.PePmp).WithMany(b => b.PePmPsDocumentoes).HasForeignKey(c => c.IdPmp).WillCascadeOnDelete(false); // FK_PE_PMPs_Documentos_PE_PMPs
        }
    }
}