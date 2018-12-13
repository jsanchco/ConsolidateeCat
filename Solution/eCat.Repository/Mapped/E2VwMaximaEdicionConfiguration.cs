namespace eCat.Repository.Mapped
{
    public class E2VwMaximaEdicionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2VwMaximaEdicion>
    {
        public E2VwMaximaEdicionConfiguration()
            : this("dbo")
        {
        }

        public E2VwMaximaEdicionConfiguration(string schema)
        {
            ToTable("E2_vw_MaximaEdicion", schema);
            HasKey(x => x.IdInterno);

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MaximaEdicion).HasColumnName(@"MaximaEdicion").HasColumnType("tinyint").IsOptional();
        }
    }
}