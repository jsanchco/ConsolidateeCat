namespace eCat.Repository.Mapped
{
    public class TbDilveEquivalenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbDilveEquivalencia>
    {
        public TbDilveEquivalenciaConfiguration()
            : this("dbo")
        {
        }

        public TbDilveEquivalenciaConfiguration(string schema)
        {
            ToTable("TB_DILVE_EQUIVALENCIAS", schema);
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.SqlOrigen).HasColumnName(@"SQLOrigen").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.SqlDilve).HasColumnName(@"SQLDilve").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.Tabla).HasColumnName(@"Tabla").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CampoECat).HasColumnName(@"CampoECat").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CampoDilve).HasColumnName(@"CampoDilve").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.EsNumerico).HasColumnName(@"EsNumerico").HasColumnType("bit").IsRequired();
        }
    }
}