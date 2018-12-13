namespace eCat.Repository.Mapped
{
    public class TCategoriasCiclosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TCategoriasCiclosIdioma>
    {
        public TCategoriasCiclosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TCategoriasCiclosIdiomaConfiguration(string schema)
        {
            ToTable("T_CategoriasCiclos_Idioma", schema);
            HasKey(x => new { x.Codigo, x.IdIdiomaInterface });

            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TCategoriasCiclosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_CategoriasCiclos_Idioma_T_Idiomas_Plataforma
        }
    }
}