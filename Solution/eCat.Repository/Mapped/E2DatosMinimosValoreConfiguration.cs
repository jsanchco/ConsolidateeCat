namespace eCat.Repository.Mapped
{
    public class E2DatosMinimosValoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2DatosMinimosValore>
    {
        public E2DatosMinimosValoreConfiguration()
            : this("dbo")
        {
        }

        public E2DatosMinimosValoreConfiguration(string schema)
        {
            ToTable("E2_DATOS_MINIMOS_VALORES", schema);
            HasKey(x => x.CodigoValor);

            Property(x => x.CodigoValor).HasColumnName(@"Codigo_Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripcionValor).HasColumnName(@"Descripcion_Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.SqlValor).HasColumnName(@"Sql_Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }
}