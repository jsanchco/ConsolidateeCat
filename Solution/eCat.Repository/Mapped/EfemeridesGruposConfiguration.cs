namespace eCat.Repository.Mapped
{
    public class EfemeridesGruposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.EfemeridesGrupos>
    {
        public EfemeridesGruposConfiguration()
            : this("dbo")
        {
        }

        public EfemeridesGruposConfiguration(string schema)
        {
            ToTable("EfemeridesGrupos", schema);
            HasKey(x => x.IdGrupoEfemeride);

            Property(x => x.IdGrupoEfemeride).HasColumnName(@"IDGrupoEfemeride").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}