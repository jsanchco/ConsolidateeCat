namespace eCat.Repository.Mapped
{
    public class TDrmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TDrm>
    {
        public TDrmConfiguration()
            : this("dbo")
        {
        }

        public TDrmConfiguration(string schema)
        {
            ToTable("T_DRM", schema);
            HasKey(x => x.IdDrm);

            Property(x => x.IdDrm).HasColumnName(@"IdDRM").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Drm).HasColumnName(@"DRM").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            HasMany(t => t.DilveDrms).WithMany(t => t.TDrms).Map(m =>
            {
                m.ToTable("DILVE_DRM_Equivalencias", "dbo");
                m.MapLeftKey("IdDRM");
                m.MapRightKey("IdDRMDILVE");
            });
        }
    }
}