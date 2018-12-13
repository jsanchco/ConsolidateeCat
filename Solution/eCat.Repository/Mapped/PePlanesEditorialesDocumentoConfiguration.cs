namespace eCat.Repository.Mapped
{
    public class PePlanesEditorialesDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PePlanesEditorialesDocumento>
    {
        public PePlanesEditorialesDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PePlanesEditorialesDocumentoConfiguration(string schema)
        {
            ToTable("PE_PlanesEditoriales_Documentos", schema);
            HasKey(x => new { x.IdPlanEditorial, x.IdDocumento });

            Property(x => x.IdPlanEditorial).HasColumnName(@"IdPlanEditorial").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeDocumento).WithMany(b => b.PePlanesEditorialesDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_Documentos_PE_Documentos
            HasRequired(a => a.PePlanesEditoriale).WithMany(b => b.PePlanesEditorialesDocumentoes).HasForeignKey(c => c.IdPlanEditorial).WillCascadeOnDelete(false); // FK_PE_PlanesEditoriales_Documentos_PE_PlanesEditoriales
        }
    }
}