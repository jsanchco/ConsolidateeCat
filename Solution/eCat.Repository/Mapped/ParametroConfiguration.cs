namespace eCat.Repository.Mapped
{
    public class ParametroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Parametro>
    {
        public ParametroConfiguration()
            : this("dbo")
        {
        }

        public ParametroConfiguration(string schema)
        {
            ToTable("Parametros", schema);
            HasKey(x => x.Parametro_);

            Property(x => x.Parametro_).HasColumnName(@"Parametro").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
        }
    }
}