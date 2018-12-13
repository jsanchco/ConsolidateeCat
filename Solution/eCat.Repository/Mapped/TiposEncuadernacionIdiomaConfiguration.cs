namespace eCat.Repository.Mapped
{
    public class TiposEncuadernacionIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TiposEncuadernacionIdioma>
    {
        public TiposEncuadernacionIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TiposEncuadernacionIdiomaConfiguration(string schema)
        {
            ToTable("TiposEncuadernacion_Idioma", schema);
            HasKey(x => new { x.IdTipoEncuadernacion, x.IdIdiomaInterface });

            Property(x => x.IdTipoEncuadernacion).HasColumnName(@"IDTipoEncuadernacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TiposEncuadernacionIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_TiposEncuadernacion_Idioma_T_Idiomas_Plataforma
        }
    }
}