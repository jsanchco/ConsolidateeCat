namespace eCat.Repository.Mapped
{
    public class TBusquedaGeneralEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TBusquedaGeneralEstado>
    {
        public TBusquedaGeneralEstadoConfiguration()
            : this("dbo")
        {
        }

        public TBusquedaGeneralEstadoConfiguration(string schema)
        {
            ToTable("T_BusquedaGeneral_Estados", schema);
            HasKey(x => x.IdEstadoBusqueda);

            Property(x => x.IdEstadoBusqueda).HasColumnName(@"IdEstadoBusqueda").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}