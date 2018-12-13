namespace eCat.Repository.Mapped
{
    public class RolesIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.RolesIdioma>
    {
        public RolesIdiomaConfiguration()
            : this("dbo")
        {
        }

        public RolesIdiomaConfiguration(string schema)
        {
            ToTable("Roles_Idioma", schema);
            HasKey(x => new { x.IdRol, x.IdIdiomaInterface });

            Property(x => x.IdRol).HasColumnName(@"IdRol").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.RolesIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_Roles_Idioma_T_Idiomas_Plataforma
        }
    }
}