namespace eCat.Repository.Mapped
{
    public class PremiosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PremiosIdioma>
    {
        public PremiosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PremiosIdiomaConfiguration(string schema)
        {
            ToTable("Premios_Idioma", schema);
            HasKey(x => new { x.IdPremio, x.IdIdiomaInterface });

            Property(x => x.IdPremio).HasColumnName(@"IDPremio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PremiosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_Premios_Idioma_T_Idiomas_Plataforma
        }
    }
}