namespace eCat.Repository.Mapped
{
    public class TSoporteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TSoporte>
    {
        public TSoporteConfiguration()
            : this("dbo")
        {
        }

        public TSoporteConfiguration(string schema)
        {
            ToTable("T_Soportes", schema);
            HasKey(x => x.IdSoporte);

            Property(x => x.IdSoporte).HasColumnName(@"IdSoporte").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Soporte).HasColumnName(@"Soporte").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
        }
    }
}