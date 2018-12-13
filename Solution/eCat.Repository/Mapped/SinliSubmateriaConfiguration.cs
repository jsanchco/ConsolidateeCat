namespace eCat.Repository.Mapped
{
    public class SinliSubmateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliSubmateria>
    {
        public SinliSubmateriaConfiguration()
            : this("dbo")
        {
        }

        public SinliSubmateriaConfiguration(string schema)
        {
            ToTable("SINLI_SUBMATERIAS", schema);
            HasKey(x => x.CodTsec);

            Property(x => x.CodTsec).HasColumnName(@"COD_TSEC").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodTprinc).HasColumnName(@"COD_TPRINC").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}