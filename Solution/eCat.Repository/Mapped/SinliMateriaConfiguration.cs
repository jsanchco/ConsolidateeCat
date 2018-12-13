namespace eCat.Repository.Mapped
{
    public class SinliMateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliMateria>
    {
        public SinliMateriaConfiguration()
            : this("dbo")
        {
        }

        public SinliMateriaConfiguration(string schema)
        {
            ToTable("SINLI_MATERIAS", schema);
            HasKey(x => x.CodTprinc);

            Property(x => x.CodTprinc).HasColumnName(@"COD_TPRINC").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}