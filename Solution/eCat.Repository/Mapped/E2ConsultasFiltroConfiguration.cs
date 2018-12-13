namespace eCat.Repository.Mapped
{
    public class E2ConsultasFiltroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ConsultasFiltro>
    {
        public E2ConsultasFiltroConfiguration()
            : this("dbo")
        {
        }

        public E2ConsultasFiltroConfiguration(string schema)
        {
            ToTable("E2_CONSULTAS_FILTROS", schema);
            HasKey(x => x.IdConsultaFiltro);

            Property(x => x.IdConsultaFiltro).HasColumnName(@"IdConsultaFiltro").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CodConsulta).HasColumnName(@"COD_CONSULTA").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.CodUsuario).HasColumnName(@"COD_USUARIO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CodCampo).HasColumnName(@"COD_CAMPO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.CodOperacion).HasColumnName(@"COD_OPERACION").HasColumnType("tinyint").IsRequired();
            Property(x => x.Valor).HasColumnName(@"VALOR").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.CodCriterio).HasColumnName(@"COD_CRITERIO").HasColumnType("tinyint").IsOptional();
            Property(x => x.Orden).HasColumnName(@"ORDEN").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValorFiltro).HasColumnName(@"ValorFiltro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
        }
    }
}