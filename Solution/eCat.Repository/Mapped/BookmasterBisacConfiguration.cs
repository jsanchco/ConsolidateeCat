namespace eCat.Repository.Mapped
{
    public class BookmasterBisacConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.BookmasterBisac>
    {
        public BookmasterBisacConfiguration()
            : this("dbo")
        {
        }

        public BookmasterBisacConfiguration(string schema)
        {
            ToTable("BOOKMASTER_Bisac", schema);
            HasKey(x => x.IdBisac);

            Property(x => x.IdBisac).HasColumnName(@"IdBisac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            HasMany(t => t.ClasificacionEcis).WithMany(t => t.BookmasterBisacs).Map(m =>
            {
                m.ToTable("BOOKMASTER_Bisac_Bic_Equivalencias", "dbo");
                m.MapLeftKey("IdBisac");
                m.MapRightKey("IdClasificacionECI");
            });
        }
    }
}