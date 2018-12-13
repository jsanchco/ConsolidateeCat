namespace eCat.Repository.Mapped
{
    public class TGeneroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TGenero>
    {
        public TGeneroConfiguration()
            : this("dbo")
        {
        }

        public TGeneroConfiguration(string schema)
        {
            ToTable("T_Generos", schema);
            HasKey(x => x.IdGenero);

            Property(x => x.IdGenero).HasColumnName(@"IdGenero").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsOptional().HasMaxLength(225);
        }
    }
}