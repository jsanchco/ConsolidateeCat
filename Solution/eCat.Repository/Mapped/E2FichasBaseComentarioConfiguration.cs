namespace eCat.Repository.Mapped
{
    public class E2FichasBaseComentarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2FichasBaseComentario>
    {
        public E2FichasBaseComentarioConfiguration()
            : this("dbo")
        {
        }

        public E2FichasBaseComentarioConfiguration(string schema)
        {
            ToTable("E2_FichasBase_Comentarios", schema);
            HasKey(x => new { x.IdInterno, x.TipoDocumento });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoDocumento).HasColumnName(@"TipoDocumento").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Comentario).HasColumnName(@"Comentario").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.E2FichasBaseComentario).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_E2_FichasBase_Comentarios_FichasBase
        }
    }
}