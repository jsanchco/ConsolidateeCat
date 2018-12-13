namespace eCat.Repository.Mapped
{
    public class DilveComunidadAutonomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveComunidadAutonoma>
    {
        public DilveComunidadAutonomaConfiguration()
            : this("dbo")
        {
        }

        public DilveComunidadAutonomaConfiguration(string schema)
        {
            ToTable("DILVE_ComunidadAutonoma", schema);
            HasKey(x => x.IdComunidadAutonoma);

            Property(x => x.IdComunidadAutonoma).HasColumnName(@"IdComunidadAutonoma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoComunidadAutonoma).HasColumnName(@"CodigoComunidadAutonoma").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            HasMany(t => t.TZonasGeograficas).WithMany(t => t.DilveComunidadAutonomas).Map(m =>
            {
                m.ToTable("DILVE_ComunidadAutonoma_Equivalencias", "dbo");
                m.MapLeftKey("IdComunidadAutonoma");
                m.MapRightKey("IdZonaGeografica");
            });
        }
    }
}