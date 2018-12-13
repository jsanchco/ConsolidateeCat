namespace eCat.Repository.Mapped
{
    public class DtpropertyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Dtproperty>
    {
        public DtpropertyConfiguration()
            : this("dbo")
        {
        }

        public DtpropertyConfiguration(string schema)
        {
            ToTable("dtproperties", schema);
            HasKey(x => new { x.Id, x.Property });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Objectid).HasColumnName(@"objectid").HasColumnType("int").IsOptional();
            Property(x => x.Property).HasColumnName(@"property").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"value").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Uvalue).HasColumnName(@"uvalue").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Lvalue).HasColumnName(@"lvalue").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Version).HasColumnName(@"version").HasColumnType("int").IsRequired();
        }
    }
}