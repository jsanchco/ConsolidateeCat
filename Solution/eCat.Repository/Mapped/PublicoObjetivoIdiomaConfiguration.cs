namespace eCat.Repository.Mapped
{
    public class PublicoObjetivoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PublicoObjetivoIdioma>
    {
        public PublicoObjetivoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PublicoObjetivoIdiomaConfiguration(string schema)
        {
            ToTable("PublicoObjetivo_Idioma", schema);
            HasKey(x => new { x.IdPublicoObjetivo, x.IdIdiomaInterface });

            Property(x => x.IdPublicoObjetivo).HasColumnName(@"IDPublicoObjetivo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PublicoObjetivoIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PublicoObjetivo_Idioma_T_Idiomas_Plataforma
        }
    }
}