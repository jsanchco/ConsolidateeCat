namespace eCat.Repository.Mapped
{
    public class TPortadasColaImageneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPortadasColaImagene>
    {
        public TPortadasColaImageneConfiguration()
            : this("dbo")
        {
        }

        public TPortadasColaImageneConfiguration(string schema)
        {
            ToTable("T_Portadas_ColaImagenes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.RutaImagen).HasColumnName(@"RutaImagen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdTipoImagen).HasColumnName(@"IdTipoImagen").HasColumnType("tinyint").IsOptional();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaInicioProceso).HasColumnName(@"FechaInicioProceso").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaFinProceso).HasColumnName(@"FechaFinProceso").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaError).HasColumnName(@"FechaError").HasColumnType("datetime").IsOptional();
            Property(x => x.Error).HasColumnName(@"Error").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.SiguienteAcceso).HasColumnName(@"SiguienteAcceso").HasColumnType("datetime").IsOptional();
        }
    }
}