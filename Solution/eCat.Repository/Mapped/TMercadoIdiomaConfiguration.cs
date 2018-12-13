namespace eCat.Repository.Mapped
{
    public class TMercadoIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TMercadoIdioma>
    {
        public TMercadoIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TMercadoIdiomaConfiguration(string schema)
        {
            ToTable("T_Mercado_Idioma", schema);
            HasKey(x => new { x.Codigo, x.IdIdiomaInterface });

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TMercadoIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Mercado_Idioma_T_Idiomas_Plataforma
        }
    }
}