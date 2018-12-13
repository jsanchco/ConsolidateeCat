namespace eCat.Repository.Mapped
{
    public class FichasBaseIdiomasSecundarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseIdiomasSecundario>
    {
        public FichasBaseIdiomasSecundarioConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseIdiomasSecundarioConfiguration(string schema)
        {
            ToTable("FichasBase_IdiomasSecundarios", schema);
            HasKey(x => new { x.IdInterno, x.IdIdioma });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdioma).HasColumnName(@"IdIdioma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseIdiomasSecundarios).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_IdiomasSecundarios_FichasBase
            HasRequired(a => a.Idioma).WithMany(b => b.FichasBaseIdiomasSecundarios).HasForeignKey(c => c.IdIdioma).WillCascadeOnDelete(false); // FK_FichasBase_IdiomasSecundarios_Idiomas
        }
    }
}