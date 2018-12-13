namespace eCat.Repository.Mapped
{
    public class RoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Role>
    {
        public RoleConfiguration()
            : this("dbo")
        {
        }

        public RoleConfiguration(string schema)
        {
            ToTable("Roles", schema);
            HasKey(x => x.IdRol);

            Property(x => x.IdRol).HasColumnName(@"IDRol").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Es).HasColumnName(@"ES").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Cat).HasColumnName(@"CAT").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.En).HasColumnName(@"EN").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}