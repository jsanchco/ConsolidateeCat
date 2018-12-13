namespace eCat.Repository.Mapped
{
    public class DilvePublicoObjetivoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilvePublicoObjetivo>
    {
        public DilvePublicoObjetivoConfiguration()
            : this("dbo")
        {
        }

        public DilvePublicoObjetivoConfiguration(string schema)
        {
            ToTable("DILVE_PublicoObjetivo", schema);
            HasKey(x => x.IdPublicoObjetivo);

            Property(x => x.IdPublicoObjetivo).HasColumnName(@"IdPublicoObjetivo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoPublicoObjetivo).HasColumnName(@"CodigoPublicoObjetivo").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}