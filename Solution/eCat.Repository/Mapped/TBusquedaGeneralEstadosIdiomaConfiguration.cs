namespace eCat.Repository.Mapped
{
    public class TBusquedaGeneralEstadosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TBusquedaGeneralEstadosIdioma>
    {
        public TBusquedaGeneralEstadosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TBusquedaGeneralEstadosIdiomaConfiguration(string schema)
        {
            ToTable("T_BusquedaGeneral_Estados_Idioma", schema);
            HasKey(x => new { x.IdEstadoBusqueda, x.IdIdiomaInterface });

            Property(x => x.IdEstadoBusqueda).HasColumnName(@"IdEstadoBusqueda").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TBusquedaGeneralEstado).WithMany(b => b.TBusquedaGeneralEstadosIdiomas).HasForeignKey(c => c.IdEstadoBusqueda).WillCascadeOnDelete(false); // FK_T_BusquedaGeneral_Estados_Idioma_T_BusquedaGeneral_Estados
        }
    }
}