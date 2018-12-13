namespace eCat.Repository.Mapped
{
    public class TTiposMaterialEducativoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposMaterialEducativo>
    {
        public TTiposMaterialEducativoConfiguration()
            : this("dbo")
        {
        }

        public TTiposMaterialEducativoConfiguration(string schema)
        {
            ToTable("T_TiposMaterialEducativo", schema);
            HasKey(x => x.IdTipoMaterialEducativo);

            Property(x => x.IdTipoMaterialEducativo).HasColumnName(@"IdTipoMaterialEducativo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoMaterialEducativo).HasColumnName(@"TipoMaterialEducativo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            HasMany(t => t.DilveMaterialEducativoAneles).WithMany(t => t.TTiposMaterialEducativoes).Map(m =>
            {
                m.ToTable("DILVE_MaterialEducativoANELE_Equivalencias", "dbo");
                m.MapLeftKey("IdTipoMaterialEducativo");
                m.MapRightKey("IdTipoMaterialEducativoANELE");
            });
        }
    }
}