namespace eCat.Repository.Mapped
{
    public class IdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Idioma>
    {
        public IdiomaConfiguration()
            : this("dbo")
        {
        }

        public IdiomaConfiguration(string schema)
        {
            ToTable("Idiomas", schema);
            HasKey(x => x.IdIdioma);

            Property(x => x.IdIdioma).HasColumnName(@"IDIdioma").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("nvarchar").IsOptional().HasMaxLength(3);
            Property(x => x.Es).HasColumnName(@"ES").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Cat).HasColumnName(@"CAT").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.En).HasColumnName(@"EN").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}