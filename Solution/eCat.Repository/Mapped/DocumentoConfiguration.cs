namespace eCat.Repository.Mapped
{
    public class DocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Documento>
    {
        public DocumentoConfiguration()
            : this("dbo")
        {
        }

        public DocumentoConfiguration(string schema)
        {
            ToTable("Documentos", schema);
            HasKey(x => new { x.IdInterno, x.IdDocumento });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Path).HasColumnName(@"Path").HasColumnType("nvarchar").IsRequired().HasMaxLength(1000);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdDocumento).HasColumnName(@"IDDocumento").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TipoLink).HasColumnName(@"TipoLink").HasColumnType("bit").IsRequired();
            Property(x => x.IdVisor).HasColumnName(@"IdVisor").HasColumnType("bigint").IsOptional();
            Property(x => x.Revisado).HasColumnName(@"Revisado").HasColumnType("bit").IsRequired();
            Property(x => x.DocumentoOriginal).HasColumnName(@"DocumentoOriginal").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.Documentoes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_Documentos_FichasBase
            HasRequired(a => a.TiposDocumento).WithMany(b => b.Documentoes).HasForeignKey(c => c.Tipo).WillCascadeOnDelete(false); // FK_Documentos_TiposDocumentos
        }
    }
}