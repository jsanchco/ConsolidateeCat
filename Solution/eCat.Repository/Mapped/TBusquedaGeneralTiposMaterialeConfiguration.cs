namespace eCat.Repository.Mapped
{
    public class TBusquedaGeneralTiposMaterialeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TBusquedaGeneralTiposMateriale>
    {
        public TBusquedaGeneralTiposMaterialeConfiguration()
            : this("dbo")
        {
        }

        public TBusquedaGeneralTiposMaterialeConfiguration(string schema)
        {
            ToTable("T_BusquedaGeneral_TiposMateriales", schema);
            HasKey(x => x.IdTipoMaterialBusqueda);

            Property(x => x.IdTipoMaterialBusqueda).HasColumnName(@"IdTipoMaterialBusqueda").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}