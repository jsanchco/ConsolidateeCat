namespace eCat.Repository.Mapped
{
    public class VwProductosrelacionadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.VwProductosrelacionado>
    {
        public VwProductosrelacionadoConfiguration()
            : this("dbo")
        {
        }

        public VwProductosrelacionadoConfiguration(string schema)
        {
            ToTable("vw_Productosrelacionados", schema);
            HasKey(x => new { x.IdInterno, x.IdRelacionado });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelacionado).HasColumnName(@"IdRelacionado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
