namespace eCat.Repository.Mapped
{
    public class ClasificacionEciConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.ClasificacionEci>
    {
        public ClasificacionEciConfiguration()
            : this("dbo")
        {
        }

        public ClasificacionEciConfiguration(string schema)
        {
            ToTable("Clasificacion_ECI", schema);
            HasKey(x => x.IdClasificacionEci);

            Property(x => x.IdClasificacionEci).HasColumnName(@"IDClasificacionECI").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPadre).HasColumnName(@"IdPadre").HasColumnType("int").IsOptional();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();
            Property(x => x.Nivelador).HasColumnName(@"Nivelador").HasColumnType("bit").IsRequired();
        }
    }
}