namespace eCat.Repository.Mapped
{
    public class DilveMateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveMateria>
    {
        public DilveMateriaConfiguration()
            : this("dbo")
        {
        }

        public DilveMateriaConfiguration(string schema)
        {
            ToTable("DILVE_Materias", schema);
            HasKey(x => x.IdMateriaDilve);

            Property(x => x.IdMateriaDilve).HasColumnName(@"IdMateriaDILVE").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoMateriaDilve).HasColumnName(@"CodigoMateriaDILVE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.TSubcategoriasMaterias).WithMany(t => t.DilveMaterias).Map(m =>
            {
                m.ToTable("DILVE_Materias_Equivalencias", "dbo");
                m.MapLeftKey("IdMateriaDILVE");
                m.MapRightKey("IdSubcategoriaMateria");
            });
        }
    }
}