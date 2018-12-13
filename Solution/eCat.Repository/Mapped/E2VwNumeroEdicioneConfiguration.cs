namespace eCat.Repository.Mapped
{
    public class E2VwNumeroEdicioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2VwNumeroEdicione>
    {
        public E2VwNumeroEdicioneConfiguration()
            : this("dbo")
        {
        }

        public E2VwNumeroEdicioneConfiguration(string schema)
        {
            ToTable("E2_vw_NumeroEdiciones", schema);
            HasKey(x => x.IdInterno);

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumeroEdiciones).HasColumnName(@"NumeroEdiciones").HasColumnType("int").IsOptional();
        }
    }
}