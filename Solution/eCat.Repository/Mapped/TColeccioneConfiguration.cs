namespace eCat.Repository.Mapped
{
    public class TColeccioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TColeccione>
    {
        public TColeccioneConfiguration()
            : this("dbo")
        {
        }

        public TColeccioneConfiguration(string schema)
        {
            ToTable("T_Colecciones", schema);
            HasKey(x => x.IdColeccion);

            Property(x => x.IdColeccion).HasColumnName(@"IdColeccion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();
            HasMany(t => t.LineaNegocios).WithMany(t => t.TColecciones).Map(m =>
            {
                m.ToTable("T_Colecciones_LineasNegocio", "dbo");
                m.MapLeftKey("IdColeccion");
                m.MapRightKey("IdLineaNegocio");
            });
        }
    }
}