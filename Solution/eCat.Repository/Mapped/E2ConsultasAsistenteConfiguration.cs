namespace eCat.Repository.Mapped
{
    public class E2ConsultasAsistenteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ConsultasAsistente>
    {
        public E2ConsultasAsistenteConfiguration()
            : this("dbo")
        {
        }

        public E2ConsultasAsistenteConfiguration(string schema)
        {
            ToTable("E2_CONSULTAS_ASISTENTE", schema);
            HasKey(x => x.IdConsulta);

            Property(x => x.IdConsulta).HasColumnName(@"IdConsulta").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
        }
    }
}