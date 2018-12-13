namespace eCat.Repository.Mapped
{
    public class DilveFormatoSoporteDigitalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveFormatoSoporteDigital>
    {
        public DilveFormatoSoporteDigitalConfiguration()
            : this("dbo")
        {
        }

        public DilveFormatoSoporteDigitalConfiguration(string schema)
        {
            ToTable("DILVE_FormatoSoporteDigital", schema);
            HasKey(x => x.IdFormatoSoporteDigital);

            Property(x => x.IdFormatoSoporteDigital).HasColumnName(@"IdFormatoSoporteDigital").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoFormatoSoporteDigital).HasColumnName(@"CodigoFormatoSoporteDigital").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.TiposEncuadernacions).WithMany(t => t.DilveFormatoSoporteDigitals).Map(m =>
            {
                m.ToTable("DILVE_FormatoSoporteDigital_Equivalencias", "dbo");
                m.MapLeftKey("IdFormatoSoporteDigital");
                m.MapRightKey("IdTipoEncuadernacion");
            });
        }
    }
}