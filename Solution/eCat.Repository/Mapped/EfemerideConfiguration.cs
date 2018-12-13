namespace eCat.Repository.Mapped
{
    public class EfemerideConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Efemeride>
    {
        public EfemerideConfiguration()
            : this("dbo")
        {
        }

        public EfemerideConfiguration(string schema)
        {
            ToTable("Efemerides", schema);
            HasKey(x => x.IdEfemeride);

            Property(x => x.IdEfemeride).HasColumnName(@"IDEfemeride").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Efemeride_).HasColumnName(@"Efemeride").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(125);
            Property(x => x.Dia).HasColumnName(@"Dia").HasColumnType("tinyint").IsOptional();
            Property(x => x.Mes).HasColumnName(@"Mes").HasColumnType("tinyint").IsOptional();
            Property(x => x.Anyo).HasColumnName(@"Anyo").HasColumnType("smallint").IsOptional();
            Property(x => x.IdGrupoEfemeride).HasColumnName(@"IDGrupoEfemeride").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.EfemeridesGrupos).WithMany(b => b.Efemerides).HasForeignKey(c => c.IdGrupoEfemeride).WillCascadeOnDelete(false); // FK_Efemerides_EfemeridesGrupos
            HasMany(t => t.FichasBases).WithMany(t => t.Efemerides).Map(m =>
            {
                m.ToTable("RelFichasEfemerides", "dbo");
                m.MapLeftKey("IDEfemeride");
                m.MapRightKey("IDInterno");
            });
        }
    }
}