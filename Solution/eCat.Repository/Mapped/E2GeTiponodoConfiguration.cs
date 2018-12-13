namespace eCat.Repository.Mapped
{
    public class E2GeTiponodoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2GeTiponodo>
    {
        public E2GeTiponodoConfiguration()
            : this("dbo")
        {
        }

        public E2GeTiponodoConfiguration(string schema)
        {
            ToTable("E2_GE_TIPONODO", schema);
            HasKey(x => x.IdTiponodo);

            Property(x => x.IdTiponodo).HasColumnName(@"ID_TIPONODO").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}