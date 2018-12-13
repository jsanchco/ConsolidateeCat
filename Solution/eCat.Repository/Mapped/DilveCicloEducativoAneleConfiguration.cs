namespace eCat.Repository.Mapped
{
    public class DilveCicloEducativoAneleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveCicloEducativoAnele>
    {
        public DilveCicloEducativoAneleConfiguration()
            : this("dbo")
        {
        }

        public DilveCicloEducativoAneleConfiguration(string schema)
        {
            ToTable("DILVE_CicloEducativoANELE", schema);
            HasKey(x => x.IdCicloEducaticoAnele);

            Property(x => x.IdCicloEducaticoAnele).HasColumnName(@"IdCicloEducaticoANELE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoCicloEducativoAnele).HasColumnName(@"CodigoCicloEducativoANELE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}