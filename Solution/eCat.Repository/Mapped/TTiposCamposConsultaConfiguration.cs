namespace eCat.Repository.Mapped
{
    public class TTiposCamposConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposCamposConsulta>
    {
        public TTiposCamposConsultaConfiguration()
            : this("dbo")
        {
        }

        public TTiposCamposConsultaConfiguration(string schema)
        {
            ToTable("T_TiposCampos_Consultas", schema);
            HasKey(x => x.IdTipoCampo);

            Property(x => x.IdTipoCampo).HasColumnName(@"IdTipoCampo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoCampo).HasColumnName(@"TipoCampo").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}