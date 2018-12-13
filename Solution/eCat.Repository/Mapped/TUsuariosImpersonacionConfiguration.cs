namespace eCat.Repository.Mapped
{
    public class TUsuariosImpersonacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TUsuariosImpersonacion>
    {
        public TUsuariosImpersonacionConfiguration()
            : this("dbo")
        {
        }

        public TUsuariosImpersonacionConfiguration(string schema)
        {
            ToTable("T_Usuarios_impersonacion", schema);
            HasKey(x => new { x.Login, x.Dominio });

            Property(x => x.Login).HasColumnName(@"Login").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Dominio).HasColumnName(@"Dominio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Defecto).HasColumnName(@"Defecto").HasColumnType("bit").IsRequired();
        }
    }
}