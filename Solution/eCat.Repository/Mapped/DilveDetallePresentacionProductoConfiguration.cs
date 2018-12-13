namespace eCat.Repository.Mapped
{
    public class DilveDetallePresentacionProductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveDetallePresentacionProducto>
    {
        public DilveDetallePresentacionProductoConfiguration()
            : this("dbo")
        {
        }

        public DilveDetallePresentacionProductoConfiguration(string schema)
        {
            ToTable("DILVE_DetallePresentacionProducto", schema);
            HasKey(x => x.IdDetallePresentacionProducto);

            Property(x => x.IdDetallePresentacionProducto).HasColumnName(@"IdDetallePresentacionProducto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoDetallePresentacionProducto).HasColumnName(@"CodigoDetallePresentacionProducto").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}