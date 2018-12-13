namespace eCat.Repository.Mapped
{
    public class E2CamposConsultaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2CamposConsulta>
    {
        public E2CamposConsultaConfiguration()
            : this("dbo")
        {
        }

        public E2CamposConsultaConfiguration(string schema)
        {
            ToTable("E2_CAMPOS_CONSULTA", schema);
            HasKey(x => x.CodCampo);

            Property(x => x.CodConsulta).HasColumnName(@"COD_CONSULTA").HasColumnType("tinyint").IsRequired();
            Property(x => x.CodCampo).HasColumnName(@"COD_CAMPO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DesCampo).HasColumnName(@"DES_CAMPO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CampoBbdd).HasColumnName(@"CAMPO_BBDD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.TipoCampo).HasColumnName(@"TIPO_CAMPO").HasColumnType("tinyint").IsRequired();
            Property(x => x.Listasql).HasColumnName(@"LISTASQL").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Aplicar).HasColumnName(@"APLICAR").HasColumnType("bit").IsRequired();
            Property(x => x.CampoWhere).HasColumnName(@"CAMPO_WHERE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Mostrar).HasColumnName(@"MOSTRAR").HasColumnType("bit").IsRequired();
            Property(x => x.CampoSelect).HasColumnName(@"CAMPO_SELECT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CampoCalculado).HasColumnName(@"CAMPO_CALCULADO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.EsCodigoLibro).HasColumnName(@"EsCodigoLibro").HasColumnType("bit").IsRequired();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsOptional();
        }
    }
}