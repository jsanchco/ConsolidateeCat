namespace eCat.Repository.Mapped
{
    public class DilveNivelEducativoAneleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveNivelEducativoAnele>
    {
        public DilveNivelEducativoAneleConfiguration()
            : this("dbo")
        {
        }

        public DilveNivelEducativoAneleConfiguration(string schema)
        {
            ToTable("DILVE_NivelEducativoANELE", schema);
            HasKey(x => x.IdNivelEducaticoAnele);

            Property(x => x.IdNivelEducaticoAnele).HasColumnName(@"IdNivelEducaticoANELE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoNivelEducativoAnele).HasColumnName(@"CodigoNivelEducativoANELE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}