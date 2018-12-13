namespace eCat.Repository.Mapped
{
    public class PeProyectosDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosDocumento>
    {
        public PeProyectosDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosDocumentoConfiguration(string schema)
        {
            ToTable("PE_Proyectos_Documentos", schema);
            HasKey(x => new { x.IdProyecto, x.IdDocumento });

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeDocumento).WithMany(b => b.PeProyectosDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_Proyectos_Documentos_PE_Documentos
            HasRequired(a => a.PeProyecto).WithMany(b => b.PeProyectosDocumentoes).HasForeignKey(c => c.IdProyecto).WillCascadeOnDelete(false); // FK_PE_Proyectos_Documentos_PE_Proyectos
        }
    }
}