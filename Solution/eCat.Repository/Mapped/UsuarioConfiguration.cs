namespace eCat.Repository.Mapped
{
    public class UsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Usuario>
    {
        public UsuarioConfiguration()
            : this("dbo")
        {
        }

        public UsuarioConfiguration(string schema)
        {
            ToTable("Usuarios", schema);
            HasKey(x => x.IdUsuario);

            Property(x => x.IdUsuario).HasColumnName(@"IDUsuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Usuario_).HasColumnName(@"Usuario").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Pwd).HasColumnName(@"Pwd").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.IdIdioma).HasColumnName(@"IdIdioma").HasColumnType("smallint").IsOptional();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.Impersonado).HasColumnName(@"Impersonado").HasColumnType("bit").IsRequired();
        }
    }
}