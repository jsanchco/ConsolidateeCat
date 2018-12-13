namespace eCat.Repository.Mapped
{
    public class RelFichasPersonaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.RelFichasPersona>
    {
        public RelFichasPersonaConfiguration()
            : this("dbo")
        {
        }

        public RelFichasPersonaConfiguration(string schema)
        {
            ToTable("RelFichasPersonas", schema);
            HasKey(x => new { x.IdInterno, x.IdRol, x.IdPersona });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRol).HasColumnName(@"IDRol").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPersona).HasColumnName(@"IDPersona").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsOptional();
            Property(x => x.Disponible).HasColumnName(@"Disponible").HasColumnType("bit").IsRequired();
            Property(x => x.Interno).HasColumnName(@"Interno").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.RelFichasPersonas).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_RelFichasPersonas_FichasBase
            HasRequired(a => a.Persona).WithMany(b => b.RelFichasPersonas).HasForeignKey(c => c.IdPersona).WillCascadeOnDelete(false); // FK_RelFichasPersonas_Personas
            HasRequired(a => a.Role).WithMany(b => b.RelFichasPersonas).HasForeignKey(c => c.IdRol).WillCascadeOnDelete(false); // FK_RelFichasPersonas_Roles
        }
    }
}