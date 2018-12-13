namespace eCat.Repository.Mapped
{
    public class TIdiomasPlataformaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TIdiomasPlataforma>
    {
        public TIdiomasPlataformaConfiguration()
            : this("dbo")
        {
        }

        public TIdiomasPlataformaConfiguration(string schema)
        {
            ToTable("T_Idiomas_Plataforma", schema);
            HasKey(x => x.IdIdiomaPlataforma);

            Property(x => x.IdIdiomaPlataforma).HasColumnName(@"IdIdiomaPlataforma").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoIdioma).HasColumnName(@"CodigoIdioma").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DescripcionIdioma).HasColumnName(@"DescripcionIdioma").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.EsInterface).HasColumnName(@"EsInterface").HasColumnType("bit").IsRequired();
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();
        }
    }
}