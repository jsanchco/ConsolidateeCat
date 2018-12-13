namespace eCat.Repository.Mapped
{
    public class TiposArticuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposArticulo>
    {
        public TiposArticuloConfiguration()
            : this("dbo")
        {
        }

        public TiposArticuloConfiguration(string schema)
        {
            ToTable("TiposArticulos", schema);
            HasKey(x => x.IdTipoArticulo);

            Property(x => x.IdTipoArticulo).HasColumnName(@"IDTipoArticulo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoArticulo).HasColumnName(@"TipoArticulo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}