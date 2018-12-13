namespace eCat.Repository.Mapped
{
    public class E2DatosMinimosJerarquiaValoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2DatosMinimosJerarquiaValore>
    {
        public E2DatosMinimosJerarquiaValoreConfiguration()
            : this("dbo")
        {
        }

        public E2DatosMinimosJerarquiaValoreConfiguration(string schema)
        {
            ToTable("E2_DATOS_MINIMOS_JERARQUIA_VALORES", schema);
            HasKey(x => x.IdJerarquiaValor);

            Property(x => x.IdJerarquiaValor).HasColumnName(@"Id_Jerarquia_Valor").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CodigoValor).HasColumnName(@"Codigo_Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.E2DatosMinimosValore).WithMany(b => b.E2DatosMinimosJerarquiaValore).HasForeignKey(c => c.CodigoValor).WillCascadeOnDelete(false); // FK_E2_DATOS_MINIMOS_JERARQUIA_VALORES_E2_DATOS_MINIMOS_VALORES
        }
    }
}