namespace eCat.Repository.Mapped
{
    public class PeProyectosMarcoDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosMarcoDocumento>
    {
        public PeProyectosMarcoDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosMarcoDocumentoConfiguration(string schema)
        {
            ToTable("PE_ProyectosMarco_Documentos", schema);
            HasKey(x => new { x.IdProyectoMarco, x.IdDocumento });

            Property(x => x.IdProyectoMarco).HasColumnName(@"IdProyectoMarco").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Principal).HasColumnName(@"Principal").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeDocumento).WithMany(b => b.PeProyectosMarcoDocumentoes).HasForeignKey(c => c.IdDocumento).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_Documentos_PE_Documentos
            HasRequired(a => a.PeProyectosMarco).WithMany(b => b.PeProyectosMarcoDocumentoes).HasForeignKey(c => c.IdProyectoMarco).WillCascadeOnDelete(false); // FK_PE_ProyectosMarco_Documentos_PE_ProyectosMarco
        }
    }
}