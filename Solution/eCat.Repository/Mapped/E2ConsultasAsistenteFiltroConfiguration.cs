namespace eCat.Repository.Mapped
{
    public class E2ConsultasAsistenteFiltroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ConsultasAsistenteFiltro>
    {
        public E2ConsultasAsistenteFiltroConfiguration()
            : this("dbo")
        {
        }

        public E2ConsultasAsistenteFiltroConfiguration(string schema)
        {
            ToTable("E2_CONSULTAS_ASISTENTE_FILTROS", schema);
            HasKey(x => x.IdConsultaAsistenteFiltro);

            Property(x => x.IdConsultaAsistenteFiltro).HasColumnName(@"IdConsultaAsistenteFiltro").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdConsulta).HasColumnName(@"IdConsulta").HasColumnType("numeric").IsRequired().HasPrecision(18,0);
            Property(x => x.IsNot).HasColumnName(@"IsNot").HasColumnType("bit").IsRequired();
            Property(x => x.CodCampo).HasColumnName(@"CodCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.CodOperacion).HasColumnName(@"CodOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.CodCriterio).HasColumnName(@"CodCriterio").HasColumnType("tinyint").IsOptional();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValorFiltro).HasColumnName(@"ValorFiltro").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);

            // Foreign keys
            HasRequired(a => a.E2ConsultasAsistente).WithMany(b => b.E2ConsultasAsistenteFiltro).HasForeignKey(c => c.IdConsulta).WillCascadeOnDelete(false); // FK_E2_CONSULTAS_ASISTENTE_FILTROS_E2_CONSULTAS_ASISTENTE
        }
    }
}