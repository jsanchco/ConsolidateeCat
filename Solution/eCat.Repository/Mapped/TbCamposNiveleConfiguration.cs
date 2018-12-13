namespace eCat.Repository.Mapped
{
    public class TbCamposNiveleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbCamposNivele>
    {
        public TbCamposNiveleConfiguration()
            : this("dbo")
        {
        }

        public TbCamposNiveleConfiguration(string schema)
        {
            ToTable("TB_CAMPOS_NIVELES", schema);
            HasKey(x => x.NivelTag);

            Property(x => x.NivelTag).HasColumnName(@"NivelTag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FromTabla).HasColumnName(@"FromTabla").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.NombreTag).HasColumnName(@"NombreTag").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.WhereIdInterno).HasColumnName(@"WhereIDInterno").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.WhereIdCatalogo).HasColumnName(@"WhereIDCatalogo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }
}