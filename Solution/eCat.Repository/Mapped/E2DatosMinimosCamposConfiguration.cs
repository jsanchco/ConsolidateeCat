namespace eCat.Repository.Mapped
{
    public class E2DatosMinimosCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2DatosMinimosCampos>
    {
        public E2DatosMinimosCamposConfiguration()
            : this("dbo")
        {
        }

        public E2DatosMinimosCamposConfiguration(string schema)
        {
            ToTable("E2_DATOS_MINIMOS_CAMPOS", schema);
            HasKey(x => x.CodigoCampo);

            Property(x => x.CodigoCampo).HasColumnName(@"Codigo_Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripcionCampo).HasColumnName(@"Descripcion_Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Defecto).HasColumnName(@"Defecto").HasColumnType("bit").IsRequired();
            Property(x => x.Bloqueado).HasColumnName(@"Bloqueado").HasColumnType("bit").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();
            HasMany(t => t.E2DatosMinimosJerarquiaValore).WithMany(t => t.E2DatosMinimosCampos).Map(m =>
            {
                m.ToTable("E2_DATOS_MINIMOS_CAMPOS_VALORES", "dbo");
                m.MapLeftKey("Codigo_Campo");
                m.MapRightKey("Id_Jerarquia_Valor");
            });
        }
    }
}