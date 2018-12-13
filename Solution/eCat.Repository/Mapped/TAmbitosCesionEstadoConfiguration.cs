namespace eCat.Repository.Mapped
{
    public class TAmbitosCesionEstadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAmbitosCesionEstado>
    {
        public TAmbitosCesionEstadoConfiguration()
            : this("dbo")
        {
        }

        public TAmbitosCesionEstadoConfiguration(string schema)
        {
            ToTable("T_AmbitosCesion_Estados", schema);
            HasKey(x => x.IdEstado);

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }
}