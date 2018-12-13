namespace eCat.Repository.Mapped
{
    public class PeComponentesFormatosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeComponentesFormatosIdioma>
    {
        public PeComponentesFormatosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeComponentesFormatosIdiomaConfiguration(string schema)
        {
            ToTable("PE_Componentes_Formatos_Idioma", schema);
            HasKey(x => new { x.IdFormato, x.IdIdiomaInterface });

            Property(x => x.IdFormato).HasColumnName(@"IdFormato").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.PeComponentesFormato).WithMany(b => b.PeComponentesFormatosIdiomas).HasForeignKey(c => c.IdFormato).WillCascadeOnDelete(false); // FK_PE_Componentes_Formatos_Idioma_PE_Componentes_Formatos
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeComponentesFormatosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_Componentes_Formatos_Idioma_T_Idiomas_Plataforma
        }
    }
}