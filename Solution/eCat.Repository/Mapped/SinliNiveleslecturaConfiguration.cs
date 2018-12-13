namespace eCat.Repository.Mapped
{
    public class SinliNiveleslecturaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.SinliNiveleslectura>
    {
        public SinliNiveleslecturaConfiguration()
            : this("dbo")
        {
        }

        public SinliNiveleslecturaConfiguration(string schema)
        {
            ToTable("SINLI_NIVELESLECTURA", schema);
            HasKey(x => x.CodNivel);

            Property(x => x.CodNivel).HasColumnName(@"COD_NIVEL").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
        }
    }
}