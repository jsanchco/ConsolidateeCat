namespace eCat.Repository.Mapped
{
    public class DilveRoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveRole>
    {
        public DilveRoleConfiguration()
            : this("dbo")
        {
        }

        public DilveRoleConfiguration(string schema)
        {
            ToTable("DILVE_Roles", schema);
            HasKey(x => x.IdRol);

            Property(x => x.IdRol).HasColumnName(@"IdRol").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoRol).HasColumnName(@"CodigoRol").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.Roles).WithMany(t => t.DilveRoles).Map(m =>
            {
                m.ToTable("DILVE_Roles_Equivalencias", "dbo");
                m.MapLeftKey("IdRolDilve");
                m.MapRightKey("IdRolECat");
            });
        }
    }
}