namespace eCat.Repository.Mapped
{
    public class E2DatosMinimosJerarquiaCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2DatosMinimosJerarquiaCampos>
    {
        public E2DatosMinimosJerarquiaCamposConfiguration()
            : this("dbo")
        {
        }

        public E2DatosMinimosJerarquiaCamposConfiguration(string schema)
        {
            ToTable("E2_DATOS_MINIMOS_JERARQUIA_CAMPOS", schema);
            HasKey(x => new { x.IdClasificacion, x.CodigoCampo });

            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoCampo).HasColumnName(@"Codigo_Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.E2DatosMinimosCampos).WithMany(b => b.E2DatosMinimosJerarquiaCampos).HasForeignKey(c => c.CodigoCampo).WillCascadeOnDelete(false); // FK_E2_DATOS_MINIMOS_JERARQUIA_CAMPOS_E2_DATOS_MINIMOS_CAMPOS
        }
    }
}