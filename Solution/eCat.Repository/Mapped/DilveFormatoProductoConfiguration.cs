namespace eCat.Repository.Mapped
{
    public class DilveFormatoProductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveFormatoProducto>
    {
        public DilveFormatoProductoConfiguration()
            : this("dbo")
        {
        }

        public DilveFormatoProductoConfiguration(string schema)
        {
            ToTable("DILVE_FormatoProducto", schema);
            HasKey(x => x.IdFormatoProducto);

            Property(x => x.IdFormatoProducto).HasColumnName(@"IdFormatoProducto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoFormatoProducto).HasColumnName(@"CodigoFormatoProducto").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.TSoportes).WithMany(t => t.DilveFormatoProductoes).Map(m =>
            {
                m.ToTable("DILVE_Soportes_Equivalencias", "dbo");
                m.MapLeftKey("IdFormatoProducto");
                m.MapRightKey("IdSoporte");
            });
        }
    }
}