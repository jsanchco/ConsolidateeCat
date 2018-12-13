namespace eCat.Repository.Mapped
{
    public class TEdadCursoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TEdadCurso>
    {
        public TEdadCursoConfiguration()
            : this("dbo")
        {
        }

        public TEdadCursoConfiguration(string schema)
        {
            ToTable("T_EdadCurso", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdCursoGradoEdad).HasColumnName(@"IdCursoGradoEdad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Hpe).HasColumnName(@"HPE").HasColumnType("bit").IsRequired();
        }
    }
}