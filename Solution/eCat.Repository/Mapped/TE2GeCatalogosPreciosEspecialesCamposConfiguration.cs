namespace eCat.Repository.Mapped
{
    public class TE2GeCatalogosPreciosEspecialesCamposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TE2GeCatalogosPreciosEspecialesCampos>
    {
        public TE2GeCatalogosPreciosEspecialesCamposConfiguration()
            : this("dbo")
        {
        }

        public TE2GeCatalogosPreciosEspecialesCamposConfiguration(string schema)
        {
            ToTable("T_E2_GE_CATALOGOS_PreciosEspeciales_Campos", schema);
            HasKey(x => x.Campo);

            Property(x => x.Campo).HasColumnName(@"Campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(512);
        }
    }
}