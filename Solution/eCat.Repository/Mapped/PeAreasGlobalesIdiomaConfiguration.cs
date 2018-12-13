namespace eCat.Repository.Mapped
{
    public class PeAreasGlobalesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeAreasGlobalesIdioma>
    {
        public PeAreasGlobalesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeAreasGlobalesIdiomaConfiguration(string schema)
        {
            ToTable("PE_AreasGlobales_Idioma", schema);
            HasKey(x => new { x.IdAreaGlobal, x.IdIdiomaInterface });

            Property(x => x.IdAreaGlobal).HasColumnName(@"IdAreaGlobal").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.PeAreasGlobale).WithMany(b => b.PeAreasGlobalesIdiomas).HasForeignKey(c => c.IdAreaGlobal).WillCascadeOnDelete(false); // FK_PE_AreasGlobales_Idioma_PE_AreasGlobales
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeAreasGlobalesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_AreasGlobales_Idioma_T_Idiomas_Plataforma
        }
    }
}