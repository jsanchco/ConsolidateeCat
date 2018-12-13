namespace eCat.Repository.Mapped
{
    public class PeDocumentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeDocumento>
    {
        public PeDocumentoConfiguration()
            : this("dbo")
        {
        }

        public PeDocumentoConfiguration(string schema)
        {
            ToTable("PE_Documentos", schema);
            HasKey(x => x.IdDocumento);

            Property(x => x.IdDocumento).HasColumnName(@"IdDocumento").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Guid).HasColumnName(@"GUID").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.UsuarioCreacion).HasColumnName(@"UsuarioCreacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaModificacion).HasColumnName(@"FechaModificacion").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioModificacion).HasColumnName(@"UsuarioModificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaBaja).HasColumnName(@"FechaBaja").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioBaja).HasColumnName(@"UsuarioBaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Path).HasColumnName(@"Path").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Extension).HasColumnName(@"Extension").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NombreFicheroOriginal).HasColumnName(@"NombreFicheroOriginal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasOptional(a => a.Usuario_UsuarioBaja).WithMany(b => b.PeDocumentoes_UsuarioBaja).HasForeignKey(c => c.UsuarioBaja).WillCascadeOnDelete(false); // FK_PE_Documentos_Usuarios2
            HasOptional(a => a.Usuario_UsuarioCreacion).WithMany(b => b.PeDocumentoes_UsuarioCreacion).HasForeignKey(c => c.UsuarioCreacion).WillCascadeOnDelete(false); // FK_PE_Documentos_Usuarios
            HasOptional(a => a.Usuario_UsuarioModificacion).WithMany(b => b.PeDocumentoes_UsuarioModificacion).HasForeignKey(c => c.UsuarioModificacion).WillCascadeOnDelete(false); // FK_PE_Documentos_Usuarios1
        }
    }
}