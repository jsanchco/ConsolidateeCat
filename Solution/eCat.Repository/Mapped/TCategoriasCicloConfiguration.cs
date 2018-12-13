namespace eCat.Repository.Mapped
{
    public class TCategoriasCicloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TCategoriasCiclo>
    {
        public TCategoriasCicloConfiguration()
            : this("dbo")
        {
        }

        public TCategoriasCicloConfiguration(string schema)
        {
            ToTable("T_CategoriasCiclos", schema);
            HasKey(x => x.Codigo);

            Property(x => x.IdCategoriaCiclo).HasColumnName(@"IdCategoriaCiclo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Codigo).HasColumnName(@"Codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("tinyint").IsRequired();
            HasMany(t => t.DilveCicloEducativoAneles).WithMany(t => t.TCategoriasCicloes).Map(m =>
            {
                m.ToTable("DILVE_CicloEducativoANELE_Equivalencias", "dbo");
                m.MapLeftKey("IdCategoriaCiclo");
                m.MapRightKey("IdCicloEducaticoANELE");
            });
        }
    }
}