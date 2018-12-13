namespace eCat.Repository.Mapped
{
    public class TZonasGeograficaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TZonasGeografica>
    {
        public TZonasGeograficaConfiguration()
            : this("dbo")
        {
        }

        public TZonasGeograficaConfiguration(string schema)
        {
            ToTable("T_ZonasGeograficas", schema);
            HasKey(x => x.IdZonaGeografica);

            Property(x => x.IdZonaGeografica).HasColumnName(@"IdZonaGeografica").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdDominio).HasColumnName(@"IdDominio").HasColumnType("smallint").IsRequired();
        }
    }
}