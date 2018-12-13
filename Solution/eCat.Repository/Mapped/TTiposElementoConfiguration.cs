namespace eCat.Repository.Mapped
{
    public class TTiposElementoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposElemento>
    {
        public TTiposElementoConfiguration()
            : this("dbo")
        {
        }

        public TTiposElementoConfiguration(string schema)
        {
            ToTable("T_TiposElementos", schema);
            HasKey(x => x.IdTipoElemento);

            Property(x => x.IdTipoElemento).HasColumnName(@"IdTipoElemento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoElemento).HasColumnName(@"TipoElemento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}