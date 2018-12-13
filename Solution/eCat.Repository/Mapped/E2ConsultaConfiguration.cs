namespace eCat.Repository.Mapped
{
    public class E2ConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2Consulta>
    {
        public E2ConsultaConfiguration()
            : this("dbo")
        {
        }

        public E2ConsultaConfiguration(string schema)
        {
            ToTable("E2_CONSULTAS", schema);
            HasKey(x => new { x.CodConsulta, x.Usuario });

            Property(x => x.CodTipoConsulta).HasColumnName(@"COD_TIPO_CONSULTA").HasColumnType("tinyint").IsRequired();
            Property(x => x.CodConsulta).HasColumnName(@"COD_CONSULTA").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DesConsulta).HasColumnName(@"DES_CONSULTA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Usuario).HasColumnName(@"USUARIO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}