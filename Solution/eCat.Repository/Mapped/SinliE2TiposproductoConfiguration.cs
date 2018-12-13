namespace eCat.Repository.Mapped
{
    public class SinliE2TiposproductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliE2Tiposproducto>
    {
        public SinliE2TiposproductoConfiguration()
            : this("dbo")
        {
        }

        public SinliE2TiposproductoConfiguration(string schema)
        {
            ToTable("SINLI_E2_TIPOSPRODUCTO", schema);
            HasKey(x => x.IdTipoArticulo);

            Property(x => x.CodTprod).HasColumnName(@"COD_TPROD").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.IdTipoArticulo).HasColumnName(@"IDTipoArticulo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}