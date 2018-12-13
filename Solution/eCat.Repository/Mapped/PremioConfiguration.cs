namespace eCat.Repository.Mapped
{
    public class PremioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Premio>
    {
        public PremioConfiguration()
            : this("dbo")
        {
        }

        public PremioConfiguration(string schema)
        {
            ToTable("Premios", schema);
            HasKey(x => x.IdPremio);

            Property(x => x.IdPremio).HasColumnName(@"IDPremio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Premio_).HasColumnName(@"Premio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}