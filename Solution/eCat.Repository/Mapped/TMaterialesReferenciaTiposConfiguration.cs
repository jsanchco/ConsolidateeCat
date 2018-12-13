namespace eCat.Repository.Mapped
{
    public class TMaterialesReferenciaTiposConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TMaterialesReferenciaTipos>
    {
        public TMaterialesReferenciaTiposConfiguration()
            : this("dbo")
        {
        }

        public TMaterialesReferenciaTiposConfiguration(string schema)
        {
            ToTable("T_MaterialesReferencia_Tipos", schema);
            HasKey(x => x.IdTipoMaterialReferencia);

            Property(x => x.IdTipoMaterialReferencia).HasColumnName(@"IdTipoMaterialReferencia").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoMaterialReferencia).HasColumnName(@"TipoMaterialReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}