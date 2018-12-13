namespace eCat.Repository.Mapped
{
    public class PeComponentesTiposIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesTiposIdioma>
    {
        public PeComponentesTiposIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesTiposIdiomaConfiguration(string schema)
        {
            ToTable("PE_Componentes_Tipos_Idioma", schema);
            HasKey(x => new { x.IdTipo, x.IdIdiomaInterface });

            Property(x => x.IdTipo).HasColumnName(@"IdTipo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ValorCorto).HasColumnName(@"ValorCorto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);

            // Foreign keys
            HasRequired(a => a.PeComponentesTipos).WithMany(b => b.PeComponentesTiposIdiomas).HasForeignKey(c => c.IdTipo).WillCascadeOnDelete(false); // FK_PE_Componentes_Tipos_Idioma_PE_Componentes_Tipos
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeComponentesTiposIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_Componentes_Tipos_Idioma_T_Idiomas_Plataforma
        }
    }
}