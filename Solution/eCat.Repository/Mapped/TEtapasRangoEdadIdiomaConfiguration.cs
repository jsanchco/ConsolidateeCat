namespace eCat.Repository.Mapped
{
    public class TEtapasRangoEdadIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TEtapasRangoEdadIdioma>
    {
        public TEtapasRangoEdadIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TEtapasRangoEdadIdiomaConfiguration(string schema)
        {
            ToTable("T_EtapasRangoEdad_Idioma", schema);
            HasKey(x => new { x.Codigo, x.IdIdiomaInterface });

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TEtapasRangoEdadIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_EtapasRangoEdad_Idioma_T_Idiomas_Plataforma
        }
    }
}