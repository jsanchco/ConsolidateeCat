namespace eCat.Repository.Mapped
{
    public class TTiposElementosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposElementosIdioma>
    {
        public TTiposElementosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposElementosIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposElementos_Idioma", schema);
            HasKey(x => new { x.IdTipoElemento, x.IdIdiomaInterface });

            Property(x => x.IdTipoElemento).HasColumnName(@"IdTipoElemento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}