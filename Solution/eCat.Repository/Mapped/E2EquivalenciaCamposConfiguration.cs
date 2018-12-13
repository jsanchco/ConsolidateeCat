namespace eCat.Repository.Mapped
{
    public class E2EquivalenciaCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2EquivalenciaCampos>
    {
        public E2EquivalenciaCamposConfiguration()
            : this("dbo")
        {
        }

        public E2EquivalenciaCamposConfiguration(string schema)
        {
            ToTable("E2_EQUIVALENCIA_CAMPOS", schema);
            HasKey(x => x.CodigoCampo);

            Property(x => x.CodigoCampo).HasColumnName(@"CodigoCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripcionCampo).HasColumnName(@"DescripcionCampo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.SqlValor).HasColumnName(@"SqlValor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4000);
        }
    }
}