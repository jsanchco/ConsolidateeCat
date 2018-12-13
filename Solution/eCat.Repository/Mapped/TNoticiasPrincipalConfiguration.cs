namespace eCat.Repository.Mapped
{
    public class TNoticiasPrincipalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TNoticiasPrincipal>
    {
        public TNoticiasPrincipalConfiguration()
            : this("dbo")
        {
        }

        public TNoticiasPrincipalConfiguration(string schema)
        {
            ToTable("T_NoticiasPrincipal", schema);
            HasKey(x => x.IdNoticia);

            Property(x => x.IdNoticia).HasColumnName(@"IdNoticia").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TipoNoticia).HasColumnName(@"TipoNoticia").HasColumnType("tinyint").IsRequired();
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Noticia).HasColumnName(@"Noticia").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.FechaCreacion).HasColumnName(@"fechaCreacion").HasColumnType("datetime").IsRequired();
        }
    }
}