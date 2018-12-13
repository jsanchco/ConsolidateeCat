namespace eCat.Repository.Mapped
{
    public class DilveDrmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveDrm>
    {
        public DilveDrmConfiguration()
            : this("dbo")
        {
        }

        public DilveDrmConfiguration(string schema)
        {
            ToTable("DILVE_DRM", schema);
            HasKey(x => x.IdDrmdilve);

            Property(x => x.IdDrmdilve).HasColumnName(@"IdDRMDILVE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoDrm).HasColumnName(@"CodigoDRM").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}