namespace eCat.Repository.Mapped
{
    public class E2GeTiponodoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeTiponodoIdioma>
    {
        public E2GeTiponodoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2GeTiponodoIdiomaConfiguration(string schema)
        {
            ToTable("E2_GE_TIPONODO_Idioma", schema);
            HasKey(x => new { x.IdTiponodo, x.IdIdiomaInterface });

            Property(x => x.IdTiponodo).HasColumnName(@"ID_TIPONODO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}