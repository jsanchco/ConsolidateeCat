namespace eCat.Repository.Mapped
{
    public class TbCamposOrdenConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbCamposOrden>
    {
        public TbCamposOrdenConfiguration()
            : this("dbo")
        {
        }

        public TbCamposOrdenConfiguration(string schema)
        {
            ToTable("TB_CAMPOS_ORDEN", schema);
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}