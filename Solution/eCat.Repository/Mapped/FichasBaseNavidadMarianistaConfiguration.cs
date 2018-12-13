namespace eCat.Repository.Mapped
{
    public class FichasBaseNavidadMarianistaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseNavidadMarianista>
    {
        public FichasBaseNavidadMarianistaConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseNavidadMarianistaConfiguration(string schema)
        {
            ToTable("FichasBase_NavidadMarianista", schema);
            HasKey(x => x.IdInterno);

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Editorial).HasColumnName(@"Editorial").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }
}