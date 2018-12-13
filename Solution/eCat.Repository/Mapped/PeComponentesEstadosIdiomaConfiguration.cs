namespace eCat.Repository.Mapped
{
    public class PeComponentesEstadosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesEstadosIdioma>
    {
        public PeComponentesEstadosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesEstadosIdiomaConfiguration(string schema)
        {
            ToTable("PE_Componentes_Estados_Idioma", schema);
            HasKey(x => new { x.IdEstado, x.IdIdiomaInterface });

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.PeComponentesEstado).WithMany(b => b.PeComponentesEstadosIdiomas).HasForeignKey(c => c.IdEstado).WillCascadeOnDelete(false); // FK_PE_Componentes_Estados_Idioma_PE_Componentes_Estados
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeComponentesEstadosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_Componentes_Estados_Idioma_T_Idiomas_Plataforma
        }
    }
}