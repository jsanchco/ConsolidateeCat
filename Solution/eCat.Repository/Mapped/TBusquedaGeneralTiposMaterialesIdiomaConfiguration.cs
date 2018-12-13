namespace eCat.Repository.Mapped
{
    public class TBusquedaGeneralTiposMaterialesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TBusquedaGeneralTiposMaterialesIdioma>
    {
        public TBusquedaGeneralTiposMaterialesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TBusquedaGeneralTiposMaterialesIdiomaConfiguration(string schema)
        {
            ToTable("T_BusquedaGeneral_TiposMateriales_Idioma", schema);
            HasKey(x => new { x.IdTipoMaterialBusqueda, x.IdIdiomaInterface });

            Property(x => x.IdTipoMaterialBusqueda).HasColumnName(@"IdTipoMaterialBusqueda").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TBusquedaGeneralTiposMateriale).WithMany(b => b.TBusquedaGeneralTiposMaterialesIdiomas).HasForeignKey(c => c.IdTipoMaterialBusqueda).WillCascadeOnDelete(false); // FK_T_BusquedaGeneral_TiposMateriales_Idioma_T_BusquedaGeneral_TiposMateriales
        }
    }
}