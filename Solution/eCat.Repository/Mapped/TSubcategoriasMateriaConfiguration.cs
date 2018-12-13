namespace eCat.Repository.Mapped
{
    public class TSubcategoriasMateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TSubcategoriasMateria>
    {
        public TSubcategoriasMateriaConfiguration()
            : this("dbo")
        {
        }

        public TSubcategoriasMateriaConfiguration(string schema)
        {
            ToTable("T_SubcategoriasMaterias", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdSubcategoriaMateria).HasColumnName(@"IdSubcategoriaMateria").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
        }
    }
}