namespace eCat.Repository.Mapped
{
    public class SinliTiposproductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliTiposproducto>
    {
        public SinliTiposproductoConfiguration()
            : this("dbo")
        {
        }

        public SinliTiposproductoConfiguration(string schema)
        {
            ToTable("SINLI_TIPOSPRODUCTO", schema);
            HasKey(x => x.CodTprod);

            Property(x => x.CodTprod).HasColumnName(@"COD_TPROD").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
        }
    }
}