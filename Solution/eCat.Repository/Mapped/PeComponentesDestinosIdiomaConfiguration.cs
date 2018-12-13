namespace eCat.Repository.Mapped
{
    public class PeComponentesDestinosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesDestinosIdioma>
    {
        public PeComponentesDestinosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesDestinosIdiomaConfiguration(string schema)
        {
            ToTable("PE_Componentes_Destinos_Idioma", schema);
            HasKey(x => new { x.IdDestino, x.IdIdiomaInterface });

            Property(x => x.IdDestino).HasColumnName(@"IdDestino").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ValorCorto).HasColumnName(@"ValorCorto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.PeComponentesDestino).WithMany(b => b.PeComponentesDestinosIdiomas).HasForeignKey(c => c.IdDestino).WillCascadeOnDelete(false); // FK_PE_Componentes_Destinos_Idioma_PE_Componentes_Destinos
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeComponentesDestinosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_Componentes_Destinos_Idioma_T_Idiomas_Plataforma
        }
    }
}