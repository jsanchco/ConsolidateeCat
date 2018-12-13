namespace eCat.Repository.Mapped
{
    public class DilveCursoAneleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveCursoAnele>
    {
        public DilveCursoAneleConfiguration()
            : this("dbo")
        {
        }

        public DilveCursoAneleConfiguration(string schema)
        {
            ToTable("DILVE_CursoANELE", schema);
            HasKey(x => x.IdCursoAnele);

            Property(x => x.IdCursoAnele).HasColumnName(@"IdCursoANELE").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoCursoAnele).HasColumnName(@"CodigoCursoANELE").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            HasMany(t => t.TEdadCursoes).WithMany(t => t.DilveCursoAneles).Map(m =>
            {
                m.ToTable("DILVE_CursoANELE_Equivalencias", "dbo");
                m.MapLeftKey("IdCursoANELE");
                m.MapRightKey("IdCursoGradoEdad");
            });
        }
    }
}