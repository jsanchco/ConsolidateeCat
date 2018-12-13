namespace eCat.Repository.Mapped
{
    public class TFasesMaterialIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFasesMaterialIdioma>
    {
        public TFasesMaterialIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TFasesMaterialIdiomaConfiguration(string schema)
        {
            ToTable("T_FasesMaterial_Idioma", schema);
            HasKey(x => new { x.IdFase, x.IdidiomaInterface });

            Property(x => x.IdFase).HasColumnName(@"IdFase").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdidiomaInterface).HasColumnName(@"IdidiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TFasesMaterialIdiomas).HasForeignKey(c => c.IdidiomaInterface).WillCascadeOnDelete(false); // FK_T_FasesMaterial_Idioma_T_Idiomas_Plataforma
        }
    }
}