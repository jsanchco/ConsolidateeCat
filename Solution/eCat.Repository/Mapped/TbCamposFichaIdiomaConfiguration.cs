namespace eCat.Repository.Mapped
{
    public class TbCamposFichaIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TbCamposFichaIdioma>
    {
        public TbCamposFichaIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TbCamposFichaIdiomaConfiguration(string schema)
        {
            ToTable("TB_Campos_Ficha_Idioma", schema);
            HasKey(x => new { x.IdCampo, x.IdIdiomaInterface });

            Property(x => x.IdCampo).HasColumnName(@"ID_CAMPO").HasColumnType("numeric").IsRequired().HasPrecision(18,0).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}