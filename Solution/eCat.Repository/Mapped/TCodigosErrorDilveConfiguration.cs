namespace eCat.Repository.Mapped
{
    public class TCodigosErrorDilveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TCodigosErrorDilve>
    {
        public TCodigosErrorDilveConfiguration()
            : this("dbo")
        {
        }

        public TCodigosErrorDilveConfiguration(string schema)
        {
            ToTable("T_CodigosError_DILVE", schema);
            HasKey(x => x.IdError);

            Property(x => x.IdError).HasColumnName(@"IdError").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}